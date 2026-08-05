# Levantamento — SmartDigitalPsicoAPI.Core.SDK

**Versão:** 1.1  
**Data:** 2026-08-04  
**Status:** Inventário completo — relocação de código não iniciada  
**PackageId alvo:** `SmartDigitalPsicoAPI.Core.SDK` (único NuGet)  
**TFM do host:** `net10.0`  
**Escopo analisado:** `SmartDigitalPsico.Domain`, `SmartDigitalPsico.Data`, `SmartDigitalPsico.Service`, `SmartDigitalPsico.WebAPI` (+ projetos de teste dos tipos movidos)

Paths relativos à raiz `SmartDigitalPsicoAPI/`.

---

## 0. Objetivo e regras

Centralizar **implementações genéricas e reutilizáveis** no pacote `SmartDigitalPsicoAPI.Core.SDK` por **relocação física** de arquivos já existentes em Domain, Data, Service e WebAPI. Manter no host tudo que for específico de domínio clínico/produto.

| Situação | Significado |
| -------- | ----------- |
| **Mover** | Relocar o `.cs` existente (e o teste correspondente) para o Core.SDK / Core.SDK.Tests |
| **Manter** | Tipo específico do produto → permanece em Domain/Data/Service/WebAPI |
| **Não mover** | Ausente neste repo — **não criar** equivalente |

### Regras não negociáveis

- **Só mover, não criar:** nenhum tipo, interface, helper, provider ou fachada nova. Proibido inventar `Guard`, `Result`, Dapper, UoW, contratos de contexto novos, hooks/callbacks ou “generalizar” constantes.
- **Único criar permitido:** shell vazio `SmartDigitalPsicoAPI.Core.SDK.csproj` + `SmartDigitalPsicoAPI.Core.SDK.Tests.csproj` + entrada na solution (container do pacote).
- **Ajustes permitidos ao mover:** namespaces, `ProjectReference`, usings, registro DI — sem mudar comportamento observável.
- Um único NuGet: `SmartDigitalPsicoAPI.Core.SDK`
- Centralizar o genérico; manter o específico (DbContext tipado, entidades, migrations, validators de negócio, enrichers de domínio, `EntityBaseService` / `ReportBaseService`)
- Zero regressão funcional (APIs e contratos idênticos)
- **Testes:** mover (não duplicar) os testes dos tipos movidos para `SmartDigitalPsicoAPI.Core.SDK.Tests`; remover do projeto de origem após o move

### Referência histórica

Docs em `DOCUMENTACAO/SmartCoreHub.Core.SDK/` descrevem um produto irmão. Os **tipos reais** deste solution têm nomes diferentes (ver §1). Tipos inexistentes aqui **não** são criados.

### Dependência EF ao mover `GenericRepositoryEntityBase`

Hoje o construtor recebe `IEntityDataContext` (interface no Data com todos os `DbSet` de domínio). A implementação genérica usa apenas `Set<T>` / save via EF.

- **Não** criar interface mínima nova no SDK
- Ao **mover** o arquivo, retarget do parâmetro para `Microsoft.EntityFrameworkCore.DbContext` (tipo **já existente** no EF Core)
- `IEntityDataContext` + DbContext concreto + migrations = **Manter** no Data
- Repos de domínio continuam recebendo a implementação existente do host (compatível com `DbContext`)

---

## 1. Mapa de equivalência (SmartCoreHub → SmartDigitalPsico)

| Nome no prompt / SmartCoreHub | Equivalente neste repo | Situação |
| ----------------------------- | ---------------------- | -------- |
| `GenericRepository<T>` | `GenericRepositoryEntityBase<T>` | Mover |
| `IGenericRepository<T>` | `IEntityBaseRepository<T>` | Mover |
| `DapperGenericRepository` / `DapperAdpterGenericRepository` | *(inexistente)* | Não mover |
| `RepositoryImplementationFactory` | *(inexistente)* | Não mover |
| `IUnitOfWork` / `UnitOfWork` | *(inexistente)* | Não mover |
| `MemoryCacheProvider` | `MemoryCacheRepository` | Mover |
| `DiskCacheProvider` | `DiskCacheRepository` | Mover |
| `RedisCacheProvider` | Stub dentro de `CacheService` (arquivo inteiro se move) | Não mover tipo à parte |
| `MongoPersistenceAdapter` / cache Mongo | Stub dentro de `CacheService` | Não mover tipo à parte |
| `AzureBlobStorageAdapter` | `AzureStorageBlobAdapter` | Mover |
| `AzureTableStorageAdapter` | `AzureStorageTableAdapter<T>` | Mover |
| `AzureQueueStorageAdapter` | `AzureStorageQueueAdapter` | Mover |
| `Guard` | *(inexistente)* | Não mover |
| `Result<T>` | `ServiceResponse<T>` | Mover |
| `ErrorCodes` | `ValidationErrorCodes` | Mover (como está) |
| `DateTimeHelper` | `DateHelper` / `CultureDateTimeHelper` | Mover |
| `StringHelper` | *(inexistente)* | Não mover |
| `GenericService<T>` | `EntityBaseService` / `ReportBaseService` | Manter no host |

