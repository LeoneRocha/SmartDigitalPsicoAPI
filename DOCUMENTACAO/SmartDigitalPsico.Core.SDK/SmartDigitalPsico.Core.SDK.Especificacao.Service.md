# SmartDigitalPsico.Core.SDK — Especificação Técnica: Service e Infrastructure

Especificação técnica das camadas **Service** e **Infrastructure** do pacote `SmartDigitalPsico.Core.SDK` (`SmartDigitalPsico.Core.SDK.Service` e `SmartDigitalPsico.Core.SDK.Infrastructure`).

---

## 1. Visão Geral

As camadas de Service e Infrastructure do SDK fornecem:
1. Uma implementação base de serviço CRUD (`EntityBaseService<TEntity, TResult>`) totalmente integrada ao repositório genérico e ao AutoMapper.
2. Adaptadores de integração com serviços em nuvem (Azure Blob, Queue, Table), envio de e-mails (SMTP) e orquestração de cache.
3. Métodos de extensão de injeção de dependência (`IServiceCollection`) para inicialização limpa e padronizada das aplicações host (`WebAPI`, `WebJob`, `WindowsService`).
4. Abstrações transversais de logging estruturado (Serilog) e mapeamento de objetos (AutoMapper).

---

## 2. Estrutura de Pastas

```text
SmartDigitalPsico.Core.SDK/
├── Infrastructure/
│   ├── Logging/
│   │   ├── AppLoggerServiceCollectionExtensions.cs
│   │   └── SerilogAppLoggerAdapter.cs
│   └── Mapping/
│       ├── AppMapperServiceCollectionExtensions.cs
│       └── AutoMapperAppMapperAdapter.cs
└── Service/
    ├── Configure/
    │   ├── ApiExplorer/
    │   ├── AppSettings/
    │   ├── Caching/
    │   ├── Cors/
    │   ├── Documentation/
    │   ├── Localization/
    │   ├── Logging/
    │   ├── Mapping/
    │   ├── Mvc/
    │   ├── Queue/
    │   ├── Report/
    │   ├── Repository/
    │   ├── Security/
    │   └── Smtp/
    ├── DataEntity/Generic/
    │   └── EntityBaseService.cs
    └── Infrastructure/
        ├── Azure/Storage/
        ├── CacheManager/
        ├── Notification/
        ├── Report/
        └── Smtp/
```

---

## 3. Especificação dos Componentes

### 3.1 Serviço Genérico Base (`Service/DataEntity/Generic`)

#### `EntityBaseService<TEntity, TResult>`
Classe abstrata genérica que implementa `IEntityBaseService<TEntity, TResult>`, fornecendo o fluxo padrão de CRUD com mapeamento entre entidades e VOs/DTOs, validações e respostas padronizadas `ServiceResponse<TResult>`.

```csharp
namespace SmartDigitalPsico.Core.SDK.Service.DataEntity.Generic
{
    public abstract class EntityBaseService<TEntity, TResult> : IEntityBaseService<TEntity, TResult>
        where TEntity : EntityBase
        where TResult : class
    {
        protected readonly IEntityBaseRepository<TEntity> _entityRepository;
        protected readonly IMapper _mapper;

        public virtual async Task<ServiceResponse<TResult>> Create(TResult item);
        public virtual async Task<ServiceResponse<TResult>> Update(TResult item);
        public virtual async Task<ServiceResponse<bool>> Delete(long id);
        public virtual async Task<ServiceResponse<TResult>> FindByID(long id);
        public virtual async Task<ServiceResponse<List<TResult>>> FindAll();
        public virtual async Task<ServiceResponse<PagedSearchVO<TResult>>> FindWithPagedSearch(
            string sortFields, string sortDirections, int pageSize, int page);
    }
}
```

---

### 3.2 Infraestrutura e Serviços Integrados (`Service/Infrastructure`)

#### 1. Azure Storage:
- **`AzureStorageBlobAdapter` (`IStorageBlobAdapter`):** Upload, download, exclusão e geração de SAS tokens para blobs.
- **`AzureStorageQueueAdapter` (`IStorageQueueAdapter`):** Enfileiramento, leitura, polling e exclusão de mensagens.
- **`AzureStorageTableAdapter`:** Persistência NoSQL de entidades tabulares.

#### 2. E-mail e Notificações:
- **`EmailService` (`IEmailService`):** Orquestrador de envio de e-mails com suporte a templates HTML.
- **`EmailContext` / `EmailStrategyFactory`:** Padrão Strategy para seleção dinâmica do provedor de envio:
  - `SmtpEmailStrategy`: Envio via servidor SMTP configurado.
  - `ThirdPartyEmailStrategy`: Envio via provedores terceirizados (SendGrid, Mailgun, etc.).

#### 3. Gerenciamento de Cache:
- **`CacheService` (`ICacheService`):** Orquestrador de cache híbrido (avalia cache em memória e fallback para cache em disco).

#### 4. Relatórios:
- **`ExcelGeneratorFactory` / `PdfReportAdapterFactory`:** Fábricas para resolução de adaptadores de relatórios em tempo de execução.

---

### 3.3 Abstrações de Logging e Mapeamento (`Infrastructure`)

- **`IAppLogger` / `SerilogAppLoggerAdapter`:** Encapsula operações de log estruturado (`LogInformation`, `LogWarning`, `LogError`, `LogCritical`), garantindo desacoplamento do Serilog.
- **`IAppMapper` / `AutoMapperAppMapperAdapter`:** Encapsula métodos `Map<TSource, TDestination>`, facilitando mocks e testes unitários.

---

### 3.4 Métodos de Extensão de Configuração (`Service/Configure`)

As aplicações host inicializam os serviços centrais com chamadas expressivas no `Program.cs`:

| Extensão | Namespace | Finalidade |
| -------- | --------- | ---------- |
| `AddCoreAppSettings` | `Service.Configure.AppSettings` | Mapeia seções do `appsettings.json` para DTOs tipados. |
| `AddCoreSwagger` | `Service.Configure.Documentation` | Configura documentação interativa Swagger/OpenAPI com JWT. |
| `AddCoreJwtBearer` | `Service.Configure.Security` | Configura autenticação Bearer JWT e validação de tokens. |
| `AddCoreCors` | `Service.Configure.Cors` | Registra políticas de CORS customizáveis. |
| `AddCoreCaching` | `Service.Configure.Caching` | Registra `IMemoryCache`, `MemoryCacheRepository` e `DiskCacheRepository`. |
| `AddCoreSmtp` | `Service.Configure.Smtp` | Registra os serviços e estratégias de SMTP. |
| `AddCoreReportInfrastructure` | `Service.Configure.Report` | Registra os adaptadores de Excel e PDF. |
| `AddCoreLocalization` | `Service.Configure.Localization` | Registra opções de internacionalização e recursos. |
| `AddCoreLogging` | `Service.Configure.Logging` | Registra os adaptadores de log estruturado. |
| `AddCoreMapping` | `Service.Configure.Mapping` | Registra e inicializa perfis do AutoMapper. |

---

## 4. Relações com Outros Documentos

- [Levantamento Técnico](./SmartDigitalPsico.Core.SDK.Levantamento.md)
- [Especificação - API](./SmartDigitalPsico.Core.SDK.Especificacao.API.md)
- [Especificação - Data](./SmartDigitalPsico.Core.SDK.Especificacao.Data.md)
- [Especificação - Domain](./SmartDigitalPsico.Core.SDK.Especificacao.Domain.md)
- [Plano de Implementação - Service](./SmartDigitalPsico.Core.SDK.PlanoImplementacao.Service.md)
