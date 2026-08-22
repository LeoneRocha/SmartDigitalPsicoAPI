# Conjunto Homologado — Ciclo 2026-07 (Migração .NET 10 + Central Package Management)

**Data:** 2026-07-31  
**Guia base:** [GuiaGenericoAtualizacaoPacotes.md](file:///c:/git/SMARTDIGITALPSICO/SmartDigitalPsicoAPI/DOCUMENTACAO/UpdatePackages/GuiaGenericoAtualizacaoPacotes.md)  
**Solução:** [SmartDigitalPsicoAPI.sln](file:///c:/git/SMARTDIGITALPSICO/SmartDigitalPsicoAPI/SmartDigitalPsicoAPI.sln)  
**Escopo:** Backend .NET (`Directory.Packages.props` / TFM `net10.0`)  

---

## 1. NuGet Aplicado ([Directory.Packages.props](file:///c:/git/SMARTDIGITALPSICO/SmartDigitalPsicoAPI/Directory.Packages.props))

### Bloco A — Plataforma .NET 10 (patch 10.0.10)

Todos os pacotes de plataforma ASP.NET Core e Microsoft.Extensions foram centralizados no patch **10.0.10**:

| Pacote | Versão Aplicada | Finalidade |
| ------ | --------------- | ---------- |
| `Microsoft.AspNetCore.Authentication.JwtBearer` | **10.0.10** | Autenticação JWT na WebAPI |
| `Microsoft.AspNetCore.Mvc.Testing` | **10.0.10** | Testes de integração da WebAPI |
| `Microsoft.Extensions.Caching.Memory` | **10.0.10** | Cache em memória |
| `Microsoft.Extensions.Configuration.FileExtensions` | **10.0.10** | Provedor de configuração por arquivo |
| `Microsoft.Extensions.Configuration.Json` | **10.0.10** | Leitura de `appsettings.json` |
| `Microsoft.Extensions.Hosting` | **10.0.10** | Generic Host (.NET 10) |
| `Microsoft.Extensions.Hosting.WindowsServices` | **10.0.10** | Host para execução como Windows Service |
| `Microsoft.Extensions.Identity.Core` | **10.0.10** | Abstrações de identidade e usuários |

---

### Bloco B — Persistência (EF Core 9 + Pomelo 9 — Trava Pomelo)

> [!IMPORTANT]
> **Trava de Grafo do EF Core 10**: O provider `Pomelo.EntityFrameworkCore.MySql 9.0.0` requer compatibilidade com `Microsoft.EntityFrameworkCore <= 9.x`. O bloco inteiro do EF Core permanece estritamente fixado em **9.0.18** até a disponibilização de versão oficial 10.x do Pomelo.

| Pacote | Versão Aplicada | Latest NuGet | Justificativa se != latest |
| ------ | --------------- | ------------ | -------------------------- |
| `Microsoft.EntityFrameworkCore` | **9.0.18** | 10.0.10 | Pomelo 9.0.0 exige EF Core <= 9.x |
| `Microsoft.EntityFrameworkCore.Abstractions` | **9.0.18** | 10.0.10 | Alinhado com EF Core 9 |
| `Microsoft.EntityFrameworkCore.Design` | **9.0.18** | 10.0.10 | Alinhado com EF Core 9 |
| `Microsoft.EntityFrameworkCore.InMemory` | **9.0.18** | 10.0.10 | Alinhado com EF Core 9 |
| `Microsoft.EntityFrameworkCore.Sqlite` | **9.0.18** | 10.0.10 | Alinhado com EF Core 9 |
| `Microsoft.EntityFrameworkCore.SqlServer` | **9.0.18** | 10.0.10 | Alinhado com EF Core 9 |
| `Microsoft.EntityFrameworkCore.Tools` | **9.0.18** | 10.0.10 | Alinhado com EF Core 9 |
| `Pomelo.EntityFrameworkCore.MySql` | **9.0.0** | 9.0.0 | Latest oficial compatível com EF 9 |
| `Microsoft.Data.SqlClient` | **6.1.6** | 6.1.6 | Override transitivo seguro para SQL Server |
| `SQLitePCLRaw.bundle_e_sqlite3` | **3.0.5** | 3.0.5 | Override transitivo (elimina alertas GHSA/NU1903) |

**Ação arquitetural:** Remoção definitiva do pacote órfão `MySql.EntityFrameworkCore` do projeto [SmartDigitalPsico.Data.csproj](file:///c:/git/SMARTDIGITALPSICO/SmartDigitalPsicoAPI/SmartDigitalPsico.Data/SmartDigitalPsico.Data.csproj), unificando a persistência MySQL no Pomelo.

---

### Bloco C — OpenAPI, Logging e Tokens

| Pacote | Versão Aplicada | Finalidade |
| ------ | --------------- | ---------- |
| `Swashbuckle.AspNetCore` | **10.2.3** | Geração OpenAPI / Swagger compatível com .NET 10 |
| `Swashbuckle.AspNetCore.Annotations` | **10.2.3** | Anotações Swagger |
| `Swashbuckle.AspNetCore.Filters` | **10.0.1** | Filtros de exemplo e autorização Swagger |
| `Serilog` | **4.4.0** | Engine de logging estruturado |
| `Serilog.AspNetCore` | **10.0.0** | Integração do Serilog no pipeline ASP.NET Core 10 |
| `Serilog.Extensions.Hosting` | **10.0.0** | Integração com Generic Host |
| `Serilog.Sinks.Console` | **6.1.1** | Sink de console |
| `Serilog.Sinks.File` | **7.0.0** | Sink de arquivos rotativos |
| `Microsoft.IdentityModel.JsonWebTokens` | **8.22.0** | Emissão e validação de tokens JWT |
| `Scrutor` | **7.0.0** | Injeção de dependência por escaneamento de assembly |

---

### Bloco D — Utilitários, Relatórios e Integrações

| Pacote | Versão Aplicada | Finalidade |
| ------ | --------------- | ---------- |
| `AutoMapper` | **16.2.0** | Mapeamento DTO/Entidade (configuração atualizada para .NET 10) |
| `FluentValidation` | **12.1.1** | Validação de regras e DTOs |
| `FluentValidation.DependencyInjectionExtensions` | **12.1.1** | Registro automático de validadores |
| `Newtonsoft.Json` | **13.0.4** | Serialização legada complementar |
| `Polly` / `Polly.Core` | **8.7.0** | Resiliência e políticas de retry |
| `Bogus` | **35.6.5** | Geração de dados de teste / mocks |
| `HtmlSanitizer` | **9.1.982** | Sanitização de HTML |
| `AngleSharp` / `AngleSharp.Css` | **1.7.0** / **1.0.1** | Parsing DOM e CSS para o sanitizador |
| `DocumentFormat.OpenXml` / `Framework` | **3.5.1** | Exportação de planilhas Excel |
| `PDFsharp` / `PDFsharp-MigraDoc` | **6.2.4** | Geração de documentos PDF |
| `QuestPDF` | **2026.7.2** | Geração moderna de relatórios em PDF |
| `Microsoft.VisualStudio.Azure.Containers.Tools.Targets` | **1.23.0** | Ferramentas de suporte a Docker no Visual Studio |
| `Microsoft.Azure.WebJobs` / `Core` | **3.0.47** | Azure WebJobs SDK |
| `Microsoft.Azure.WebJobs.Extensions` | **5.2.1** | Extensões para Azure WebJobs |
| `Azure.Identity` | **1.21.0** | Autenticação no ecossistema Azure |
| `Azure.Monitor.OpenTelemetry.AspNetCore` | **1.6.0** | Telemetria OpenTelemetry / Azure Monitor |
| `Azure.Storage.Blobs` | **12.29.1** | Armazenamento de arquivos Blob Storage |
| `Azure.Storage.Queues` | **12.27.1** | Filas do Azure Storage |
| `Azure.Data.Tables` | **12.11.0** | Armazenamento NoSQL Azure Tables |

---

### Bloco E — Testes (NUnit 4 + Ecossistema)

| Pacote | Versão Aplicada | Latest NuGet | Justificativa se != latest |
| ------ | --------------- | ------------ | -------------------------- |
| `Microsoft.NET.Test.Sdk` | **18.8.1** | 18.8.1 | Runner do VSTest / dotnet test |
| `NUnit` | **4.6.1** | 4.6.1 | Framework de testes unitários padrão da solução |
| `NUnit3TestAdapter` | **6.2.0** | 6.2.0 | Adaptador NUnit para VSTest |
| `NUnit.Analyzers` | **4.14.0** | 4.14.0 | Analisadores estáticos do NUnit |
| `Moq` | **4.20.72** | 4.20.72 | Criação de mocks e stubs |
| `Moq.EntityFrameworkCore` | **9.0.0.10** | 10.0.0.2 | **Pin obrigatório** alinhado ao EF Core 9 (Bloco B) |
| `AwesomeAssertions` | **9.5.0** | 9.5.0 | Biblioteca fluente de asserções |
| `coverlet.collector` | **10.0.1** | 10.0.1 | Coletor de cobertura VSTest |
| `coverlet.msbuild` | **10.0.1** | 10.0.1 | Coletor de cobertura MSBuild |
| `System.IdentityModel.Tokens.Jwt` | **8.22.0** | 8.22.0 | Alinhado com a família IdentityModel |

---

## 2. Validações Executadas

```text
Restore:   dotnet restore SmartDigitalPsicoAPI.sln    -> 0 conflitos / 0 NU1107 / 0 NU1202
Build:     dotnet build SmartDigitalPsicoAPI.sln -c Release -> 0 erros
Testes:    dotnet test SmartDigitalPsicoAPI.sln -c Release  -> 100% aprovados em todas as suítes
Migration: Migration temporária ValidacaoPosUpdateDotNet10  -> 0 alterações estruturais DDL
```

---

## 3. Riscos Residuais e Próximos Passos

1. **EF Core 10 (Conjunto v2):** Destravar quando `Pomelo.EntityFrameworkCore.MySql` oficial publicar release 10.x no nuget.org; subir em conjunto com `Moq.EntityFrameworkCore 10.x`.
2. **WebJobs SDK:** Monitorar suporte a longo prazo do WebJobs 3.x no .NET 10; avaliar evolução para Azure Functions Worker Isolated ou BackgroundService dedicado.
