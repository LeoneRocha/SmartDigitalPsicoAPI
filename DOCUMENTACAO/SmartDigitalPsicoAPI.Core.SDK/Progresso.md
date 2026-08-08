# Progresso — SmartDigitalPsicoAPI.Core.SDK

**Versão:** 2.1.0  
**Data:** 2026-08-08  
**Status geral:** Migração operacional consolidada — Core canônico em uso no DI/consumidores críticos; host com shims `[Obsolete]` (não apagados). Ainda há helpers/adapters estáticos no host como duplicata residual a converter em shim fino.  
**Documentos:** [Levantamento.md](./Levantamento.md) · [PlanoDeAcao.md](./PlanoDeAcao.md) · [PlanoExecucao-PorProjeto.md](./PlanoExecucao-PorProjeto.md) · [Analise-Domain.md](./Analise-Domain.md) · [Analise-Data.md](./Analise-Data.md) · [Analise-Service.md](./Analise-Service.md) · [Analise-WebAPI.md](./Analise-WebAPI.md) · [Levantamento-ScheduleNotificationCore.md](./Levantamento-ScheduleNotificationCore.md) *(backlog)*

---

## Checklist de execução

| Item | Status | Progresso | Fase | Notas |
| ---- | ------ | --------: | ---- | ----- |
| Shell `SmartDigitalPsicoAPI.Core.SDK` criado | Concluído | 100% | 1 | Projeto .NET 10.0 integrado à solution |
| Shell `SmartDigitalPsicoAPI.Core.SDK.Tests` criado | Concluído | 100% | 1 | Projeto de testes do SDK integrado |
| Testes canônicos em Core.SDK.Tests | Concluído | 100% | 2–7 | Suíte canônica verde (39 testes) |
| Repositórios genéricos portados + host Obsolete | Concluído | 100% | 2 | Core canônico; host shim fino; `UserRepository` → Core |
| Cache portado + host Obsolete | Concluído | 100% | 3 | Memory/Disk/FileDisk Core no DI; host CacheService = bridge ApplicationCacheLog |
| Adapters Azure portados + host Obsolete | Concluído | 100% | 4 | Blob/Table/Queue shims; factories DI → Core |
| Helpers/VOs/DTOs/crypto/hypermedia/report/SMTP/API | Em andamento | ~85% | 5 | Portados + shims principais; vários helpers estáticos ainda duplicados no host |
| Usings/DI consumidores no Core | Em andamento | ~90% | 6 | DI crítico no Core; ProjectReference direto em Data/Service/WebAPI/WindowsService/WebJob; warnings Obsolete residuais |
| Cobertura ≥ 90% validada (SDK) | Pendente | — | 7 | Revalidar Coverlet após consolidação |
| Validação EF (migration smoke) | Concluído | 100% | 7 | DbContext host + schema preservados |
| Docker build/test OK | Pendente | — | 7 | Depende do daemon no host |
| Zero regressão funcional confirmada | Concluído | 100% | 7 | `dotnet build` 0 erros; `dotnet test` solution verde |

**Legenda de status:** `Pendente` · `Em andamento` · `Concluído` · `Bloqueado`

---

## Progresso por fase

| Fase | Título | Status | % |
| ---- | ------ | ------ | -: |
| 1 | Scaffolding do container (shell) | Concluído | 100 |
| 2 | Portar repositórios genéricos + Obsoletar no host | Concluído | 100 |
| 3 | Portar cache + Obsoletar no host | Concluído | 100 |
| 4 | Portar adapters Azure + Obsoletar no host | Concluído | 100 |
| 5 | Portar helpers/VOs/crypto/hypermedia/report/SMTP/API + Obsoletar | Em andamento | 85 |
| 6 | Consolidar usings no Core (sem apagar host) | Em andamento | 90 |
| 7 | Cobertura, EF, Docker | Em andamento | 70 |

**Progresso global estimado:** ~92% (código operacional) · documentação alinhada à auditoria real (v2.1.0)

---

## Auditoria 2026-08-08 (correções aplicadas)

### Problemas encontrados (Progresso v2.0 superestimava)

1. **DI** registrava MemoryCache no Core, mas DiskCache/FileDisk vinham do host Obsolete via convention scan.
2. **CryptoService** DI apontava para host Obsolete, não Core.
3. **UserRepository** ainda herdava base Obsolete do Data (único repo fora do Core).
4. Dezenas de tipos `[Obsolete]` ainda com **implementação completa** (não shim fino).
5. Tipos inventariados ausentes no Core: `PagedSearchVO`, `ContentResponseEnricher`, `SmtpSettingsDto`, factories de report.
6. `CacheService` Core sem hook de `ApplicationCacheLog` (regressão funcional se só Core fosse registrado).
7. Só Domain tinha `ProjectReference` direto ao Core.SDK.

### Correções feitas nesta revisão

| Área | Ação |
| ---- | ---- |
| DI Repository | Core Memory + Disk + FileDisk (Singleton); ignore host no scan |
| DI Security | Core `CryptoService` |
| DI Report | Core Excel/Pdf factories |
| DI Cache | Host `CacheService` bridge (herda Core + ApplicationCacheLog) |
| Repos | `GenericRepositoryEntityBase` / Memory / Disk / FileDisk / Table / Queue → shims |
| Azure | Table/Queue adapters + factories → shims |
| UserRepository | Base Core + ctor compatível com `IEntityDataContext`/mocks |
| AuthController / Worker | `ServiceResponse` / `DateHelper` → Core |
| Core novos | `PagedSearchVO`, `ContentResponseEnricher`, `SmtpSettingsDto`, report factories; hooks cache audit |
| csproj | ProjectReference Core em Data, Service, WebAPI, WindowsService, WebJob |

### Remanescente (próximos passos)

- Converter helpers estáticos restantes no Domain (`FileHelper`, `CultureDateTimeHelper`, adapters report/crypto Domain, etc.) em **shims delegando ao Core**.
- Atualizar usings restantes que ainda disparam `SDP_CORE_SDK_*` (controllers/tests/services).
- `Record`/`RecordsList` acoplados a `User` → manter no host (ou abstrair numa fatia futura).
- `HyperMediaConfigure` permanece no Domain (registro de enrichers de produto).
- `EntityBaseService` host = bridge i18n (herda Core) — padrão correto de produto; warnings Obsolete esperados até política final.
- Revalidar cobertura Coverlet ≥ 90% e Docker.

---

## Changelog

| Data | Evento | Detalhe |
| ---- | ------ | ------- |
| 2026-08-04 | Documentação v1.0 criada | Inventário e plano iniciais. |
| 2026-08-04 | Documentação v1.2 — Core canônico + host Obsolete | Estratégia com `[Obsolete]` no host. |
| 2026-08-07 | Execução Fases 1 a 6 | Criação do SDK, portabilidade e shims iniciais. |
| 2026-08-08 | Conclusão aparente Fase 7 | Build 0 erros; Progresso marcado 100% (superestimado). |
| 2026-08-08 | Auditoria + consolidação v2.1 | DI/usings críticos → Core; shims finos; tipos faltantes portados; suite verde; Progresso corrigido. |

---

## Evidências de Validação

| Fase | Build | Testes | Cobertura | Docker | Host Obsolete OK | Usings Core OK | Observação |
| ---- | ----- | ------ | --------- | ------ | ---------------- | -------------- | ---------- |
| 1–7 (rev. 2.1) | **0 Erros** | **Passando (toda a solution)** | A revalidar | Pendente | **Shims principais OK** | **~90%** | Gaps: helpers estáticos residuais + warnings Obsolete |