---

## 2. Repositórios genéricos

### 2.1 Mover

| Nome | Namespace | Arquivo | Dependências | Situação | Testes relacionados |
| ---- | --------- | ------- | ------------ | -------- | ------------------- |
| `IEntityBaseRepository<T>` | `SmartDigitalPsico.Domain.Interfaces.Repository` | `SmartDigitalPsico.Domain/Interfaces/Repository/IEntityBaseRepository.cs` | `IEntityBase`, `System.Linq.Expressions` | Mover | Mocks em Domain.Test / Service.Test |
| `GenericRepositoryEntityBase<T>` | `SmartDigitalPsico.Data.Repository.Generic` | `SmartDigitalPsico.Data/Repository/Generic/GenericRepositoryEntityBase.cs` | EF `DbContext`/`DbSet<T>`, `DateHelper`, `EntityBase` (retarget: ver §0) | Mover | `ScheduleAndGenericRepositoryCoverageTests`, `GenderAndGenericRepositoryTests`, `RemainingDataCoverageTests` |
| `IStorageTableContract<T>` | `SmartDigitalPsico.Domain.Interfaces.TableEntity` | `SmartDigitalPsico.Domain/Interfaces/TableEntity/IStorageTableContract.cs` | `BaseEntityTable` | Mover | `GenericTableEntityRepositoryTests` |
| `GenericTableEntityRepository<T>` | `SmartDigitalPsico.Data.TableEntityRepository` | `SmartDigitalPsico.Data/TableEntityRepository/GenericTableEntityRepository.cs` | `IStorageTableContract<T>` | Mover | `GenericTableEntityRepositoryTests` |
| `IStorageTableRepositoryFactory` | `SmartDigitalPsico.Domain.Interfaces.Infrastructure` | `SmartDigitalPsico.Domain/Interfaces/Infrastructure/IStorageTableRepositoryFactory.cs` | `EStorageAdapterType` | Mover | `InfrastructureFactoryTests` |
| `StorageTableRepositoryFactory` | `SmartDigitalPsico.Service.Infrastructure` | `SmartDigitalPsico.Service/Infrastructure/StorageTableRepositoryFactory.cs` | `IConfiguration`, `AzureStorageTableAdapter<T>`, `GenericTableEntityRepository<T>` | Mover | `InfrastructureFactoryTests`, `StorageTableEntityServiceTests` |
| `StorageTableEntityService<T>` | `SmartDigitalPsico.Service.Infrastructure` | `SmartDigitalPsico.Service/Infrastructure/StorageTableEntityService.cs` | `IStorageTableRepositoryFactory` | Mover | `StorageTableEntityServiceTests` |
| `IStorageQueueContract` | `SmartDigitalPsico.Domain.Interfaces.Infrastructure` | `SmartDigitalPsico.Domain/Interfaces/Infrastructure/IStorageQueueAdapter.cs` | — | Mover | `RemainingDataCoverageTests` |
| `GenericStorageQueueRepository` | `SmartDigitalPsico.Data.Repository.Infrastructure` | `SmartDigitalPsico.Data/Repository/Infrastructure/GenericStorageQueueRepository.cs` | `IStorageQueueContract` | Mover | `RemainingDataCoverageTests` |
| `IStorageQueueRepositoryFactory` | `SmartDigitalPsico.Domain.Interfaces.Infrastructure` | `SmartDigitalPsico.Domain/Interfaces/Infrastructure/IStorageQueueRepositoryFactory.cs` | `EStorageAdapterType` | Mover | `InfrastructureFactoryTests` |
| `StorageQueueRepositoryFactory` | `SmartDigitalPsico.Domain.Interfaces.Infrastructure` *(ns ≠ pasta)* | `SmartDigitalPsico.Service/Infrastructure/StorageQueueRepositoryFactory.cs` | `IConfiguration`, `AzureStorageQueueAdapter`, `GenericStorageQueueRepository` | Mover | `InfrastructureFactoryTests` |
| `StorageQueueService` | `SmartDigitalPsico.Service.Infrastructure` | `SmartDigitalPsico.Service/Infrastructure/StorageQueueService.cs` | `IStorageQueueRepositoryFactory` | Mover | `InfrastructureMethodCoverageGapTests` |
| `EStorageAdapterType` | `SmartDigitalPsico.Domain.Enuns` | `SmartDigitalPsico.Domain/Enuns/EStorageAdapterType.cs` | Azure/AWS/Google (AWS/Google não implementados) | Mover | — |
| `BaseEntityTable` | `SmartDigitalPsico.Domain.TableEntityNoSQL` | `SmartDigitalPsico.Domain/TableEntityNoSQL/BaseEntityTable.cs` | `Azure.Data.Tables` (`ITableEntity`) | Mover | — |
| `IFileDiskRepository` | `SmartDigitalPsico.Domain.Interfaces.Repository` | `SmartDigitalPsico.Domain/Interfaces/Repository/IFileDiskRepository.cs` | `FileData` | Mover | `FileAndDiskCacheRepositoryTests` |
| `FileDiskRepository` | `SmartDigitalPsico.Data.Repository.FileManager` | `SmartDigitalPsico.Data/Repository/FileManager/FileDiskRepository.cs` | filesystem | Mover | `FileAndDiskCacheRepositoryTests`, `FileDiskRepositoryIncompleteReadTests` |

