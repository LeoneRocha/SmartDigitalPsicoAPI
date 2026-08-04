# Progresso — SmartDigitalPsicoAPI.Core.SDK

**Versão:** 1.0  
**Data:** 2026-08-04  
**Status geral:** Documentação concluída — migração de código **não iniciada**  
**Documentos:** [Levantamento.md](./Levantamento.md) · [PlanoDeAcao.md](./PlanoDeAcao.md)

---

## Checklist de execução

| Item | Status | Progresso | Fase | Notas |
| ---- | ------ | --------: | ---- | ----- |
| Projeto `SmartDigitalPsicoAPI.Core.SDK` criado | Pendente | 0% | 1 | Incluir na solution + TFM net10.0 |
| Projeto `SmartDigitalPsicoAPI.Core.SDK.Tests` criado | Pendente | 0% | 1 | NUnit/Moq/Bogus/Coverlet |
| Testes replicados no Core.SDK.Tests | Pendente | 0% | 2–7 | Ver Levantamento §13 |
| Repositórios genéricos migrados | Pendente | 0% | 2 | `GenericRepositoryEntityBase`, Table/Queue, FileDisk |
| Providers de cache migrados | Pendente | 0% | 3 | Memory/Disk (+ fachada); sem stubs Redis/Mongo |
| Adapters cloud migrados | Pendente | 0% | 4 | Azure Blob/Table/Queue |
| Helpers / VOs / DTOs / crypto / hypermedia / report / SMTP migrados | Pendente | 0% | 5 | Conforme Levantamento |
| Consolidação — duplicados removidos no host | Pendente | 0% | 6 | Pack `dotnet pack` OK |
| Cobertura ≥ 90% validada (módulos migrados) | Pendente | 0% | 7 | Coverlet no SDK.Tests |
| Validação EF (migration smoke) | Pendente | 0% | 7 | Sem mudança de schema de produção |
| Docker build/test OK | Pendente | 0% | 7 | Pipeline / compose existente |
| Zero regressão funcional confirmada | Pendente | 0% | 7 | APIs/contratos idênticos |

**Legenda de status:** `Pendente` · `Em andamento` · `Concluído` · `Bloqueado`

---

## Progresso por fase

| Fase | Título | Status | % |
| ---- | ------ | ------ | -: |
| 1 | Scaffolding do projeto | Pendente | 0 |
| 2 | Repositórios genéricos | Pendente | 0 |
| 3 | Providers de cache | Pendente | 0 |
| 4 | Adapters Azure | Pendente | 0 |
| 5 | Helpers, VOs, DTOs, crypto, hypermedia, report, SMTP | Pendente | 0 |
| 6 | Consolidação e remoção de duplicados | Pendente | 0 |
| 7 | Testes, cobertura, EF, Docker | Pendente | 0 |

**Progresso global estimado:** 0% (código) · 100% (documentação de planejamento)

---

## Como atualizar este arquivo

Ao concluir cada fase do [PlanoDeAcao.md](./PlanoDeAcao.md):

1. Alterar a linha correspondente na tabela de checklist (`Pendente` → `Concluído`, ajustar %).
2. Atualizar a tabela “Progresso por fase”.
3. Acrescentar entrada no **Changelog** abaixo (data, fase, o que mudou, evidência de build/teste).
4. Se houver bloqueio, marcar `Bloqueado` e descrever o motivo no changelog.

---

## Changelog

| Data | Evento | Detalhe |
| ---- | ------ | ------- |
| 2026-08-04 | Documentação criada | Pasta `DOCUMENTACAO/SmartDigitalPsicoAPI.Core.SDK/` com `Levantamento.md`, `PlanoDeAcao.md` e `Progresso.md`. Inventário completo do solution SmartDigitalPsicoAPI (tipos reais; sem inventar Dapper/UoW/Mongo/Guard). Migração de código **não iniciada**. |

---

## Evidências (preencher na execução)

| Fase | Build | Testes | Cobertura | Docker | Observação |
| ---- | ----- | ------ | --------- | ------ | ---------- |
| 1 | — | — | — | — | — |
| 2 | — | — | — | — | — |
| 3 | — | — | — | — | — |
| 4 | — | — | — | — | — |
| 5 | — | — | — | — | — |
| 6 | — | — | — | — | — |
| 7 | — | — | — | — | — |
