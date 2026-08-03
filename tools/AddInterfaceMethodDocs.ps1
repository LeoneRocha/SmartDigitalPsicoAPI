param([string]$RootDir)
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
function Get-MethodResponsibility([string]$name) {
  if ($name -match '^(Create|Add|Insert|Save|Register)') { return 'cria ou persiste um novo registro/recurso' }
  if ($name -match '^(Update|Modify|Edit|Patch)') { return 'atualiza um registro/recurso existente' }
  if ($name -match '^(Delete|Remove|Cancel)') { return 'remove ou cancela um registro/recurso' }
  if ($name -match '^(Find|Get|Load|Fetch|Read|Query|Search|List)') { return 'consulta e retorna dados' }
  if ($name -match '^(Validate|Check|Ensure|Exists)') { return 'valida regras ou verifica existência' }
  if ($name -match '^(Map|To|Convert|Build|Book)') { return 'mapeia, transforma ou agenda dados' }
  if ($name -match '^(Set|Configure)') { return 'configura estado ou dependências' }
  if ($name -match '^(Send|Notify|Dispatch)') { return 'dispara notificação ou comunicação' }
  return "executa a operação $name"
}
$total=0;$files=0
Get-ChildItem $RootDir -Recurse -Filter *.cs | Where-Object FullName -notmatch '\\(obj|bin)\\' | ForEach-Object {
  $raw = [IO.File]::ReadAllText($_.FullName)
  if ($raw -notmatch '\binterface\b') { return }
  $lines = [regex]::Split($raw, '\r?\n')
  if ($lines.Length -gt 0 -and $lines[-1] -eq '') { $lines = $lines[0..($lines.Length-2)] }
  $out = New-Object System.Collections.Generic.List[string]
  $changed=0; $inInterface=$false; $brace=0
  for ($i=0; $i -lt $lines.Length; $i++) {
    $line = $lines[$i]
    if ($line -match '\binterface\s+\w+') { $inInterface=$true; $brace=0 }
    if ($inInterface) {
      $brace += ([regex]::Matches($line, '\{')).Count - ([regex]::Matches($line, '\}')).Count
      if ($brace -lt 0) { $inInterface=$false }
      # interface method: return type Name( ... );
      if ($line -match '^\s+(?:static\s+)?([\w\.<>\[\],\?]+)\s+(\w+)\s*\(' -and $line -notmatch '^\s*(public|internal|protected|private|class|interface|struct|enum|record|namespace|using)\b') {
        $mname = $Matches[2]
        if ($mname -notin @('if','for','where','get','set') -and -not (Has-PrecedingSummary $lines $i)) {
          $indent = ($line -replace '^(\s*).*','$1')
          $resp = Get-MethodResponsibility $mname
          $out.Add("$indent/// <summary>")
          $out.Add("$indent/// Método ${mname}: ${resp}.")
          $out.Add("$indent/// </summary>")
          $changed++
        }
      }
      if ($brace -le 0 -and $line -match '\}') { $inInterface=$false }
    }
    $out.Add($line)
  }
  if ($changed -gt 0) {
    [IO.File]::WriteAllText($_.FullName, (($out -join "`r`n") + "`r`n"), [Text.UTF8Encoding]::new($false))
    $files++; $total += $changed
    Write-Host ("{0}: +{1}" -f $_.Name, $changed)
  }
}
Write-Host "DONE interface-methods files=$files members=$total"