### 2.2 Manter (repositórios de domínio)

Herdam `GenericRepositoryEntityBase<T>` — **não** vão para o SDK.

**Principals** (`SmartDigitalPsico.Data.Repository.Principals`):  
`UserRepository`, `PatientRepository`, `PatientRecordRepository`, `PatientNotificationMessageRepository`, `PatientMedicationInformationRepository`, `PatientHospitalizationInformationRepository`, `PatientFileRepository`, `PatientAdditionalInformationRepository`, `MedicalRepository`, `MedicalFileRepository`, `MedicalSettingsRepository`

**SystemDomains** (`SmartDigitalPsico.Data.Repository.SystemDomains`):  
`UserTokenSessionRepository`, `SpecialtyRepository`, `RoleGroupRepository`, `OfficeRepository`, `NotificationTemplateRepository`, `NotificationRulesRepository`, `NotificationRecordsRepository`, `LeavesRepository`, `GenderRepository`, `AuditDataSelectiveEntityLogRepository`, `ApplicationLanguageRepository`, `ApplicationConfigSettingRepository`, `ApplicationCacheLogRepository`

**Schedule:** `ScheduleCalendarRepository`

**Contexto EF (manter):** `IEntityDataContext`, DbContext concreto, migrations, configs EF de entidades.

---

## 3. Providers / repositórios de cache

### 3.1 Mover

| Nome | Namespace | Arquivo | Dependências | Situação | Testes relacionados |
| ---- | --------- | ------- | ------------ | -------- | ------------------- |
| `ICacheRepository` | `SmartDigitalPsico.Domain.Interfaces.Repository` | `.../ICacheRepository.cs` | — | Mover | `CacheServiceTests`, `MemoryCacheRepositoryTests` |
| `IMemoryCacheRepository` | idem | `.../IMemoryCacheRepository.cs` | `Microsoft.Extensions.Caching.Memory` | Mover | `MemoryCacheRepositoryTests` |
| `IDiskCacheRepository` | idem | `.../IDiskCacheRepository.cs` | — | Mover | `FileAndDiskCacheRepositoryTests` |
| `ICacheService` | `SmartDigitalPsico.Domain.Interfaces.Service` | `.../ICacheService.cs` | — | Mover | `CacheServiceTests` |
| `IDataCacheDto<T>` | `SmartDigitalPsico.Domain.Interfaces` | `.../IDataCacheDto.cs` | — | Mover | — |
| `ETypeLocationCache` | `SmartDigitalPsico.Domain.Enuns` | `.../ETypeLocationCache.cs` | Disk/Memory/MongoDB/AzureStorage/CosmoDB/AzureRedis | Mover | — |
| `CacheConfigurationDto` | `SmartDigitalPsico.Domain.DTO.Domains` | `.../CacheConfigurationDto.cs` | `ETypeLocationCache` | Mover | — |
| `MemoryCacheRepository` | `SmartDigitalPsico.Data.Repository.CacheManager` | `.../MemoryCacheRepository.cs` | `IMemoryCache`, `IOptions<CacheConfigurationDto>`, `DateHelper` | Mover | `MemoryCacheRepositoryTests` |
| `DiskCacheRepository` | idem | `.../DiskCacheRepository.cs` | `IFileDiskRepository`, JSON, `DirectoryHelper`, `DateHelper` | Mover | `FileAndDiskCacheRepositoryTests` |
| `ServiceResponseCacheVO<T>` | `SmartDigitalPsico.Domain.VO` | `.../ServiceResponseCacheVO.cs` | `ServiceResponse`, `IDataCacheDto` | Mover | — |
| `CacheService` | `SmartDigitalPsico.Service.Infrastructure.CacheManager` | `.../CacheService.cs` | Memory/Disk repos, config, `IApplicationCacheLogRepository` (deps tipadas existentes) | Mover (arquivo inteiro, stubs inclusos) | `CacheServiceTests`, `InfrastructureMethodCoverageGapTests` |

### 3.2 Manter

| Nome | Situação | Motivo |
| ---- | -------- | ------ |
| `ApplicationCacheLog` + `ApplicationCacheLogRepository` | Manter | Auditoria específica do produto |
| `IApplicationCacheLogRepository` | Manter | Contrato de domínio; `CacheService` movido continua dependendo dele sem redesenho |

Não criar providers Redis/Mongo/Cosmos separados. Os ramos stub seguem dentro do `CacheService` movido como estão hoje.

