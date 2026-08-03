# Adds Portuguese XML <summary> docs to public/internal types and methods missing them.
param(
    [Parameter(Mandatory = $true)][string]$RootDir,
    [switch]$WhatIf
)

$ErrorActionPreference = 'Stop'
[Console]::OutputEncoding = [System.Text.Encoding]::UTF8

function Get-TypeKindLabel([string]$kind) {
    switch ($kind) {
        'class'     { 'Classe' }
        'interface' { 'Interface (contrato)' }
        'struct'    { 'Struct' }
        'enum'      { 'Enumeracao' }
        'record'    { 'Record' }
        default     { 'Tipo' }
    }
}

function Get-ContextFromPath([string]$relPath) {
    $p = $relPath -replace '\\', '/'
    if ($p -match '/DTO/') { return 'DTO de transferencia de dados entre camadas da API' }
    if ($p -match '/ModelEntity/') { return 'entidade de dominio persistida via EF Core' }
    if ($p -match '/Interfaces/Repository/') { return 'contrato de repositorio (acesso a dados)' }
    if ($p -match '/Interfaces/Service/') { return 'contrato de servico de negocio' }
    if ($p -match '/Interfaces/') { return 'contrato de abstracao do dominio' }
    if ($p -match '/Validation/') { return 'validador FluentValidation de regras de negocio' }
    if ($p -match '/Helpers/') { return 'utilitario auxiliar do dominio' }
    if ($p -match '/Constants/') { return 'constantes compartilhadas do sistema' }
    if ($p -match '/Enuns/') { return 'valores enumerados do dominio' }
    if ($p -match '/Hypermedia/') { return 'suporte a hypermedia/HATEOAS nas respostas' }
    if ($p -match '/VO/') { return 'value object / objeto de valor de resposta' }
    if ($p -match '/Security/') { return 'seguranca e autenticacao' }
    if ($p -match '/Contracts/') { return 'contrato compartilhado entre camadas' }
    if ($p -match '/Report/') { return 'geracao de relatorios' }
    if ($p -match '/Repository/') { return 'repositorio de persistencia' }
    if ($p -match '/Context/') { return 'contexto EF Core / configuracao de dados' }
    if ($p -match '/Controllers/') { return 'controller HTTP da WebAPI' }
    if ($p -match '/Configure/') { return 'configuracao de startup/DI da aplicacao' }
    if ($p -match '/Bussines/Schedule/') { return 'modulo de agendamento (Schedule)' }
    if ($p -match '/DataEntity/') { return 'servico de entidade de negocio' }
    if ($p -match '/Infrastructure/') { return 'infraestrutura transversal (cache, notificacao, etc.)' }
    if ($p -match '/Middleware/') { return 'middleware do pipeline HTTP' }
    if ($p -match '/Mock/') { return 'dados mock para seed/testes de configuracao EF' }
    if ($p -match '/TableEntityNoSQL/') { return 'entidade para armazenamento NoSQL' }
    if ($p -match '/Resiliency/') { return 'politicas de resiliencia' }
    if ($p -match '/AppException/') { return 'excecao de aplicacao do dominio' }
    if ($p -match '/API/') { return 'filtro/atributo da camada de API' }
    if ($p -match '/Events/') { return 'evento de dominio' }
    if ($p -match '/Mapper/') { return 'perfil de mapeamento AutoMapper' }
    if ($p -match '/DependeciesCollection/') { return 'agrupamento de dependencias para DI' }
    return 'componente do backend SmartDigitalPsico'
}

function Get-MethodResponsibility([string]$name) {
    if ($name -match '^(Create|Add|Insert|Save|Register)') { return 'cria ou persiste um novo registro/recurso' }
    if ($name -match '^(Update|Modify|Edit|Patch)') { return 'atualiza um registro/recurso existente' }
    if ($name -match '^(Delete|Remove|Cancel)') { return 'remove ou cancela um registro/recurso' }
    if ($name -match '^(Find|Get|Load|Fetch|Read|Query|Search|List)') { return 'consulta e retorna dados' }
    if ($name -match '^(Validate|Check|Ensure|Exists)') { return 'valida regras ou verifica existencia' }
    if ($name -match '^(Map|To|Convert|Build)') { return 'mapeia ou transforma dados entre modelos' }
    if ($name -match '^(Set|Configure)') { return 'configura estado ou dependencias' }
    if ($name -match '^(Send|Notify|Dispatch)') { return 'dispara notificacao ou comunicacao' }
    if ($name -match '^(Book|Schedule|Request)') { return 'operacao de agendamento' }
    if ($name -match '^(Enable|Disable|EnableOrDisable)') { return 'altera o estado de habilitacao do recurso' }
    return "executa a operacao ${name}"
}

