# SmartDigitalPsico.Core.SDK — Plano de Implementação: Data

Plano de implementação, evolução e manutenção da camada **Data** do `SmartDigitalPsico.Core.SDK`.

---

## 1. Escopo e Objetivos

A camada Data gerencia o acesso a dados relacionais (EF Core), persistência NoSQL (Azure Tables / Queues), repositórios de cache local (Memory / Disk) e manipulação física de arquivos no sistema de arquivos.

---

## 2. Tarefas e Entregáveis

| Item | Componente | Descrição | Status |
| ---- | ---------- | --------- | ------ |
| **DAT-01** | `IEntityDataContext` & Adapter | Abstração e adaptador do `DbContext` para desacoplamento de repositórios. | ✅ Concluído |
| **DAT-02** | `EntityBaseConfiguration` | Configuração padrão de mapeamento Fluent API para `EntityBase`. | ✅ Concluído |
| **DAT-03** | `GenericRepositoryEntityBase<T>` | Implementação assíncrona de CRUD genérico com paginação e includes. | ✅ Concluído |
| **DAT-04** | Context Helpers | Utilitários de charset (`HelperCharSet`), comparadores de coleções e extensões de model builder. | ✅ Concluído |
| **DAT-05** | Cache Repositories | Repositórios para cache em memória (`MemoryCacheRepository`) e cache em disco (`DiskCacheRepository`). | ✅ Concluído |
| **DAT-06** | File Repository | Manipulação de arquivos no disco físico (`FileDiskRepository`). | ✅ Concluído |
| **DAT-07** | Azure Repositories | Repositórios genéricos para Azure Tables e Storage Queues. | ✅ Concluído |
| **DAT-08** | Testes Unitários | Testes unitários para repositórios com banco de dados em memória e mocks. | ✅ Concluído |

---

## 3. Diretrizes de Evolução e Manutenção

1. **EF Core 10:** Manter alinhamento com as novidades de performance e queries assíncronas do EF Core no .NET 10.
2. **Consultas Não Rastreáveis (`AsNoTracking`):** Otimizar consultas de leitura (`FindAll`, `FindWithPagedSearch`) com uso consistente de `AsNoTracking()` quando não houver necessidade de tracking.
3. **Gerenciamento de Transações:** Manter suporte nativo à execução de transações atômicas via `IEntityDataContext.Database`.

---

## 4. Relações com Outros Documentos

- [Especificação - Data](./SmartDigitalPsico.Core.SDK.Especificacao.Data.md)
- [Plano de Implementação Geral](./SmartDigitalPsico.Core.SDK.PlanoImplementacao.md)
- [Progresso e Status](./SmartDigitalPsico.Core.SDK.Progresso.md)