---

## 4. Adapters (cloud / NoSQL / arquivo)

### 4.1 Mover

| Nome | Namespace | Arquivo | Dependências | Situação | Testes relacionados |
| ---- | --------- | ------- | ------------ | -------- | ------------------- |
| `IStorageBlobAdapter` | `SmartDigitalPsico.Domain.Interfaces.Infrastructure` | `.../IStorageBlobAdapter.cs` | `BlobFileDto` | Mover | `AzureStorageAdaptersCoverageTests` |
| `AzureStorageBlobAdapter` | `SmartDigitalPsico.Service.Infrastructure.Azure.Storage` | `.../AzureStorageBlobAdapter.cs` | `Azure.Storage.Blobs`, `IConfiguration` | Mover | `AzureStorageAdaptersCoverageTests` |
| `AzureStorageTableAdapter<T>` | idem | `.../AzureStorageTableAdapter.cs` | `Azure.Data.Tables` | Mover | `AzureStorageAdaptersCoverageTests` |
| `AzureStorageQueueAdapter` | idem | `.../AzureStorageQueueAdapter.cs` | `Azure.Storage.Queues` | Mover | `AzureStorageAdaptersCoverageTests` |
| `BlobFileDto` | `SmartDigitalPsico.Domain.Security` *(ns)* | `SmartDigitalPsico.Domain/DTO/BlobFileDto.cs` | Azure headers | Mover | — |
| `LocationSaveFileConfigurationDto` | `SmartDigitalPsico.Domain.DTO.Domains` | `.../LocationSaveFileConfigurationDto.cs` | — | Mover | — |

### 4.2 Manter

| Nome | Situação | Motivo |
| ---- | -------- | ------ |
| `PatientRecordTableEntity` | Manter | Entidade NoSQL de domínio |
| `UserTokenSessionTableEntity` | Manter | Entidade NoSQL de domínio |
| `TableStorageTokenSessionAdapter` | Manter | Persistência de sessão do produto |
| `DatabaseTokenSessionAdapter` | Manter | Persistência de sessão do produto |
| `FileManager` / `IFileManager` | Manter | Orquestra disk + blob + entidades de arquivo de domínio |
| `MedicalScheduleNotificationAdapter` | Manter | Negócio de agenda |

### 4.3 Não mover

| Nome | Situação | Motivo |
| ---- | -------- | ------ |
| `MongoPersistenceAdapter` | Não mover | Inexistente — não criar |
| Adapters AWS / Google Storage | Não mover | Só enum/branches; factories lançam / não implementam — não criar |

---

## 5. Crypto e report engines

### 5.1 Mover

| Nome | Namespace | Arquivo | Dependências | Situação | Testes relacionados |
| ---- | --------- | ------- | ------------ | -------- | ------------------- |
| `ICryptoAdpter` | `SmartDigitalPsico.Domain.Interfaces.Security` | `.../ICryptoAdpter.cs` | — | Mover | `CryptoAndTokenTests` |
| `ICryptoAdapterFactory` | idem | `.../ICryptoAdapterFactory.cs` | — | Mover | `CryptoAndTokenTests` |
| `ICryptoService` | idem | `.../ICryptoService.cs` | — | Mover | `ConfigurationAndCryptoServiceTests` |
| `AesCryptoAdpter` | `SmartDigitalPsico.Domain.Security` | `.../AesCryptoAdpter.cs` | Cryptography | Mover | `CryptoAndTokenTests` |
| `RsaCryptoAdpter` | idem | `.../RsaCryptoAdpter.cs` | Cryptography | Mover | `CryptoAndTokenTests` |
| `CryptoAdapterFactory` | idem | `.../CryptoAdapterFactory.cs` | Adapters | Mover | `CryptoAndTokenTests` |
| `TokenConfigurationDto` / `ITokenConfigurationDto` | Domain DTO/Interfaces | `DTO/Security/`, `Interfaces/Security/` | — | Mover | — |
| `RsaCryptoDto` | `SmartDigitalPsico.Domain.DTO.Security` | `.../RsaCryptoDto.cs` | — | Mover | — |
| `ExcelGeneratorOpenXmlAdapter` | `SmartDigitalPsico.Domain.Report` | `.../ExcelGeneratorOpenXmlAdapter.cs` | OpenXML | Mover | Domain.Test Report adapters |
| `ExcelGeneratorFactory` | `SmartDigitalPsico.Service.Infrastructure.Report` | `.../ExcelGeneratorFactory.cs` | Adapter | Mover | — |
| `PdfReportAdapterFactory` | idem | `.../PdfReportAdapterFactory.cs` | PDF adapters | Mover | — |
| `PDFsharpMigraDocReportAdapter` | `SmartDigitalPsico.Domain.Report` | `.../PDFsharpMigraDocReportAdapter.cs` | PDFsharp/MigraDoc | Mover | Domain.Test Report |
| `QuestPdfReportAdapter` | `SmartDigitalPsico.Domain.Report` | `.../QuestPDFReportAdapter.cs` | QuestPDF | Mover | Domain.Test Report |

