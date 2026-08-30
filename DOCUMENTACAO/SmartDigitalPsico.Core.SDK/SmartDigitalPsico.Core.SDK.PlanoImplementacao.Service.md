# SmartDigitalPsico.Core.SDK — Plano de Implementação: Service e Infrastructure

Plano de implementação, evolução e manutenção das camadas **Service** e **Infrastructure** do `SmartDigitalPsico.Core.SDK`.

---

## 1. Escopo e Objetivos

As camadas Service e Infrastructure fornecem o serviço de aplicação genérico (`EntityBaseService`), orquestração de serviços de nuvem (Azure Blob, Queue, Table), envio de e-mails (SMTP/ThirdParty), gerenciamento de cache e os métodos de extensão de injeção de dependência (`IServiceCollection`) utilizados no bootstrap das aplicações host.

---

## 2. Tarefas e Entregáveis

| Item | Componente | Descrição | Status |
| ---- | ---------- | --------- | ------ |
| **SVC-01** | `EntityBaseService<,>` | Implementação base de serviço CRUD desacoplada com AutoMapper e `ServiceResponse<T>`. | ✅ Concluído |
| **SVC-02** | Azure Storage Adapters | Adaptadores para Blob, Queue e Table Storage com factories dedicadas. | ✅ Concluído |
| **SVC-03** | E-mail e SMTP | Contexto e estratégias de envio de e-mail (`SmtpEmailStrategy`, `ThirdPartyEmailStrategy`). | ✅ Concluído |
| **SVC-04** | Cache Orchestrator | Serviço centralizado `CacheService` com suporte a memória e disco. | ✅ Concluído |
| **SVC-05** | Adaptadores Transversais | `IAppLogger` (Serilog) e `IAppMapper` (AutoMapper) para abstração de bibliotecas externas. | ✅ Concluído |
| **SVC-06** | Extensions de DI (`Service/Configure`) | Módulos de registro no DI para Swagger, JWT, CORS, Logging, Caching, SMTP, etc. | ✅ Concluído |
| **SVC-07** | Testes Unitários | Testes unitários para todas as extensões de DI, serviços e adaptadores. | ✅ Concluído |

---

## 3. Diretrizes de Evolução e Manutenção

1. **Modularidade no DI:** Manter os métodos de extensão em `Service/Configure/` altamente granulares e independentes.
2. **Desacoplamento de Provedores:** Manter o padrão Factory/Strategy para serviços de e-mail e armazenamento em nuvem.
3. **Observabilidade:** Garantir logs adequados via `IAppLogger` nas operações críticas de infraestrutura.

---

## 4. Relações com Outros Documentos

- [Especificação - Service](./SmartDigitalPsico.Core.SDK.Especificacao.Service.md)
- [Plano de Implementação Geral](./SmartDigitalPsico.Core.SDK.PlanoImplementacao.md)
- [Progresso e Status](./SmartDigitalPsico.Core.SDK.Progresso.md)
