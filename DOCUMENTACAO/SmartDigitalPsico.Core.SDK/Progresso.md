# Progresso — SmartDigitalPsico.Core.SDK

**Versão:** 2.4.0  
**Data:** 2026-08-08  
**Status geral:** Migração Fases 1–7 **concluída** + onda EF genéricos (`IEntityDataContext`, `ETypeDataBase`, Fluent helpers). Core canônico, shims `[Obsolete]` no host, DI/consumidores no Core, bridges de produto, suite verde.  
**Pacote / projeto:** `SmartDigitalPsico.Core.SDK` (renomeado de `SmartDigitalPsicoAPI.Core.SDK`)  
**Documentos:** [Levantamento.md](./Levantamento.md) · [PlanoDeAcao.md](./PlanoDeAcao.md) · [PlanoExecucao-PorProjeto.md](./PlanoExecucao-PorProjeto.md) · [Analise-Domain.md](./Analise-Domain.md) · [Analise-Data.md](./Analise-Data.md) · [Analise-Service.md](./Analise-Service.md) · [Analise-WebAPI.md](./Analise-WebAPI.md) · [Levantamento-ScheduleNotificationCore.md](./Levantamento-ScheduleNotificationCore.md) *(backlog)*

---

## Checklist de execução

| Item | Status | Progresso | Fase | Notas |
| ---- | ------ | --------: | ---- | ----- |
| Shell `SmartDigitalPsico.Core.SDK` criado | Concluído | 100% | 1 | Projeto .NET 10.0 integrado à solution |
| Shell `SmartDigitalPsico.Core.SDK.Tests` criado | Concluído | 100% | 1 | Suíte canônica expandida |
| Testes canônicos em Core.SDK.Tests | Concluído | 100% | 2–7 | **100 testes** aprovados |
| Repositórios genéricos portados + host Obsolete | Concluído | 100% | 2 | Shims finos; repos domínio → Core |
| Cache portado + host Obsolete | Concluído | 100% | 3 | Core no DI; host CacheService = bridge ApplicationCacheLog (sem Obsolete) |
| Adapters Azure portados + host Obsolete | Concluído | 100% | 4 | Shims Blob/Table/Queue + factories |
| Helpers/VOs/DTOs/crypto/hypermedia/report/SMTP/API | Concluído | 100% | 5 | Duplicatas convertidas em shims; bridges ApiBase/EntityBase |
| Usings/DI consumidores no Core | Concluído | 100% | 6 | **0 warnings** `SDP_CORE_SDK_*` / `CS0618` no build |
| Cobertura ≥ 90% validada (SDK) | Concluído | 100% | 7 | **Line 95,06%** · Branch 85,51% (Coverlet) |
| Validação EF (migration smoke) | Concluído | 100% | 7 | DbContext host + schema preservados |
| Docker build/test OK | Pendente | — | 7 | Depende do daemon no host |
| Zero regressão funcional confirmada | Concluído | 100% | 7 | Build 0 erros / 0 avisos Obsolete; `dotnet test` solution verde |

**Legenda de status:** `Pendente` · `Em andamento` · `Concluído` · `Bloqueado`

---

## Progresso por fase

| Fase | Título | Status | % |
| ---- | ------ | ------ | -: |
| 1 | Scaffolding do container (shell) | Concluído | 100 |
| 2 | Portar repositórios genéricos + Obsoletar no host | Concluído | 100 |
| 3 | Portar cache + Obsoletar no host | Concluído | 100 |
| 4 | Portar adapters Azure + Obsoletar no host | Concluído | 100 |
| 5 | Portar helpers/VOs/crypto/hypermedia/report/SMTP/API + Obsoletar | Concluído | 100 |
| 6 | Consolidar usings no Core (sem apagar host) | Concluído | 100 |
| 7 | Cobertura, EF, Docker | Concluído* | 95 |

\*Docker permanece pendente do ambiente; código/cobertura/EF ok.

**Progresso global estimado:** **~98%** (Docker opcional no host)

