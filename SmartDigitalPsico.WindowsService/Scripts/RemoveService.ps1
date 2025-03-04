# Caminho fixo do executavel do servico (opcional para referência)
$ServiceExePath = "MyfolderRoot\SmartDigitalPsico.WindowsService.exe"

# Configuracoes fixas do servico
$ServiceName = "SmartDigitalPsicoWindowsService"
$DisplayName = "Smart Digital Psico - Windows Service"
$Description = "Atendimento Inteligente Digital De Pacientes de Psicologia. Sistema de cadastro de prontuario de paciente de psicologia. Esse WindowsService sera para processamentos background jobs e tarefas de segundo plano."
$StartupType = "Automatic"

# Verifica se o servico ja existe
$existingService = Get-Service -Name $ServiceName -ErrorAction SilentlyContinue

if ($existingService) {
    Write-Host "Aviso (PT): O servico '$ServiceName' ja existe e sera removido. / Warning (EN): The service '$ServiceName' exists and will be removed." -ForegroundColor Yellow
    try {
        Stop-Service -Name $ServiceName -Force -ErrorAction Stop
    } catch {
        Write-Warning "Aviso (PT): Nao foi possivel parar o servico, pode ser que ele nao esteja em execucao. / Warning (EN): Could not stop the service; it may not be running."
    }
    # Remove o servico utilizando o sc.exe
    sc.exe delete $ServiceName | Out-Null
    Start-Sleep -Seconds 2
    Write-Host "Sucesso (PT): Servico '$ServiceName' removido com sucesso. / Success (EN): Service '$ServiceName' removed successfully." -ForegroundColor Green
} else {
    Write-Host "Aviso (PT): Servico '$ServiceName' nao encontrado. / Warning (EN): Service '$ServiceName' not found." -ForegroundColor Yellow
}

#powershell.exe -ExecutionPolicy Bypass -File "MyfolderRoot\Script\RemoveService.ps1"
