# SmartDigitalPsico.Core.SDK — Plano de Implementação: Domain

Plano de implementação, evolução e manutenção da camada **Domain** do `SmartDigitalPsico.Core.SDK`.

---

## 1. Escopo e Objetivos

A camada Domain estabelece os contratos essenciais, classes base, estruturas de resposta padronizada, mecanismos de hypermedia (HATEOAS), segurança/criptografia, resiliência e geração de documentos (PDF e Excel).

---

## 2. Tarefas e Entregáveis

| Item | Componente | Descrição | Status |
| ---- | ---------- | --------- | ------ |
| **DOM-01** | `EntityBase` & Interfaces | Definição dos contratos `IEntityBase`, `IEntityBaseLog` e classe base com `long Id`. | ✅ Concluído |
| **DOM-02** | `ServiceResponse<T>` & VOs | Estruturas padronizadas de transporte de dados e tratamento de erros (`ErrorResponse`). | ✅ Concluído |
| **DOM-03** | Hypermedia (HATEOAS) | Filtros, enrichers e modelos de links REST para enriquecimento dinâmico de respostas. | ✅ Concluído |
| **DOM-04** | Criptografia & Tokens | Implementação de AES, RSA (`CryptoService`) e geração de JWTs (`TokenService`). | ✅ Concluído |
| **DOM-05** | Geração de Relatórios | Adaptadores de relatórios Excel (OpenXML) e PDF (QuestPDF e PDFsharp). | ✅ Concluído |
| **DOM-06** | Resiliência (Polly) | Políticas de retry, fallback e circuit breaker centralizadas (`ResiliencePolicies`). | ✅ Concluído |
| **DOM-07** | Helpers Utilitários | Conjunto de classes utilitárias para manipulação de strings, datas, arquivos, diretórios e sanitização. | ✅ Concluído |
| **DOM-08** | Testes Unitários | Testes unitários cobrindo criptografia, helpers, hypermedia e relatórios. | ✅ Concluído |

---

## 3. Diretrizes de Evolução e Manutenção

1. **Pureza do Domínio Core:** Não introduzir dependências de regras de negócio específicas da aplicação médica/psicológica no SDK.
2. **Imutabilidade e Thread Safety:** Garantir que os helpers e serviços de criptografia/token sejam thread-safe.
3. **Desempenho de Relatórios:** Manter as rotinas de geração OpenXML e QuestPDF otimizadas para processamento em streams assíncronos.

---

## 4. Relações com Outros Documentos

- [Especificação - Domain](./SmartDigitalPsico.Core.SDK.Especificacao.Domain.md)
- [Plano de Implementação Geral](./SmartDigitalPsico.Core.SDK.PlanoImplementacao.md)
- [Progresso e Status](./SmartDigitalPsico.Core.SDK.Progresso.md)