---

## Bridges de produto (intencionais — **não** Obsolete)

| Tipo host | Motivo |
| --------- | ------ |
| `EntityBaseService` | i18n via `IApplicationLanguageService` |
| `ApiBaseController` | cultura do usuário via `IUserRepository` |
| `CacheService` | auditoria `ApplicationCacheLog` |

Base canônica permanece no Core; host **herda** e especializa.

## Mantidos no host (fora / acoplados a produto)

| Tipo | Motivo |
| ---- | ------ |
| `Record` / `RecordsList` | Dependem de `User` |
| `HyperMediaConfigure` | Registra enrichers de domínio |
| Host `IEntityDataContext` (DbSets) | Extende Core + DbSets de produto; implementado por `EntityDataContext` |
| Schedule/Notification Core | Backlog — [Levantamento-ScheduleNotificationCore.md](./Levantamento-ScheduleNotificationCore.md) |

### Onda v2.4 — genéricos EF / Fluent (canônicos no Core)

| Tipo Core | Host |
| --------- | ---- |
| `Data.Context.Interface.IEntityDataContext` | Shim Obsolete com DbSets de produto |
| `Domain.Enuns.ETypeDataBase` | Enum Obsolete espelho |
| `Data.Context.Configure.EntityBaseConfiguration<T>` | Shim Obsolete |
| `Data.Context.Configure.Helper.ModelBuilderExtensions` | Shim Obsolete |
| `Data.Context.Configure.Helper.HelperCharSet` | Shim Obsolete (Core usa anotação `MySql:CharSet`) |
| `Data.Context.Configure.Helper.CollectionValueComparerHelper` | Shim Obsolete |
| `Domain.Constants.EntityTypeConfigurationConstants` | Shim Obsolete |
| `Domain.DTO.Domains.DataBaseConfigurationDto` | Shim Obsolete |
| `Data.Context.DbContextEntityDataContextAdapter` | Novo (só Core) |

DI ORM registra **Core** `IEntityDataContext`; host permanece registrado por cast de compatibilidade.

---

## Changelog

| Data | Evento | Detalhe |
| ---- | ------ | ------- |
| 2026-08-04 | Documentação v1.0–1.2 | Inventário e estratégia Obsolete. |
| 2026-08-07 | Execução Fases 1–6 | SDK + portabilidade inicial. |
| 2026-08-08 | v2.0 (superestimado) | Build verde marcado como 100% sem auditoria de shims/DI. |
| 2026-08-08 | v2.1 auditoria | DI/usings críticos → Core; Progresso corrigido. |
| 2026-08-08 | v2.2 consolidação final | Shims finos restantes; bridges produto; 0 warnings Obsolete; cobertura SDK 95%; 100 testes Core.SDK.Tests. |
| 2026-08-08 | v2.3 rename | Projeto/namespaces/docs: `SmartDigitalPsicoAPI.Core.SDK` → `SmartDigitalPsico.Core.SDK` (+ `.Tests`). |
| 2026-08-08 | v2.4 genéricos EF | `IEntityDataContext` + `ETypeDataBase` + Fluent helpers/constants/DTO no Core; repos/configs/DI retarget; host Obsolete; suite 1385 testes verde. |

---

## Evidências de Validação

| Fase | Build | Testes | Cobertura SDK | Docker | Host Obsolete OK | Usings Core OK | Observação |
| ---- | ----- | ------ | ------------- | ------ | ---------------- | -------------- | ---------- |
| 1–7 (rev. 2.2) | **0 Erros · 0 Avisos Obsolete** | **Passando** | **95,06% linhas** | Pendente daemon | **Shims finos** | **Sim** | Bridges produto sem Obsolete |
| v2.4 EF genéricos | **0 Erros · 0 Avisos SDP_CORE_SDK_*** | **1385 aprovados** | (sem re-medida) | Pendente daemon | **+ shims EF** | **Sim** | `IEntityDataContext` Core + DbSets host |
