
<h1 align="center">
     🏥  <a href="#" alt="Atendimento Inteligente Digital De Pacientes de Psicologia"> SmartDigitalPsico</a>
</h1>

<h3 align="center">
    💚 Atendimento Inteligente Digital De Pacientes de Psicologia. 
</h3>

<p align="center">    
   <img alt="License" src="https://img.shields.io/badge/license-MIT-brightgreen"> 
</p>

<h4 align="center">
	🚧 Em desenvolvimento 🚧
</h4>

---

Tabela de conteúdos
=================
<!--ts-->
   * [Sobre o projeto](#-sobre-o-projeto) 
   * [Links Front e Back](#-Links-Front-Back)
   * [Como executar o projeto](#-como-executar-o-projeto)
     * [Pré-requisitos](#pré-requisitos)
     * [Rodando o Backend (servidor)](#user-content--rodando-o-backend-servidor)
     * [Rodando a aplicação web (Frontend)](#user-content--rodando-a-aplicação-web-frontend)
   * [Tecnologias](#-tecnologias) 
   * [Como contribuir no projeto](#-como-contribuir-no-projeto)
   * [Autor](#-autor)
   * [Licença](#user-content--licença)
<!--te-->

---

## 💻 Sobre o projeto

🏥 Atendimento Inteligente Digital De Pacientes de Psicologia. Sistema de cadastro de prontuário de paciente de psicologia.

---

## ⚙️ Funcionalidades

- Cadastros de Perfil administrativo:
  - [x] Cadastro de Codnigurações gerais do sistema
  - [x] Cadastro de Especialidade do médico 
  - [x] Cadastro de Grupo de Funções de autorização dos usuarios.
  - [x] Cadastro de Profisão do Médico
  - [x] Cadastro de Gêneros para os cadastros.
  - [x] Cadastro de Idioma e traduções do BackEnd.
  - [x] Cadastro de usuários
  - [x] Cadastro de Médicos
- Cadastros de Perfil Médico:
  - [x] Upload e Donwload de arquivos do médico
  - [x] Cadastro de Paciente: 
    -  Upload e Donwload de arquivos do paciente.
    -  Informações Complementares do paciente.
    -  Informações de Hospitalização do paciente. 
    -  Informações sobre Medicamentos do paciente. 
    -  Anotação do Registro de atendimento ao paciente 

---

## ⚙️ Build Status e 🚀 Deploy Status

### Backend (API) :  

| **Ambiente** | **Build** | **Quality Gate**   |  **Snyk**  | **Deploy**  |
|--|--|--|--|--|
| Homologação| [![Build status](https://lionscorp.visualstudio.com/SMARTDIGITALPSICO/_apis/build/status/Homologation/CI-Homologation-SMARTDIGITALPSICO-API)](https://lionscorp.visualstudio.com/SMARTDIGITALPSICO/_build/latest?definitionId=20)  | [![Quality Gate Status](https://sonarcloud.io/api/project_badges/measure?project=lionscorp_smartdigitalpsico&metric=alert_status)](https://sonarcloud.io/summary/new_code?id=lionscorp_smartdigitalpsico) | [![Snykstatus](https://snyk.io/test/github/LeoneRocha/SmartDigitalPsicoAPI/badge.svg)](https://snyk.io/test/github/LeoneRocha/SmartDigitalPsicoAPI/badge.svg)|[![Release status](https://lionscorp.vsrm.visualstudio.com/_apis/public/Release/badge/4f28fc9c-3bc3-4ea2-8eac-62870312ef10/5/5)](https://lionscorp.vsrm.visualstudio.com/_apis/public/Release/badge/4f28fc9c-3bc3-4ea2-8eac-62870312ef10/5/5)
|
| Produção | [![Build status](https://lionscorp.visualstudio.com/SMARTDIGITALPSICO/_apis/build/status/Production/CI-Production-SMARTDIGITALPSICO-API)](https://lionscorp.visualstudio.com/SMARTDIGITALPSICO/_build/latest?definitionId=21)| [![Quality Gate Status](https://sonarcloud.io/api/project_badges/measure?project=lionscorp_smartdigitalpsico&metric=alert_status)](https://sonarcloud.io/summary/new_code?id=lionscorp_smartdigitalpsico) |[![Snykstatus](https://snyk.io/test/github/LeoneRocha/SmartDigitalPsicoAPI/badge.svg)](https://snyk.io/test/github/LeoneRocha/SmartDigitalPsicoAPI/badge.svg) |[![Release status](https://lionscorp.vsrm.visualstudio.com/_apis/public/Release/badge/4f28fc9c-3bc3-4ea2-8eac-62870312ef10/6/6)](https://lionscorp.vsrm.visualstudio.com/_apis/public/Release/badge/4f28fc9c-3bc3-4ea2-8eac-62870312ef10/6/6)|

### Front (Web) :  

| **Ambiente** | **Build** | **Quality Gate**   |  **Snyk**  | **Deploy**  |
|--|--|--|--|--|
| Homologação| [![Build status](https://lionscorp.visualstudio.com/SMARTDIGITALPSICO/_apis/build/status/Homologation/CI-Homologation-SMARTDIGITALPSICO-UI)](https://lionscorp.visualstudio.com/SMARTDIGITALPSICO/_build/latest?definitionId=28) | - | - |[![Release status](https://lionscorp.vsrm.visualstudio.com/_apis/public/Release/badge/4f28fc9c-3bc3-4ea2-8eac-62870312ef10/10/10)](https://lionscorp.vsrm.visualstudio.com/_apis/public/Release/badge/4f28fc9c-3bc3-4ea2-8eac-62870312ef10/10/10)
|
| Produção | [![Build status](https://lionscorp.visualstudio.com/SMARTDIGITALPSICO/_apis/build/status/Production/CI-Production-SMARTDIGITALPSICO-UI)](https://lionscorp.visualstudio.com/SMARTDIGITALPSICO/_build/latest?definitionId=30)| - |-|[![Release status](https://lionscorp.vsrm.visualstudio.com/_apis/public/Release/badge/4f28fc9c-3bc3-4ea2-8eac-62870312ef10/11/11)](https://lionscorp.vsrm.visualstudio.com/_apis/public/Release/badge/4f28fc9c-3bc3-4ea2-8eac-62870312ef10/11/11)|
   
---
## ⚙️ Links do Projeto
 
- [Repositorio - Git Hub ](https://github.com/LeoneRocha/SmartDigitalPsicoAPI/tree/developer) 
- [DevOps](https://lionscorp.visualstudio.com/SMARTDIGITALPSICO) 
- [DevOps - Pipelines](https://lionscorp.visualstudio.com/SMARTDIGITALPSICO/_build) 
- [DevOps - Deploys](https://lionscorp.visualstudio.com/SMARTDIGITALPSICO/_release) 
- [Contêiner de imagens - Docker Hub](https://hub.docker.com/u/leonecr) 
- [Hosting Front e Back - Azure](https://portal.azure.com) 
- [Hosting Banco de dados - Mysql na Uol](https://painelbd.host.uol.com.br/main.html?servicetype=mysql) 
- [Quality Gate - SonarCloud](https://sonarcloud.io/project/branches_list?id=lionscorp_smartdigitalpsico)
- [Vulnerabilities Gate - Snyk](https://app.snyk.io/org/leonerocha/projects?groupBy=targets&before&after&searchQuery=&sortBy=highest+severity&filters[Show]=&filters[Integrations]=&filters[CollectionIds]=)
 
---

## ⚙️ Links Front e Back

### Produção:  
   - [Backend](https://smartdigitalpsicoapi.azurewebsites.net) 
   - [Frontend](https://smartdigitalpsicoui.azurewebsites.net) 

### Homologação:  
   - [Backend](https://smartdigitalpsicoapi-staging.azurewebsites.net) 
   - [Frontend](https://smartdigitalpsicoui-staging.azurewebsites.net) 

---
   
##  ⚙️ Pré-requisitos

Antes de começar, você vai precisar ter instalado em sua máquina as seguintes ferramentas:
[Git](https://git-scm.com), [Node.js](https://nodejs.org/en/). 

Além disto é bom ter um editor para trabalhar com o código como [VSCode](https://code.visualstudio.com/)

- Visual Studio 2022 e [Visual studio Code](https://code.visualstudio.com/)
- [MySql](https://www.mysql.com/downloads/) ou  [Sql Server](https://www.microsoft.com/pt-br/sql-server/sql-server-downloads) 
- [.NET 8.0](https://www.microsoft.com/pt-br/sql-server/sql-server-downloads) 

---

## 🛠 Tecnologias
 
- .Net Core 8
- C#
- Entity Framework Core
- MySQL Connector
- Swagger
- Node.js
- Angular 14
- TypeScript
- Visual Studio 2022
- Visual Studio Code

## 🚀 Documentação API

<br />

A documentação da API pode ser acessada através do Swagger em :

https://smartdigitalpsicoapi.azurewebsites.net/swagger/index.html

---

## 🚀 Como executar o projeto

Este projeto é divido em duas partes:
1. Backend  
2. Frontend   

---

#### 🎲 Rodando o Backend (servidor)

```bash

# Clone este repositório
$ git clone git@github.com:tgmarinho/README-ecoleta.git

 

#### 🧭 Rodando a aplicação web (Frontend)

```bash

# Clone este repositório
$ git clone git@github.com:tgmarinho/README-ecoleta.git

# A aplicação será aberta na porta:3000 - acesse http://localhost:3000

```

## 🦸 Autor

<a href="https://www.linkedin.com/in/leone-costa-rocha-14049722">
 <b>Leone Costa Rocha</b></a>
 <br />
 <br />
 
[![Linkedin Badge](https://img.shields.io/badge/-Leone-blue?style=flat-square&logo=Linkedin&logoColor=white&link=https://www.linkedin.com/in/leone-costa-rocha-14049722)](https://www.linkedin.com/in/leone-costa-rocha-14049722) 

[![Gmail Badge](https://img.shields.io/badge/-leonecrocha@gmail.com-c14438?style=flat-square&logo=Gmail&logoColor=white&link=mailto:leonecrocha@gmail.com)](mailto:leonecrocha@gmail.com)

---

## 📝 Contribuindo
Contribuições são sempre bem-vindas. Se você deseja contribuir com o projeto, por favor, abra uma Issue ou um Pull Request.

---
## 📝 Como contribuir

Faça um fork do repositório
Crie uma branch para a sua feature: git checkout -b minha-feature
Faça commit das suas mudanças: git commit -m "Adiciona minha feature"
Faça push para a sua branch: git push origin minha-feature
Abra um Pull Request

---

## 📝 Licença

Este projeto esta sobe a licença [MIT](./LICENSE).

Feito por Leone Costa Rocha [Entre em contato!](https://www.linkedin.com/in/leone-costa-rocha-14049722)
 