function Has-PrecedingSummary([string[]]$lines, [int]$index) {
    $start = [Math]::Max(0, $index - 12)
    for ($i = $index - 1; $i -ge $start; $i--) {
        $t = $lines[$i].Trim()
        if ($t -eq '' -or $t.StartsWith('[') -or $t.StartsWith('//') -or $t -match '^#') { continue }
        if ($t -match '<summary>') { return $true }
        if ($t.StartsWith('///')) { continue }
        break
    }
    return $false
}

function Get-Indent([string]$line) {
    if ($line -match '^(\s*)') { return $Matches[1] }
    return ''
}

function New-TypeSummary([string]$indent, [string]$kind, [string]$name, [string]$context) {
    $label = Get-TypeKindLabel $kind
    @(
        "$indent/// <summary>",
        "$indent/// $label responsavel por ${name}.",
        "$indent/// Responsabilidade: ${context}.",
        "$indent/// Relacao: integra as camadas Domain/Data/Service/WebAPI do SmartDigitalPsico.",
        "$indent/// </summary>"
    )
}

function New-MethodSummary([string]$indent, [string]$name) {
    $resp = Get-MethodResponsibility $name
    @(
        "$indent/// <summary>",
        "$indent/// Metodo ${name}: ${resp}.",
        "$indent/// </summary>"
    )
}

function Process-File([string]$filePath, [string]$rootDir) {
    $rel = $filePath.Substring($rootDir.Length).TrimStart('\', '/')
    $context = Get-ContextFromPath $rel
    $raw = [IO.File]::ReadAllText($filePath)
    $lines = [regex]::Split($raw, '\r?\n')
    # Drop trailing empty from split if file ends with newline
    if ($lines.Length -gt 0 -and $lines[-1] -eq '') {
        $lines = $lines[0..($lines.Length - 2)]
    }
    $out = New-Object System.Collections.Generic.List[string]
    $changed = 0
    $i = 0
    while ($i -lt $lines.Length) {
        $line = $lines[$i]

        if ($line -match '^\s*(public|internal)\s+(static\s+)?(partial\s+)?(abstract\s+)?(sealed\s+)?(class|interface|struct|enum|record)\s+(\w+)') {
            $kind = $Matches[6]
            $name = $Matches[7]
            if (-not (Has-PrecedingSummary $lines $i)) {
                $indent = Get-Indent $line
                foreach ($s in (New-TypeSummary $indent $kind $name $context)) { $out.Add($s) }
                $changed++
            }
            $out.Add($line)
            $i++
            continue
        }

        $isMethod = $false
        $methodName = $null
        if ($line -match '^\s*(public|internal|protected)\s+(?:(?:static|virtual|override|async|new|sealed|partial|extern)\s+)*(?:[\w\.<>\[\],\?]+\s+)?(\w+)\s*\(') {
            $methodName = $Matches[2]
            if ($methodName -notin @('if','for','foreach','while','switch','using','return','catch','lock','fixed','where')) {
                $isMethod = $true
                if ($line -match '\{\s*get') { $isMethod = $false }
            }
        }
        elseif ($line -match '^\s*(public|internal|protected)\s+(\w+)\s*\(') {
            $methodName = $Matches[2]
            $isMethod = $true
        }

        if ($isMethod -and $methodName) {
            if (-not (Has-PrecedingSummary $lines $i)) {
                $indent = Get-Indent $line
                foreach ($s in (New-MethodSummary $indent $methodName)) { $out.Add($s) }
                $changed++
            }
        }

        $out.Add($line)
        $i++
    }

    if ($changed -gt 0) {
        if (-not $WhatIf) {
            [IO.File]::WriteAllText($filePath, (($out -join "`r`n") + "`r`n"), [System.Text.UTF8Encoding]::new($false))
        }
        return $changed
    }
    return 0
}

$files = Get-ChildItem -Path $RootDir -Recurse -Filter *.cs -File |
    Where-Object { $_.FullName -notmatch '\\(obj|bin)\\' }

$total = 0
$fileCount = 0
foreach ($f in $files) {
    $n = Process-File $f.FullName $RootDir
    if ($n -gt 0) {
        $fileCount++
        $total += $n
        Write-Host ("{0}: +{1}" -f $f.FullName.Substring($RootDir.Length), $n)
    }
}
Write-Host "DONE files=$fileCount members=$total"
