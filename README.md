# SmartDigitalPsico — API

<p align="center">
  <img alt="SmartDigitalPsico" title="#SmartDigitalPsico" src="./assets/banner.jpg" />
</p>

<p align="center">
  <img src="https://sonarcloud.io/api/project_badges/measure?project=lionscorp_smartdigitalpsico&metric=coverage"/>
  <img src="http://img.shields.io/static/v1?label=STATUS&message=EM%20DESENVOLVIMENTO&color=RED&style=for-the-badge"/>
</p>

<p align="center"><strong>Atendimento inteligente digital de pacientes de psicologia</strong> — API REST de prontuário e cadastros.</p>

<p align="center">🚧 Em desenvolvimento 🚧</p>

---

## Índice

- [Sobre o projeto](#sobre-o-projeto)
- [Funcionalidades](#funcionalidades)
- [Links de publicação](#links-de-publicação)
- [Build e deploy](#build-e-deploy)
- [Links do projeto](#links-do-projeto)
- [Pré-requisitos](#pré-requisitos)
- [Tecnologias](#tecnologias)
- [Documentação da API](#documentação-da-api)
- [Como executar](#como-executar)
- [Documentação interna](#documentação-interna)
- [Contribuindo](#contribuindo)
- [Autor](#autor)
- [Licença](#licença)

---

## Sobre o projeto

Sistema de cadastro de prontuário de pacientes de psicologia. Este repositório contém o **backend** (`SmartDigitalPsicoAPI`): Web API, serviços, dados, testes, Windows Service e WebJob.

Frontend (dashboard Angular): repositório [`SmartDigitalPsicoUIDashboard`](https://github.com/LeoneRocha/SmartDigitalPsicoUIDashboard) (ou pasta irmã neste monorepo local).

---

## Funcionalidades

**Perfil administrativo**

- [x] Configurações gerais do sistema
- [x] Especialidade do médico
- [x] Grupo de funções / autorização
- [x] Profissão do médico
- [x] Gêneros
- [x] Idioma e traduções (backend)
- [x] Usuários
- [x] Médicos

**Perfil médico**

- [x] Upload/download de arquivos do médico
- [x] Cadastro de paciente (arquivos, informações complementares, hospitalização, medicamentos, registro de atendimento)

---

## Links de publicação

### Produção

| Serviço | URL |
| ------- | --- |
| Backend (API / Swagger) | https://smartdigitalpsicoapi.azurewebsites.net/ |
| Frontend (UI — login) | https://smartdigitalpsicoui.azurewebsites.net/authpages/login |

> Ambiente de **homologação/staging não está mais disponível** (API e UI).

Swagger em produção: https://smartdigitalpsicoapi.azurewebsites.net/swagger/index.html

---

## Build e deploy

### Backend (API)

| Ambiente | Status pacote | Quality Gate | Vulnerabilidades | Publicação |
| -------- | ------------- | ------------ | ---------------- | ---------- |
| Produção | [![Build status](https://lionscorp.visualstudio.com/SMARTDIGITALPSICO/_apis/build/status/Production/CI-Production-SMARTDIGITALPSICO-API)](https://lionscorp.visualstudio.com/SMARTDIGITALPSICO/_build/latest?definitionId=21) | [![Quality Gate Status](https://sonarcloud.io/api/project_badges/measure?project=lionscorp_smartdigitalpsico&metric=alert_status)](https://sonarcloud.io/summary/new_code?id=lionscorp_smartdigitalpsico) | [![Snyk](https://snyk.io/test/github/LeoneRocha/SmartDigitalPsicoAPI/badge.svg)](https://snyk.io/test/github/LeoneRocha/SmartDigitalPsicoAPI) | [![Release](https://lionscorp.vsrm.visualstudio.com/_apis/public/Release/badge/4f28fc9c-3bc3-4ea2-8eac-62870312ef10/6/6)](https://lionscorp.visualstudio.com/SMARTDIGITALPSICO/_release) |

### Frontend (UI)

| Ambiente | Status pacote | Publicação |
| -------- | ------------- | ---------- |
| Produção | [![Build status](https://lionscorp.visualstudio.com/SMARTDIGITALPSICO/_apis/build/status/Production/CI-Production-SMARTDIGITALPSICO-UI)](https://lionscorp.visualstudio.com/SMARTDIGITALPSICO/_build/latest?definitionId=30) | [![Release](https://lionscorp.vsrm.visualstudio.com/_apis/public/Release/badge/4f28fc9c-3bc3-4ea2-8eac-62870312ef10/12/12)](https://lionscorp.visualstudio.com/SMARTDIGITALPSICO/_release) |

---

## Links do projeto

- [Repositório GitHub (API)](https://github.com/LeoneRocha/SmartDigitalPsicoAPI)
- [Azure DevOps](https://lionscorp.visualstudio.com/SMARTDIGITALPSICO)
- [Pipelines](https://lionscorp.visualstudio.com/SMARTDIGITALPSICO/_build)
- [Releases](https://lionscorp.visualstudio.com/SMARTDIGITALPSICO/_release)
- [Docker Hub](https://hub.docker.com/u/leonecr)
- [Azure Portal](https://portal.azure.com)
- [SonarCloud](https://sonarcloud.io/project/branches_list?id=lionscorp_smartdigitalpsico)
- [Snyk](https://app.snyk.io/org/leonerocha/projects)
- [SwaggerHub](https://app.swaggerhub.com/apis/LEOCRLEM/smart-digital_psico_web_api/v1)

---

## Pré-requisitos

- [Git](https://git-scm.com)
- [Visual Studio 2022](https://visualstudio.microsoft.com/) ou [VS Code](https://code.visualstudio.com/)
- [.NET SDK 10](https://dotnet.microsoft.com/download/dotnet/10.0)
- [MySQL](https://www.mysql.com/downloads/) e/ou [SQL Server](https://www.microsoft.com/sql-server/sql-server-downloads)
- Para o frontend: [Node.js](https://nodejs.org/) (ver `engines` do UI Dashboard)

---

## Tecnologias

- .NET 10 / ASP.NET Core
- C#
- Entity Framework Core (SqlServer e/ou MySQL via Pomelo)
- JWT (`JwtBearer`)
- Serilog
- Swagger / Swashbuckle
- Docker / Azure App Service
- Frontend companion: Angular 14 + TypeScript (UI Dashboard)

---

## Documentação da API

- Produção: https://smartdigitalpsicoapi.azurewebsites.net/swagger/index.html
- Local (após `dotnet run`): `https://localhost:53892/swagger` (ver `launchSettings.json`)
- Geração de clientes: https://editor.swagger.io/

---

## Como executar

### Backend (este repositório)

```bash
git clone https://github.com/LeoneRocha/SmartDigitalPsicoAPI.git
cd SmartDigitalPsicoAPI

# Ajustar connection strings / secrets em appsettings ou User Secrets
dotnet restore SmartDigitalPsicoAPI.sln
dotnet build SmartDigitalPsicoAPI.sln -c Release
dotnet run --project SmartDigitalPsico.WebAPI/SmartDigitalPsico.WebAPI.csproj
```

URLs locais típicas: `https://localhost:53892` e `http://localhost:53893`.

Testes:

```bash
dotnet test SmartDigitalPsicoAPI.sln -c Release
```

Docker (exemplo):

```bash
docker build -f SmartDigitalPsico.WebAPI/Dockerfile -t smartdigitalpsicoapi .
docker run -p 8080:80 smartdigitalpsicoapi
```

### Frontend (UI Dashboard)

Clone/abra o projeto `SmartDigitalPsicoUIDashboard`, configure `APIUrl` em `src/environments/` e execute `npm install` + `npm start`.  
Publicação: https://smartdigitalpsicoui.azurewebsites.net/authpages/login

---

## Documentação interna

Planejamento e migrações em `DOCUMENTACAO/`:

- `DOCUMENTACAO/API/` — levantamento e plano .NET 8 → 10
- `DOCUMENTACAO/UpdateDotNet10/` — RFC, plano de ação, relatório
- `DOCUMENTACAO/GuiaGenericoAtualizacaoPacotes.md`

Anotações técnicas avulsas: pasta `Readme/` (rascunhos; o README oficial é este arquivo).

---

## Contribuindo

1. Fork do repositório  
2. Branch: `git checkout -b minha-feature`  
3. Commit e push  
4. Abra um Pull Request  

Issues e PRs são bem-vindos.

---

## Autor

**Leone Costa Rocha**

[![LinkedIn](https://img.shields.io/badge/-Leone-blue?style=flat-square&logo=Linkedin&logoColor=white)](https://www.linkedin.com/in/leone-costa-rocha-14049722)
[![Gmail](https://img.shields.io/badge/-leonecrocha@gmail.com-c14438?style=flat-square&logo=Gmail&logoColor=white)](mailto:leonecrocha@gmail.com)

---

## Licença

Este projeto está sob a licença [MIT](./LICENSE).
