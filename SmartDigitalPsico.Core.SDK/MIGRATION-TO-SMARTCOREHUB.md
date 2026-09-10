# SmartDigitalPsico.Core.SDK → casca sobre SmartCoreHub.Core.SDK

**Status:** ✅ **SDP-CASCA** + ✅ **SDP-AJUSTE** + ✅ **SDP-LIMPEZA** — NuGet **`20260910.6.0`** · Core.SDK.Tests **140/140** · sln **1343** testes ✅  
**Atualizado:** 2026-09-09

Os tipos casca neste pacote estão marcados com `[SdkWrappedSource]`:
- citam o **pacote NuGet** `SmartCoreHub.Core.SDK` e o **FQN** do tipo destino;
- wrappers **delegam/herdam** de `SmartCoreHub.Core.SDK` (thin wrapper).
- Política: `[SdkWrappedSource]` (padrão HW). Opcional: `SDP_MIGRATED` / CS0618 (hosts `NoWarn` CS0618).

## Informações do Pacote

| Campo | Valor |
| :--- | :--- |
| **PackageId canônico** | `SmartCoreHub.Core.SDK` |
| **Versão oficial** | **`20260910.6.0`** ([nuget.org](https://www.nuget.org/packages/SmartCoreHub.Core.SDK/20260910.6.0)) |
| **Feed** | nuget.org (OK mantenedor 2026-09-09 / bump 2026-09-10) |
| **Atributo de casca** | `SdkWrappedSourceAttribute` |
| **DiagnosticId** | `SDP_MIGRATED` |

## Checklist SDP-CASCA

1. [x] Gate NuGet — publicado + OK mantenedor (`20260909.1825.0`; bump **`20260910.6.0`**).
2. [x] CPM / `PackageReference` → **`20260910.6.0`** (sem feed local).
3. [~] Thin wrappers `[SdkWrappedSource]` (MVP prévio realinhado ao NuGet oficial).
4. [x] Retenções clínicas / `EntityBase` documentadas.
5. [x] `SmartDigitalPsico.Core.SDK.Tests` verdes — **140/140** (pós-LIMPEZA).
6. [x] `SmartDigitalPsicoAPI.sln` Release 0 erros · suíte **1343/1343**.

## SDP-AJUSTE (2026-09-09) ✅

| # | Item | Status |
|:-:|---|:---:|
| SA.1 | `GlobalUsings.Core.cs` hosts → SCH | ✅ |
| SA.2 | DI `AddCore*` **somente** casca | ✅ |
| SA.3 | Testes + sln | ✅ |

## SDP-LIMPEZA (2026-09-09) ✅

| Ação | Detalhe |
| :--- | :--- |
| Inventário | **Zero** `[Obsolete]` na casca SDP; wrappers AJUSTE já thin |
| Removidos (mortos, 0 refs sln) | `Domain/DTO/Utils/FileDetailDto.cs`, `Domain/Enuns/ETimeUnitCalendarType.cs` |
| Thin `[SdkWrappedSource]` (elimina impl duplicada) | `AesKeyGeneratorHelper`, `ConfigurationSectionHelper`, `AppSettingsConfigurationHelper` → SCH |
| Preservado (casca pública / retenções) | Date/Directory/HtmlSanitizer/ValidationErrorCodes/AppWarningException wrappers; ServiceResponse; Enuns; FileHelper; EntityBaseService; CultureDateTimeHelper; OrderAttribute; HelperValidation; SecurityHelper password; ServiceCollectionHelper; Configure AddCore*; Hypermedia; clinical |

**Não** gut da PackageId casca. **Não** bump CPM. **Não** deletes em SCH.

### SL.4 — SCH Obsolete (bloqueado)

Limpeza de tipos `[Obsolete]` **dentro de `SmartCoreHub.Core.SDK`** (ex. futuro `HtmlSanitizerHelper` pós-próximo NuGet, cascas Common) exige **OK explícito do mantenedor**. Ver [PROGRESSO](../../../repos/SmartCoreHub/Documentation/CoreFinal/PROGRESSO.md) / [audit-dup-sdp-matriz](../../../repos/SmartCoreHub/Documentation/CoreFinal/audit-dup-sdp-matriz.md).

## Retenções intencionais (casca / domínio)

| Retido SDP | Motivo |
| :--- | :--- |
| `Service.Configure.*` AddCore* | Registra ifaces/impl casca |
| `Domain.VO.ServiceResponse*` | Envelope Success/Errors ≠ SCH |
| `Domain.Enuns` | Enuns vs Enums + clínicos |
| Hypermedia filters/enrichers | List `IResponseEnricher` SDP |
| `FileHelper` | quirk `GetSameName` |
| `EntityBaseService` | IAppLogger / ServiceResponse / IEntity* |
| `CultureDateTimeHelper` | DTOs SDP |
| `OrderAttribute` | ReflectionHelpers tipa Order SDP |
| `HelperValidation` | ErrorResponse VO SDP |
| `SecurityHelper` password hash | SCH só `IsBase64String` |
| `ServiceCollectionHelper` | RepositoryInfo SDP |
| Thin helpers `[SdkWrappedSource]` | Surface pública da casca NuGet |
| Clinical Domain/Patient/Medical | fora do Core |

## Próximo (opcional)

1. Publicar **novo NuGet SCH** com UNIF/EXT (`HypermediaServiceResponse`) + AD marks (`HtmlSanitizerHelper` Obsolete).
2. Bump CPM SDP → essa versão.
3. (Opcional) OK mantenedor para limpeza Obsolete **no SCH**.