### 5.2 Manter

| Nome | Situação | Motivo |
| ---- | -------- | ------ |
| `TokenService` | Manter | Auth do produto (JWT claims específicas) |
| `ExcelGeneratorService` / `PdfReportService` | Manter | Orquestração com conteúdo clínico no host |
| Contratos de report com dados clínicos | Manter | DTOs de domínio |

---

## 6. Helpers e utilitários

### 6.1 Mover

| Nome | Namespace | Arquivo | Dependências | Situação | Testes relacionados |
| ---- | --------- | ------- | ------------ | -------- | ------------------- |
| `DateHelper` | `SmartDigitalPsico.Domain.Helpers` | `Helpers/DateHelper.cs` | BCL / Culture | Mover | `GeneralHelpersTests` |
| `CultureDateTimeHelper` | idem | `Helpers/CultureDateTimeHelper.cs` | Cultures/timezones | Mover | `GeneralHelpersTests` |
| `DirectoryHelper` | idem | `Helpers/DirectoryHelper.cs` | IO | Mover | `DirectoryHelperTests` |
| `EmailHelper` | idem | `Helpers/EmailHelper.cs` | — | Mover | `GeneralHelpersTests` |
| `ReflectionHelpers` | idem | `Helpers/ReflectionHelpers.cs` | Reflection | Mover | `GeneralHelpersTests` |
| `OrderAttribute` | idem | `Helpers/OrderAttribute.cs` | — | Mover | — |
| `EnumDescriptionConverter<T>` | idem | `Helpers/EnumDescriptionConverter.cs` | System.Text.Json | Mover | `SerializationHelpersTests` |
| `IgnorableSerializerContractResolver` | idem | `Helpers/IgnorableSerializerContractResolver.cs` | Newtonsoft.Json | Mover | `SerializationHelpersTests` |
| `HtmlSanitizerHelper` | idem | `Helpers/HtmlSanitizerHelper.cs` | `Ganss.Xss` | Mover | `GeneralHelpersTests` |
| `AesKeyGeneratorHelper` | `SmartDigitalPsico.Domain.Helpers.Security` | `Helpers/Security/AesKeyGeneratorHelper.cs` | Cryptography | Mover | `SecurityHelpersTests` |
| `RsaCryptoServiceHelper` | `SmartDigitalPsico.Domain.Helpers` | `Helpers/RsaCryptoServiceHelper.cs` | Cryptography, `RsaCryptoDto` | Mover | `SecurityHelpersTests` |
| `SecurityHelper` | `SmartDigitalPsico.Domain.Helpers.Security` | `Helpers/Security/SecurityHelper.cs` | HMAC / JWT libs | Mover | `SecurityHelpersTests` |
| `ServiceCollectionHelper` | `SmartDigitalPsico.Service.Helpers` *(arquivo em Domain/Helpers)* | `Helpers/ServiceCollectionHelper.cs` | DI + reflection | Mover | `ServiceCollectionHelperTests` |
| `ExceptionHandler` | `SmartDigitalPsico.Domain.AppException` | `AppException/ExceptionHandler.cs` | `ErrorResponse` | Mover | `AppExceptionTests` |
| `AppWarningException` | idem | `AppException/AppWarningException.cs` | — | Mover | `AppExceptionTests` |
| `ValidationErrorCodes` | `SmartDigitalPsico.Domain.Validation` | `Validation/ValidationErrorCodes.cs` | Prefixo `"SmartDigitalPsico"` (inalterado) | Mover | `ValidationHelperTests` |
| `FileHelper` | `SmartDigitalPsico.Domain.Helpers` | `Helpers/FileHelper.cs` | ASP.NET Core Http/Mvc | Mover | `FileHelperTests` |
| `BlobFileHelper` | idem | `Helpers/BlobFileHelper.cs` | Azure + `FileBase` | Mover | — |
| `HelperValidation` | `SmartDigitalPsico.Domain.Validation.Helper` | `Validation/Helper/HelperValidation.cs` | FluentValidation | Mover | `ValidationHelperTests` |
| `RequestCultureMiddleware` | `SmartDigitalPsico.Domain.Helpers` | `Helpers/RequestCultureMiddleware.cs` | ASP.NET | Mover | `RequestCultureMiddlewareTests` |
| `ApiBaseController` | `SmartDigitalPsico.Domain.API` | `API/ApiBaseController.cs` | ASP.NET | Mover | `ApiBaseControllerTests` |

### 6.2 Manter (domínio / produto)

