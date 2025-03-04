# Caminho fixo do executavel do servico
$ServiceExePath = "MyfolderRoot\SmartDigitalPsico.WindowsService.exe"

# Configuracoes fixas do servico
$ServiceName = "SmartDigitalPsicoWindowsService"
$DisplayName = "Smart Digital Psico - Windows Service"
$Description = "Atendimento Inteligente Digital De Pacientes de Psicologia. Sistema de cadastro de prontuario de paciente de psicologia. Esse WindowsService sera para processamentos background jobs e tarefas de segundo plano."
$StartupType = "Automatic"

# Verifica se o executavel informado existe
if (-not (Test-Path $ServiceExePath)) {
    Write-Error "Erro (PT): O arquivo especificado nao foi encontrado: $ServiceExePath / Error (EN): The specified file was not found: $ServiceExePath"
    exit 1
}

# Verifica se o servico ja existe
$existingService = Get-Service -Name $ServiceName -ErrorAction SilentlyContinue
if ($existingService) {
    Write-Host "Aviso (PT): O servico '$ServiceName' ja existe. Sera removido antes de prosseguir. / Warning (EN): The service '$ServiceName' already exists. It will be removed before proceeding." -ForegroundColor Yellow
    try {
        Stop-Service -Name $ServiceName -Force -ErrorAction Stop
    } catch {
        Write-Warning "Aviso (PT): Nao foi possivel parar o servico, pode ser que ele nao esteja em execucao. / Warning (EN): Could not stop the service; it may not be running."
    }
    # Remove o servico utilizando o sc.exe
    sc.exe delete $ServiceName | Out-Null
    Start-Sleep -Seconds 2
}

# Cria o servico
try {
    New-Service -Name $ServiceName `
                -BinaryPathName "`"$ServiceExePath`"" `
                -DisplayName $DisplayName `
                -Description $Description `
                -StartupType $StartupType
    Write-Host "Sucesso (PT): Servico '$ServiceName' criado com sucesso. / Success (EN): Service '$ServiceName' created successfully." -ForegroundColor Green
} catch {
    Write-Error "Erro (PT): Erro ao criar o servico: $_ / Error (EN): Error creating the service: $_"
    exit 1
}

# Inicia o servico
try {
    Start-Service -Name $ServiceName
    Write-Host "Sucesso (PT): Servico '$ServiceName' iniciado com sucesso. / Success (EN): Service '$ServiceName' started successfully." -ForegroundColor Green
} catch {
    Write-Error "Erro (PT): Erro ao iniciar o servico: $_ / Error (EN): Error starting the service: $_"
    exit 1
}
#Exemplo de Comando para Execução
#powershell.exe -ExecutionPolicy Bypass -File "MyfolderRoot\Scripts\InstallService.ps1"  