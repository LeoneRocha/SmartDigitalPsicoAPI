# SmartDigitalPsico.Core.SDK

Biblioteca central de primitivas, contratos e implementações genéricas reutilizáveis do backend **SmartDigitalPsico**.

| Propriedade | Valor |
| ----------- | ----- |
| **PackageId** | `SmartDigitalPsico.Core.SDK` |
| **Target Framework** | `net10.0` |
| **Solução** | `SmartDigitalPsicoAPI.sln` |
| **Testes** | `SmartDigitalPsico.Core.SDK.Tests` (NUnit 4) |

## Objetivo

Centralizar código genérico compartilhado entre `SmartDigitalPsico.Domain`, `SmartDigitalPsico.Data`, `SmartDigitalPsico.Service` e `SmartDigitalPsico.WebAPI`, evitando duplicação e oferecendo contratos estáveis.

## Estrutura de pastas

```text
SmartDigitalPsico.Core.SDK/
├── API/                    # ApiBaseController, filtros ASP.NET
├── Data/
│   ├── Context/            # Configurações EF genéricas (EntityBaseConfiguration)
│   ├── Repository/         # GenericRepository, cache em disco/memória
│   └── TableEntityRepository/
├── Domain/
│   ├── Contracts/          # EntityBase, contratos de entidade
│   ├── DTO/                # DTOs genéricos (auth, security, SMTP, report)
│   ├── Enuns/              # Enumeradores compartilhados
│   ├── Helpers/            # Utilitários (arquivo, cultura, diretório, segurança)
│   ├── Hypermedia/         # Enriquecimento de respostas REST
│   ├── Interfaces/         # Contratos (repositório, serviço, logging, mapping)
│   ├── Report/             # Adapters PDF (QuestPDF, PDFsharp) e Excel (OpenXML)
│   ├── Resiliency/         # Políticas Polly
│   ├── Security/           # Crypto, tokens JWT
│   ├── TableEntityNoSQL/   # Entidades Azure Table Storage
│   ├── Validation/         # HelperValidation, códigos de erro
│   └── VO/                 # ServiceResponse, ErrorResponse
├── Infrastructure/
│   ├── Logging/            # SerilogAppLoggerAdapter, IAppLogger
│   └── Mapping/            # AutoMapperAppMapperAdapter, IAppMapper
└── Service/
    ├── Configure/          # Extensions DI (Swagger, JWT, CORS, cache, SMTP, etc.)
    ├── DataEntity/Generic/ # EntityBaseService<T>
    └── Infrastructure/     # Azure Storage, SMTP, cache, relatórios, e-mail
```

## Consumidores

| Projeto | Referência |
| ------- | ---------- |
| `SmartDigitalPsico.Domain` | `ProjectReference` |
| `SmartDigitalPsico.Data` | via Domain |
| `SmartDigitalPsico.Service` | via Domain |
| `SmartDigitalPsico.WebAPI` | via Service |
| `SmartDigitalPsico.WebJob` | via Service |
| `SmartDigitalPsico.WindowsService` | via Service |

## Principais tipos públicos

| Área | Tipos |
| ---- | ----- |
| Entidade base | `EntityBase`, `IEntityBase`, `IEntityBaseLog` |
| Resposta de serviço | `ServiceResponse<T>`, `ErrorResponse` |
| Repositório | `IEntityBaseRepository<T>`, `GenericRepository<T>` |
| Serviço genérico | `IEntityBaseService<TEntity, TResult>`, `EntityBaseService<,>` |
| API | `ApiBaseController` |
| Logging | `IAppLogger`, `SerilogAppLoggerAdapter` |
| Mapping | `IAppMapper`, `AutoMapperAppMapperAdapter` |
| Segurança | `TokenService`, `CryptoService`, adapters AES/RSA |
| Cache | `ICacheService`, `CacheService`, repositórios Memory/Disk |
| Azure | `AzureStorageBlobAdapter`, `AzureStorageQueueAdapter`, `AzureStorageTableAdapter` |
| Relatórios | `QuestPDFReportAdapter`, `PDFsharpMigraDocReportAdapter`, `ExcelGeneratorOpenXmlAdapter` |
| Resiliência | `ResiliencePolicies`, `ResiliencePolicyConfig` |

## Registro no DI

O host (`SmartDigitalPsico.WebAPI`, `WebJob`, etc.) registra extensões do namespace `SmartDigitalPsico.Core.SDK.Service.Configure.*`, por exemplo:

- `AddCoreAppSettings`
- `AddCoreJwtBearer`
- `AddCoreSwagger`
- `AddCoreCaching`
- `AddCoreSmtp`
- `AddCoreReportInfrastructure`

Consulte `SmartDigitalPsico.Core.SDK.Tests/Service/Configure/CoreConfigureServiceCollectionTests.cs` para a lista completa.

## Build e testes

```powershell
cd c:\git\SMARTDIGITALPSICO\SmartDigitalPsicoAPI

dotnet build SmartDigitalPsico.Core.SDK\SmartDigitalPsico.Core.SDK.csproj -c Release
dotnet test SmartDigitalPsico.Core.SDK.Tests\SmartDigitalPsico.Core.SDK.Tests.csproj -c Release
```

## Documentação

Documentação detalhada em [`DOCUMENTACAO/SmartDigitalPsico.Core.SDK/`](../DOCUMENTACAO/SmartDigitalPsico.Core.SDK/README.md).

Os documentos de migração (`Substituicao`, `MigracaoGenericos`, `Remocao-Shims`, etc.) descrevem o histórico de extração/adaptação a partir do template SmartCoreHub e servem como referência arquitetural.