| Nome | Namespace | Situação |
| ---- | --------- | -------- |
| `LogAppHelper` | `SmartDigitalPsico.Domain.Helpers` | Manter (Serilog + host) |
| `AuditLogHelper` | idem | Manter (DTOs de audit de produto) |
| `ConfigurationAppSettingsHelper` | idem | Manter (chaves SDP-específicas) |
| `SecurityHelperApi` | `...Helpers.Security` | Manter (claims/API do produto) |
| `LanguageActionFilterAttribute` | `SmartDigitalPsico.Domain.API` | Manter (i18n do produto) |
| `ApplicationLanguageHelper` | `SmartDigitalPsico.Domain.Helpers` | Manter |
| `MedicalScheduleKeyHelper` | `...Helpers.Medical` | Manter |
| `RecurrenceMaterializer`, `ScheduleConflictDetailHelper`, `ScheduleKeyHelper`, `ScheduleOverlapHelper`, `ScheduleParallel`, `SchedulePeriodHelper`, `TimeSlotGenerator` | `...Helpers.Schedule` | Manter |
| Helpers EF em Data (`ModelBuilderExtensions`, `CollectionValueComparerHelper`, `HelperCharSet`, `ConfigurationEntitiesHelper`) | `SmartDigitalPsico.Data.Context.Configure.Helper` | Manter |
| Validators FluentValidation de entidades/DTOs de negócio | `SmartDigitalPsico.Domain.Validation.*` | Manter |

---

## 7. VOs, DTOs base e contratos de entidade

### 7.1 Mover

| Nome | Namespace | Arquivo | Dependências | Situação | Testes relacionados |
| ---- | --------- | ------- | ------------ | -------- | ------------------- |
| `ServiceResponse<T>` | `SmartDigitalPsico.Domain.VO` | `VO/ServiceResponse.cs` | — | Mover | Usado amplamente nos testes de Service |
| `IServiceResponse<T>` | `SmartDigitalPsico.Domain.Interfaces.VO` | `Interfaces/VO/` | — | Mover | — |
| `ErrorResponse` | `SmartDigitalPsico.Domain.VO` | `VO/ErrorResponse.cs` | — | Mover | `AppExceptionTests` |
| `ServiceResponseCacheVO<T>` | `SmartDigitalPsico.Domain.VO` | `VO/ServiceResponseCacheVO.cs` | Cache VO | Mover | — |
| `PagedSearchVO<T>` | `SmartDigitalPsico.Domain.VO` | `VO/PagedSearchVO.cs` | Hypermedia | Mover | — |
| `EntityBase` | `SmartDigitalPsico.Domain.Contracts` | `Contracts/EntityBase.cs` | — | Mover | — |
| `EntityBaseWithNameEmail` | idem | `Contracts/EntityBaseWithNameEmail.cs` | `EntityBase` | Mover | — |
| `Record<T>` / `RecordsList<T>` | idem | `Contracts/Record.cs`, `RecordsList.cs` | — | Mover | — |
| `EntityDtoBase` | `SmartDigitalPsico.Domain.DTO.Contracts` | `DTO/Contracts/EntityDtoBase.cs` | — | Mover | — |
| `EntityDtoBaseAdd` | idem | `EntityDtoBaseAdd.cs` | — | Mover | — |
| `EntityDtoBaseDomain` | idem | `EntityDtoBaseDomain.cs` | — | Mover | — |
| `EntityDtoBaseDomainAdd` | idem | `EntityDtoBaseDomainAdd.cs` | — | Mover | — |
| `EntityDtoBaseName` | idem | `EntityDtoBaseName.cs` | — | Mover | — |
| `FileBase` / `FileData` | `SmartDigitalPsico.Domain.ModelEntity.Contracts` | ModelEntity/Contracts | — | Mover | — |
| `FileDetailDto` | `SmartDigitalPsico.Domain.DTO.Utils` | `DTO/Utils/FileDetailDto.cs` | — | Mover | — |
| `SmtpSettingsDto` / `EmailMessageDto` | `SmartDigitalPsico.Domain.DTO.SMTP` | `DTO/SMTP/` | — | Mover | Smtp tests |

### 7.2 Manter

| Nome | Situação |
| ---- | -------- |
| `TokenVO` | Manter (auth do produto) |
| `AuthConfigurationDto` / `DataBaseConfigurationDto` / `AppConfigurationSettingDto` | Manter (config de produto) |
| DTOs Add/Get/Update de Domains (Gender, Office, Specialty, Leaves, Notification*, Application*, Audit*) | Manter |
| DTOs de Patient / Medical / User / Schedule | Manter |
| `DataNotificationTemplateVO` | Manter |
| Bases DTO de notificação/leaves/audit com campos de negócio | Manter |
| `FileBaseDto` / `FileBaseIdDto` (se acoplados a MedicalFile) | Manter |

---

## 8. Hypermedia

### 8.1 Mover (framework)

