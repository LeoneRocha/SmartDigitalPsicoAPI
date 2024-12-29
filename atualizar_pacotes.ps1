#Set-ExecutionPolicy RemoteSigned -Scope Process
#PS C:\Users\SeuUsuario> cd C:\caminho\para\o\diretorio
#PS C:\caminho\para\o\diretorio> Set-ExecutionPolicy RemoteSigned -Scope Process
#PS C:\caminho\para\o\diretorio> .\atualizar_pacotes.ps1
#D:\GITHUB\SmartDigitalPsicoAPI\atualizar_pacotes.ps1

# Define o caminho para o arquivo de pacotes desatualizados no diret�rio corrente
$currentDirectory = Get-Location
$outdatedPackagesFile = "$currentDirectory\outdated_packages.txt"

# Lista os pacotes desatualizados e exporta para um arquivo de texto
dotnet list package --outdated > $outdatedPackagesFile

# L� o arquivo de texto e pergunta ao usu�rio se deseja prosseguir
if (Test-Path $outdatedPackagesFile) {
    Write-Output "Pacotes desatualizados listados em $outdatedPackagesFile"
    $proceed = Read-Host "Deseja prosseguir com a atualiza��o dos pacotes? (s/n)"
    
    if ($proceed -eq 's') {
        # Atualiza cada pacote
        Get-Content $outdatedPackagesFile | ForEach-Object {
            if ($_ -match '^>\s+(\S+)\s+(\S+)\s+(\S+)\s+(\S+)$') {
                $packageName = $matches[1]
                $latestVersion = $matches[4]

                # Verifica se o pacote pertence a um projeto .dcproj e pula se for o caso
                if ($packageName.EndsWith(".dcproj")) {
                    Write-Output "Ignorando $packageName..."
                    return
                }

                Write-Output "Atualizando $packageName para a vers�o $latestVersion..."
                dotnet add package $packageName --version $latestVersion
            }
        }

        # Restaura os pacotes
        dotnet restore
        
        Write-Output "Atualiza��o conclu�da. Pressione qualquer tecla para finalizar."
        Read-Host -Prompt "Pressione Enter para finalizar"
    } else {
        Write-Output "Atualiza��o cancelada pelo usu�rio."
    }
} else {
    Write-Output "Arquivo de pacotes desatualizados n�o encontrado."
}
