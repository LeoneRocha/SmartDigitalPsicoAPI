# Progresso — SmartDigitalPsicoAPI.Core.SDK

**Versão:** 1.1  
**Data:** 2026-08-04  
**Status geral:** Documentação v1.1 (só mover, não criar) — relocação de código **não iniciada**  
**Documentos:** [Levantamento.md](./Levantamento.md) · [PlanoDeAcao.md](./PlanoDeAcao.md)

---

## Checklist de execução

| Item | Status | Progresso | Fase | Notas |
| ---- | ------ | --------: | ---- | ----- |
| Shell `SmartDigitalPsicoAPI.Core.SDK` criado | Pendente | 0% | 1 | Só csproj + solution; zero classes de negócio |
| Shell `SmartDigitalPsicoAPI.Core.SDK.Tests` criado | Pendente | 0% | 1 | Mesmas libs de teste do host |
| Testes movidos para Core.SDK.Tests | Pendente | 0% | 2–7 | Sem duplicar suíte; ver Levantamento §13 |
| Repositórios genéricos movidos | Pendente | 0% | 2 | Retarget construtor → `DbContext` (EF existente) |
| Providers de cache movidos | Pendente | 0% | 3 | `CacheService` movido como está (stubs inclusos) |
| Adapters cloud movidos | Pendente | 0% | 4 | Azure Blob/Table/Queue existentes |
| Helpers / VOs / DTOs / crypto / hypermedia / report / SMTP / API base movidos | Pendente | 0% | 5 | Conforme Levantamento; sem tipos novos |
| Consolidação — arquivos saíram do host | Pendente | 0% | 6 | Pack `dotnet pack` OK |
| Cobertura ≥ 90% validada (módulos movidos) | Pendente | 0% | 7 | Coverlet no SDK.Tests |
| Validação EF (migration smoke) | Pendente | 0% | 7 | Sem mudança de schema de produção |
| Docker build/test OK | Pendente | 0% | 7 | Pipeline / compose existente |
| Zero regressão funcional confirmada | Pendente | 0% | 7 | APIs/contratos idênticos |

**Legenda de status:** `Pendente` · `Em andamento` · `Concluído` · `Bloqueado`

---

## Progresso por fase

| Fase | Título | Status | % |
| ---- | ------ | ------ | -: |
| 1 | Scaffolding do container (shell) | Pendente | 0 |
| 2 | Mover repositórios genéricos | Pendente | 0 |
| 3 | Mover providers de cache | Pendente | 0 |
| 4 | Mover adapters Azure | Pendente | 0 |
| 5 | Mover helpers, VOs, DTOs, crypto, hypermedia, report, SMTP, API base | Pendente | 0 |
| 6 | Consolidação (sem duplicados) | Pendente | 0 |
| 7 | Cobertura, EF, Docker | Pendente | 0 |

**Progresso global estimado:** 0% (código) · 100% (documentação de planejamento v1.1)

---

## Como atualizar este arquivo

Ao concluir cada fase do [PlanoDeAcao.md](./PlanoDeAcao.md):

1. Alterar a linha correspondente na tabela de checklist (`Pendente` → `Concluído`, ajustar %).
2. Atualizar a tabela “Progresso por fase”.
3. Acrescentar entrada no **Changelog** abaixo (data, fase, o que **moveu**, evidência de build/teste).
4. Se houver bloqueio, marcar `Bloqueado` e descrever o motivo no changelog.
5. Confirmar que o diff da fase **não** introduziu tipos novos.

---

## Changelog

| Data | Evento | Detalhe |
| ---- | ------ | ------- |
| 2026-08-04 | Documentação v1.0 criada | Pasta `DOCUMENTACAO/SmartDigitalPsicoAPI.Core.SDK/` com inventário e plano iniciais. |
| 2026-08-04 | Documentação v1.1 — só mover, não criar | Revisados `Levantamento.md`, `PlanoDeAcao.md` e `Progresso.md`: glossário Mover/Manter/Não mover; proibido inventar abstrações; `CacheService` move integral; `ApiBaseController`/`RequestCultureMiddleware` move; testes **movidos** (não replicados); retarget EF para `DbContext` existente (sem interface nova). Relocação de código **não iniciada**. |

---

## Evidências (preencher na execução)

| Fase | Build | Testes | Cobertura | Docker | Observação |
| ---- | ----- | ------ | --------- | ------ | ---------- |
| 1 | — | — | — | — | Shell apenas |
| 2 | — | — | — | — | — |
| 3 | — | — | — | — | — |
| 4 | — | — | — | — | — |
| 5 | — | — | — | — | — |
| 6 | — | — | — | — | — |
| 7 | — | — | — | — | — |
