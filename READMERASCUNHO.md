# SmartDigitalPsico

!Build Status
!Release Status

## Descrição

Atendimento Inteligente Digital De Pacientes de Psicologia. Sistema de cadastro de prontuário de paciente de psicologia.

## Índice

- Instalação
- Uso
- Documentação da API
- Testes
- Deploy
- Contribuição

## Instalação

Este projeto usa .NET Core 8 e Docker. Instruções para instalar:


# clone o repositório
git clone https://github.com/seuusuario/SmartDigitalPsico.git

# navegue até o diretório do projeto
cd SmartDigitalPsico

# construa a imagem Docker
docker build -t smartdigitalpsico .

# execute o contêiner Docker
docker run -p 8080:80 smartdigitalpsico











# SmartDigitalPsico  
Atendimento Inteligente Digital De Pacientes de Psicologia

API de cadastro de prontuário de paciente de psicologia
Este é um exemplo de uma API Restful em C# utilizando o framework Asp.Net Core 7 e banco de dados MySQL, desenvolvida para realizar o cadastro de prontuários de pacientes de psicologia.

Url API  https://github.com/LeoneRocha/SmartDigitalPsico/

# Requisitos
- Visual Studio 2022
- MySQL Server
- MySQL Workbench

# Tecnologias utilizadas

- Asp.Net Core 8
- Entity Framework Core
- MySQL Connector
- Swagger
- Visual Studio Code

# Funcionalidades
- Cadastro de usuários
- Login de usuários
- Listagem de usuários

# Instalação e configuração
Clonar o repositório Git:
bash 

git clone https://github.com/seu_usuario/repositorio.git

Abrir o projeto no Visual Studio 2022

Configurar a string de conexão com o banco de dados MySQL no arquivo appsettings.json.

Executar o comando abaixo no console do Package Manager para criar as tabelas do banco de dados:
  
update-database
Rodar a aplicação no Visual Studio

# Documentação
A documentação da API pode ser acessada através do Swagger em http://localhost:<porta>/swagger/index.html.
  
# Contribuindo
Contribuições são sempre bem-vindas. Se você deseja contribuir com o projeto, por favor, abra uma Issue ou um Pull Request.

# Como contribuir
Faça um fork do repositório
Crie uma branch para a sua feature: git checkout -b minha-feature
Faça commit das suas mudanças: git commit -m "Adiciona minha feature"
Faça push para a sua branch: git push origin minha-feature
Abra um Pull Request

# Licença
Este projeto está licenciado sob a licença MIT. Veja o arquivo LICENSE.md para mais detalhes.
