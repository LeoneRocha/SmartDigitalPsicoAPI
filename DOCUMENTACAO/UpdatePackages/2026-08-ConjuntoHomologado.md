# Conjunto Homologado — Ciclo 2026-08 (Governança e Homologação NuGet .NET 10)

**Data:** 2026-08-22  
**Guia base:** [GuiaGenericoAtualizacaoPacotes.md](file:///c:/git/SMARTDIGITALPSICO/SmartDigitalPsicoAPI/DOCUMENTACAO/UpdatePackages/GuiaGenericoAtualizacaoPacotes.md)  
**Solução:** [SmartDigitalPsicoAPI.sln](file:///c:/git/SMARTDIGITALPSICO/SmartDigitalPsicoAPI/SmartDigitalPsicoAPI.sln)  
**Escopo:** Backend .NET 10 (`Directory.Packages.props`)  

---

## 1. NuGet Aplicado ([Directory.Packages.props](file:///c:/git/SMARTDIGITALPSICO/SmartDigitalPsicoAPI/Directory.Packages.props))

### Bloco A — Plataforma .NET 10 (patch alinhado 10.0.10)

Todos os pacotes de plataforma ASP.NET Core e Microsoft.Extensions permanecem consolidados no patch **10.0.10**:

| Pacote | Versão Aplicada | Latest NuGet | Observações |
| ------ | --------------- | ------------ | ----------- |
| `Microsoft.AspNetCore.Authentication.JwtBearer` | **10.0.10** | 10.0.10 | Estável |
| `Microsoft.AspNetCore.Mvc.Testing` | **10.0.10** | 10.0.10 | Estável |
| `Microsoft.Extensions.Caching.Memory` | **10.0.10** | 10.0.10 | Estável |
| `Microsoft.Extensions.Configuration.FileExtensions` | **10.0.10** | 10.0.10 | Estável |
| `Microsoft.Extensions.Configuration.Json` | **10.0.10** | 10.0.10 | Estável |
| `Microsoft.Extensions.Hosting` | **10.0.10** | 10.0.10 | Estável |
| `Microsoft.Extensions.Hosting.WindowsServices` | **10.0.10** | 10.0.10 | Estável |
| `Microsoft.Extensions.Identity.Core` | **10.0.10** | 10.0.10 | Estável |

---

### Bloco B — Persistência (EF Core 9 + Pomelo 9 — Trava Pomelo Mantida)

> [!IMPORTANT]
> **Trava de Grafo Pomelo ↔ EF Core 10:** O provider `Pomelo.EntityFrameworkCore.MySql 9.0.0` continua como a versão oficial mais recente no NuGet.org e exige EF Core <= 9.x. A subida para `Microsoft.EntityFrameworkCore 10.x` permanece travada neste ciclo para garantir total integridade das operações de banco de dados MySQL e migrations.

| Pacote | Versão Anterior | Versão Aplicada | Latest NuGet | Justificativa se != latest |
| ------ | --------------- | --------------- | ------------ | -------------------------- |
| `Microsoft.EntityFrameworkCore` (7 pacotes) | 9.0.18 | **9.0.18** | 10.0.10 | Pomelo oficial ainda sem release estável 10.x para EF Core 10 |
| `Pomelo.EntityFrameworkCore.MySql` | 9.0.0 | **9.0.0** | 9.0.0 | Latest oficial compatível com EF Core 9 |
| `Microsoft.Data.SqlClient` | 6.1.6 | **6.1.6** | 6.1.6 | Override transitivo seguro para SQL Server |
| `SQLitePCLRaw.bundle_e_sqlite3` | 3.0.5 | **3.0.5** | 3.0.5 | Override transitivo de segurança (GHSA-2m69-gcr7-jv3q) |

---

### Bloco C — OpenAPI, Logging e Tokens

| Pacote | Versão Anterior | Versão Aplicada | Latest NuGet |
| ------ | --------------- | --------------- | ------------ |
| `Swashbuckle.AspNetCore` | 10.2.3 | **10.2.3** | 10.2.3 |
| `Swashbuckle.AspNetCore.Annotations` | 10.2.3 | **10.2.3** | 10.2.3 |
| `Swashbuckle.AspNetCore.Filters` | 10.0.1 | **10.0.1** | 10.0.1 |
| `Serilog` | 4.4.0 | **4.4.0** | 4.4.0 |
| `Serilog.AspNetCore` | 10.0.0 | **10.0.0** | 10.0.0 |
| `Serilog.Extensions.Hosting` | 10.0.0 | **10.0.0** | 10.0.0 |
| `Serilog.Sinks.Console` | 6.1.1 | **6.1.1** | 6.1.1 |
| `Serilog.Sinks.File` | 7.0.0 | **7.0.0** | 7.0.0 |
| `Microsoft.IdentityModel.JsonWebTokens` | 8.22.0 | **8.22.0** | 8.22.0 |
| `Scrutor` | 7.0.0 | **7.0.0** | 7.0.0 |

---

### Bloco D — Utilitários, Relatórios e Integrações

| Pacote | Versão Anterior | Versão Aplicada | Latest NuGet | Observações |
| ------ | --------------- | --------------- | ------------ | ----------- |
| `AutoMapper` | 16.2.0 | **16.2.0** | 16.2.0 | Estável |
| `FluentValidation` | 12.1.1 | **12.1.1** | 12.1.1 | Estável |
| `FluentValidation.DependencyInjectionExtensions` | 12.1.1 | **12.1.1** | 12.1.1 | Estável |
| `Newtonsoft.Json` | 13.0.4 | **13.0.4** | 13.0.4 | Estável |
| `Polly` / `Polly.Core` | 8.7.0 | **8.7.0** | 8.7.0 | Estável |
| `Bogus` | 35.6.5 | **35.6.5** | 35.6.5 | Estável |
| `HtmlSanitizer` | 9.1.982 | **9.1.982** | 9.2.995 | Estável com AngleSharp 1.7.0 |
| `AngleSharp` | 1.7.0 | **1.7.0** | 1.7.0 | Override de segurança |
| `AngleSharp.Css` | 1.0.1 | **1.0.1** | 1.0.1 | Estável |
| `DocumentFormat.OpenXml` | 3.5.1 | **3.5.1** | 3.5.1 | Estável |
| `DocumentFormat.OpenXml.Framework` | 3.5.1 | **3.5.1** | 3.5.1 | Estável |
| `PDFsharp` / `PDFsharp-MigraDoc` | 6.2.4 | **6.2.4** | 6.2.4 | Estável |
| `QuestPDF` | 2026.7.2 | **2026.7.2** | 2026.7.2 | Estável |
| `Microsoft.VisualStudio.Azure.Containers.Tools.Targets` | 1.23.0 | **1.23.0** | 1.23.0 | Estável |
| `Microsoft.Azure.WebJobs` / `Core` | 3.0.47 | **3.0.47** | 3.0.47 | Estável |
| `Microsoft.Azure.WebJobs.Extensions` | 5.2.1 | **5.2.1** | 5.2.1 | Estável |
| `Azure.Identity` | 1.21.0 | **1.21.0** | 1.21.0 | Estável |
| `Azure.Monitor.OpenTelemetry.AspNetCore` | 1.6.0 | **1.6.0** | 1.6.0 | Estável |
| `Azure.Storage.Blobs` | 12.29.1 | **12.29.1** | 12.29.1 | Estável |
| `Azure.Storage.Queues` | 12.27.1 | **12.27.1** | 12.27.1 | Estável |
| `Azure.Data.Tables` | 12.11.0 | **12.11.0** | 12.11.0 | Estável |

---

### Bloco E — Testes (NUnit 4 + Ecossistema)

| Pacote | Versão Anterior | Versão Aplicada | Latest NuGet | Justificativa se != latest |
| ------ | --------------- | --------------- | ------------ | -------------------------- |
| `Microsoft.NET.Test.Sdk` | 18.8.1 | **18.8.1** | 18.9.0 | Estável com VSTest / NUnit |
| `NUnit` | 4.6.1 | **4.6.1** | 4.6.1 | Estável |
| `NUnit3TestAdapter` | 6.2.0 | **6.2.0** | 6.2.0 | Estável |
| `NUnit.Analyzers` | 4.14.0 | **4.14.0** | 4.14.0 | Estável |
| `Moq` | 4.20.72 | **4.20.72** | 4.20.72 | Estável |
| `Moq.EntityFrameworkCore` | 9.0.0.10 | **9.0.0.10** | 10.0.0.2 | **Pin deliberado** — segue EF Core 9 (Bloco B) |
| `AwesomeAssertions` | 9.5.0 | **9.5.0** | 9.6.0 | Estável |
| `coverlet.collector` | 10.0.1 | **10.0.1** | 10.0.1 | Estável |
| `coverlet.msbuild` | 10.0.1 | **10.0.1** | 10.0.1 | Estável |
| `System.IdentityModel.Tokens.Jwt` | 8.22.0 | **8.22.0** | 8.22.0 | Estável |

---

## 2. Validações Executadas

```text
backend:
  dotnet restore SmartDigitalPsicoAPI.sln    -> 0 erros / 0 conflitos
  dotnet build SmartDigitalPsicoAPI.sln -c Release -> 0 erros

  dotnet test SmartDigitalPsicoAPI.sln -c Release  -> 1.344 aprovados / 0 falhas:
    - SmartDigitalPsico.Domain.Test:            569 aprovados (0 falhas)
    - SmartDigitalPsico.Service.Test:           448 aprovados (0 falhas)
    - SmartDigitalPsico.Core.SDK.Tests:         141 aprovados (0 falhas)
    - SmartDigitalPsico.Data.Test:              126 aprovados (0 falhas)
    - SmartDigitalPsico.WebAPI.Test:             27 aprovados (0 falhas)
    - SmartDigitalPsico.WebJob.Test:             18 aprovados (0 falhas)
    - SmartDigitalPsico.WindowsService.Test:     15 aprovados (0 falhas)
  Total: 1.344 aprovados (100% de sucesso)
```

---

## 3. Riscos Residuais / Próximo Ciclo

1. **EF Core 10 (Conjunto v2):** destravar quando `Pomelo.EntityFrameworkCore.MySql` 10.x oficial publicar no nuget.org; subir junto com `Moq.EntityFrameworkCore 10.x`.
2. **Padrão de Testes NUnit vs Microsoft Testing Platform (MTP):** Manter a suíte consolidada em NUnit 4 + VSTest runner conforme documentado em [Analise-xUnit-v4-MicrosoftTestingPlatform.md](file:///c:/git/SMARTDIGITALPSICO/SmartDigitalPsicoAPI/DOCUMENTACAO/UpdatePackages/Analise-xUnit-v4-MicrosoftTestingPlatform.md).
3. **Evolução do Host WebJob:** Avaliar migração futura de `SmartDigitalPsico.WebJob` para Azure Functions Worker Isolated ou BackgroundService hospedado em contêiner.