| Nome | Namespace | Arquivo | Situação | Testes |
| ---- | --------- | ------- | -------- | ------ |
| `ContentResponseEnricher<T>` | `SmartDigitalPsico.Domain.Hypermedia` | `Hypermedia/ContentResponseEnricher.cs` | Mover | Domain.Test Hypermedia (se houver) |
| `IResponseEnricher` / `ISupportsHyperMedia` | `...Hypermedia.Abstract` | `Hypermedia/Abstract/` | Mover | — |
| `HyperMediaLink` | `...Hypermedia` | `Hypermedia/HyperMediaLink.cs` | Mover | — |
| `HyperMediaConfigure` | idem | `Hypermedia/HyperMediaConfigure.cs` | Mover | — |
| `HyperMediaFilterrAttribute` / `HyperMediaFilterOptions` | `...Hypermedia.Filters` | `Hypermedia/Filters/` | Mover | — |
| `RelationType`, `ResponseTypeFormat`, `HttpActionVerb` | `...Hypermedia.Constants` | `Hypermedia/Constants/` | Mover | — |

### 8.2 Manter (enrichers de domínio)

Todos sob `Hypermedia/Enricher/Principals/` e `Hypermedia/Enricher/Domains/`:  
`GetPatientEnricher`, `GetPatientRecordEnricher`, `GetPatient*Enricher`, `GetUserEnricher`, `GetMedicalEnricher`, `GetMedicalFileEnricher`, `GetSpecialtyEnricher`, `GetRoleGroupEnricher`, `GetOfficeEnricher`, `GetGenderEnricher`, `GetApplicationLanguageEnricher`, `GetApplicationConfigSettingEnricher`.

---

## 9. SMTP / e-mail (infra genérica)

| Nome | Namespace | Arquivo | Situação | Testes |
| ---- | --------- | ------- | -------- | ------ |
| `SmtpEmailStrategy` | `SmartDigitalPsico.Service.Infrastructure.Smtp` | `.../SmtpEmailStrategy.cs` | Mover | `SmtpEmailStrategyTests` |
| `EmailStrategyFactory` | idem | `.../EmailStrategyFactory.cs` | Mover | — |
| `EmailContext` | idem | `.../EmailContext.cs` | Mover | — |
| `ThirdPartyEmailStrategy` | idem | `.../ThirdPartyEmailStrategy.cs` | Mover | — |

Sms/WhatsApp notification services: **Manter** (templates de domínio).

---

## 10. Services genéricos e API

| Nome | Namespace | Arquivo | Situação | Motivo |
| ---- | --------- | ------- | -------- | ------ |
| `EntityBaseService<...>` | `SmartDigitalPsico.Service.DataEntity.Generic` | `Service/DataEntity/Generic/EntityBaseService.cs` | **Manter** | Validators, localization, regras de negócio |
| `ReportBaseService<...>` | idem | `ReportBaseService.cs` | **Manter** | Conteúdo de report de domínio |
| `IEntityBaseService<T,TResult>` | Domain Interfaces | — | **Manter** | Contrato acoplado ao serviço de negócio no host |
| `ApiBaseController` | `SmartDigitalPsico.Domain.API` | `API/ApiBaseController.cs` | **Mover** | Já existe em Domain |
| Controllers WebAPI, middlewares de produto | WebAPI | — | Manter | Específico |

Testes: `EntityBaseServiceTests` / `ReportBaseServiceTests` **Manter**; `ApiBaseControllerTests` **Mover**.

---

## 11. Extensões

| Nome | Namespace | Arquivo | Situação |
| ---- | --------- | ------- | -------- |
| `ModelBuilderExtensions` | `SmartDigitalPsico.Data.Context.Configure.Helper` | Data Context Configure Helper | Manter (EF específico) |
| Pasta `Domain/Extensions/` | — | vazia (só subpasta Schedule sem `.cs`) | N/A |

Não criar classes `*Extensions` novas. Não há outras com métodos `this` genéricos a mover.

---

## 12. Tipos inexistentes neste solution (Não mover — não criar)

| Tipo buscado | Status |
| ------------ | ------ |
| `GenericRepository` (nome exato) | Ausente — usar `GenericRepositoryEntityBase` |
| `DapperGenericRepository` / qualquer Dapper | Ausente — não criar |
| `IUnitOfWork` / `UnitOfWork` | Ausente — não criar |
| `Guard`, `Result<T>`, `StringHelper`, `DateTimeHelper`, `ErrorCodes` | Ausentes — não criar; equivalentes existentes em §1 |
| `MemoryCacheProvider`, `RedisCacheProvider`, `DiskCacheProvider` | Ausentes — usar `*CacheRepository` / `CacheService` |
| `MongoPersistenceAdapter` | Ausente — não criar |
| Interface mínima nova de contexto EF | Proibido — retarget para `DbContext` existente |

---

## 13. Testes a mover → `SmartDigitalPsicoAPI.Core.SDK.Tests`

Mapa origem → destino. **Mover** o arquivo de teste (não replicar/duplicar). Remover do projeto de origem após o move bem-sucedido.

### Data.Test → Core.SDK.Tests

