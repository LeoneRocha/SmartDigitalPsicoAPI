# Progresso — SmartDigitalPsicoAPI.Core.SDK

**Versão:** 1.2.1  
**Data:** 2026-08-04  
**Status geral:** Documentação v1.2.1 (Core canônico + host `[Obsolete]`) — portabilidade de código **não iniciada**  
**Documentos:** [Levantamento.md](./Levantamento.md) · [PlanoDeAcao.md](./PlanoDeAcao.md) · [Levantamento-ScheduleNotificationCore.md](./Levantamento-ScheduleNotificationCore.md) *(backlog)*

---

## Checklist de execução

| Item | Status | Progresso | Fase | Notas |
| ---- | ------ | --------: | ---- | ----- |
| Shell `SmartDigitalPsicoAPI.Core.SDK` criado | Pendente | 0% | 1 | Só csproj + solution |
| Shell `SmartDigitalPsicoAPI.Core.SDK.Tests` criado | Pendente | 0% | 1 | Mesmas libs de teste do host |
| Testes canônicos em Core.SDK.Tests | Pendente | 0% | 2–7 | Host tests não apagar; usings → Core |
| Repositórios genéricos portados + host Obsolete | Pendente | 0% | 2 | Shim + comentário; retarget `DbContext` só no Core |
| Cache portado + host Obsolete | Pendente | 0% | 3 | `CacheService` integral (stubs inclusos) |
| Adapters Azure portados + host Obsolete | Pendente | 0% | 4 | Blob/Table/Queue |
| Helpers/VOs/DTOs/crypto/hypermedia/report/SMTP/API portados + host Obsolete | Pendente | 0% | 5 | Conforme Levantamento |
| Usings/DI consumidores 100% no Core | Pendente | 0% | 6 | Shims Obsolete **permanecem** (consulta); não apagar |
| Cobertura ≥ 90% validada (SDK) | Pendente | 0% | 7 | Coverlet no SDK.Tests |
| Validação EF (migration smoke) | Pendente | 0% | 7 | Sem mudança de schema de produção |
| Docker build/test OK | Pendente | 0% | 7 | Pipeline / compose existente |
| Zero regressão funcional confirmada | Pendente | 0% | 7 | APIs/contratos idênticos |

**Legenda de status:** `Pendente` · `Em andamento` · `Concluído` · `Bloqueado`

---

## Progresso por fase

| Fase | Título | Status | % |
| ---- | ------ | ------ | -: |
| 1 | Scaffolding do container (shell) | Pendente | 0 |
| 2 | Portar repositórios genéricos + Obsoletar no host | Pendente | 0 |
| 3 | Portar cache + Obsoletar no host | Pendente | 0 |
| 4 | Portar adapters Azure + Obsoletar no host | Pendente | 0 |
| 5 | Portar helpers/VOs/crypto/hypermedia/report/SMTP/API + Obsoletar | Pendente | 0 |
| 6 | Consolidar usings no Core (sem apagar host) | Pendente | 0 |
| 7 | Cobertura, EF, Docker | Pendente | 0 |

**Progresso global estimado:** 0% (código) · 100% (documentação de planejamento v1.2.1)

### Backlog (fora das Fases 1–7)

| Item | Status | Doc |
| ---- | ------ | --- |
| Schedule Core + NotificationTemplate (levantamento) | Documentado | [Levantamento-ScheduleNotificationCore.md](./Levantamento-ScheduleNotificationCore.md) |
| Portar Schedule Core para Core.SDK | Pendente (não iniciado) | Priorizar após Fases 1–7 de infra |

---

## Como atualizar este arquivo

Ao concluir cada fase do [PlanoDeAcao.md](./PlanoDeAcao.md):

1. Alterar a linha correspondente na checklist (`Pendente` → `Concluído`, ajustar %).
2. Atualizar a tabela “Progresso por fase”.
3. Acrescentar entrada no **Changelog** (data, fase, o que **portou**, o que **Obsoleteou**, usings atualizados, evidência de build/teste).
4. Confirmar que os arquivos originais no host **não foram apagados**.
5. Se houver bloqueio, marcar `Bloqueado` e descrever o motivo.

---

## Changelog

| Data | Evento | Detalhe |
| ---- | ------ | ------- |
| 2026-08-04 | Documentação v1.0 criada | Inventário e plano iniciais. |
| 2026-08-04 | Documentação v1.1 — só mover, não criar | Relocação física; apagar da origem. |
| 2026-08-04 | Documentação v1.2 — Core canônico + host Obsolete | **Não apagar** implementações atuais; portar canônico para Core; host fica `[Obsolete]` + comentário (consulta/shim); consumidores atualizam usings para o Core. Remoção física dos shims fora de escopo. Portabilidade de código **não iniciada**. |
| 2026-08-04 | Documentação v1.2.1 — Adapters/Factories + Schedule fatia | Levantamento: §2.3 EF Entity = Manter; §2.4 Factories/Adapters explícitos. Novo [Levantamento-ScheduleNotificationCore.md](./Levantamento-ScheduleNotificationCore.md) (Schedule/Core + NotificationTemplate). Cross-links no Plano/Progresso. |

---

## Evidências (preencher na execução)

| Fase | Build | Testes | Cobertura | Docker | Host Obsolete OK | Usings Core OK | Observação |
| ---- | ----- | ------ | --------- | ------ | ---------------- | -------------- | ---------- |
| 1 | — | — | — | — | N/A | N/A | Shell apenas |
| 2 | — | — | — | — | — | — | — |
| 3 | — | — | — | — | — | — | — |
| 4 | — | — | — | — | — | — | — |
| 5 | — | — | — | — | — | — | — |
| 6 | — | — | — | — | — | — | Sem apagar shims |
| 7 | — | — | — | — | — | — | — |