| Teste origem | Tipos cobertos |
| ------------ | -------------- |
| `Repository/Coverage/ScheduleAndGenericRepositoryCoverageTests.cs` | `GenericRepositoryEntityBase` |
| `Repository/Coverage/RemainingDataCoverageTests.cs` | Generic EF, queue, caches (partes dos tipos movidos) |
| `Repository/Coverage/GenericTableEntityRepositoryTests.cs` | `GenericTableEntityRepository<T>` |
| `Repository/CacheManager/MemoryCacheRepositoryTests.cs` | `MemoryCacheRepository` |
| `Repository/Coverage/FileAndDiskCacheRepositoryTests.cs` | `DiskCacheRepository`, `FileDiskRepository` |
| `Repository/Coverage/FileDiskRepositoryIncompleteReadTests.cs` | `FileDiskRepository` |

`GenderAndGenericRepositoryTests` e `FileManagerCoverageTests`: **Manter** no Data.Test (exercitam repo/FileManager de domínio).

### Service.Test → Core.SDK.Tests

| Teste origem | Tipos cobertos |
| ------------ | -------------- |
| `Infrastructure/InfrastructureFactoryTests.cs` | Factories Table/Queue |
| `Infrastructure/StorageTableEntityServiceTests.cs` | Table service + factory |
| `Infrastructure/Azure/AzureStorageAdaptersCoverageTests.cs` | Azure Blob/Table/Queue |
| `Infrastructure/CacheServiceTests.cs` | `CacheService` |
| `Infrastructure/InfrastructureMethodCoverageGapTests.cs` | Queue/cache gaps dos tipos movidos |
| Smtp tests (`SmtpEmailStrategyTests` etc.) | SMTP strategies |

`ConfigurationAndCryptoServiceTests`: mover apenas se cobrir só tipos movidos; senão manter no Service.Test e cobrir crypto no SDK via `CryptoAndTokenTests`.

### Domain.Test → Core.SDK.Tests

| Teste origem | Tipos cobertos |
| ------------ | -------------- |
| `Helper/GeneralHelpersTests.cs` | DateHelper, CultureDateTimeHelper, EmailHelper, etc. |
| `Helpers/DirectoryHelperTests.cs` | `DirectoryHelper` |
| `Helpers/FileHelperTests.cs` | `FileHelper` |
| `Helpers/ServiceCollectionHelperTests.cs` | `ServiceCollectionHelper` |
| `Helpers/RequestCultureMiddlewareTests.cs` | `RequestCultureMiddleware` |
| `Helper/SerializationHelpersTests.cs` | Json converters/resolvers |
| `Helper/Security/SecurityHelpersTests.cs` | Security/crypto helpers |
| `Security/CryptoAndTokenTests.cs` | Crypto adapters |
| `Report/*AdapterTests.cs` | Excel/PDF adapters |
| `Validation/ValidationHelperTests.cs` | `HelperValidation` / `ValidationErrorCodes` |
| `AppException/AppExceptionTests.cs` | ExceptionHandler |
| `API/ApiBaseControllerTests.cs` | `ApiBaseController` |

**Não mover testes de:** validators de Patient/Medical/Schedule, enrichers de domínio, repositórios de domínio, `EntityBaseService`/`ReportBaseService`, `LogAppHelperTests` (tipo mantido).

---

## 14. Resumo quantitativo (candidatos)

| Categoria | Mover (aprox.) | Manter / Não mover |
| --------- | ---------------:| -------------------:|
| Repositórios genéricos + factories + file disk | ~16 | ~25 repos de domínio + DbContext |
| Cache | ~11 (incl. `CacheService` integral) | ApplicationCacheLog* |
| Adapters Azure + contratos | ~6 | Table entities / token adapters de domínio |
| Crypto + report engines | ~13 | Conteúdo clínico / TokenService / report services host |
| Helpers + API base | ~22 | Schedule/Medical/i18n/EF/config host |
| VOs / DTOs base / contracts | ~18 | Dezenas de DTOs de domínio |
| Hypermedia framework | ~10 | ~15 enrichers de domínio |
| SMTP | ~4 | Canais notificação de domínio |
| Services de negócio | 0 | EntityBaseService, ReportBaseService, controllers |

---

## 15. Diagrama alvo

```mermaid
flowchart LR
  subgraph host [SmartDigitalPsico host]
    Domain[Domain especifico]
    Data[Data repos de dominio]
    Service[Service negocio]
    API[WebAPI]
  end
  subgraph sdk [SmartDigitalPsicoAPI.Core.SDK]
    GenRepo[GenericRepositoryEntityBase]
    Cache[Memory Disk CacheService]
    Azure[Azure Adapters]
    Helpers[Helpers VOs DTOs]
    Crypto[Crypto Report SMTP]
  end
  Data --> GenRepo
  Service --> Cache
  Service --> Azure
  Domain --> Helpers
  Domain --> Crypto
```

Código no SDK = arquivos **movidos** de Domain/Data/Service/WebAPI. Nada inventado.

---

## 16. Próximo documento

- Plano operacional: [PlanoDeAcao.md](./PlanoDeAcao.md)  
- Acompanhamento: [Progresso.md](./Progresso.md)
