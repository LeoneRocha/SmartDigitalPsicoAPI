# SmartDigitalPsico.Core.SDK — Plano de Implementação: API

Plano de implementação, evolução e manutenção da camada **API** do `SmartDigitalPsico.Core.SDK`.

---

## 1. Escopo e Objetivos

A camada API centraliza as abstrações necessárias para construção de endpoints REST consistentes, tratamento automático de cabeçalhos de cultura (`Accept-Language`), extração facilitada de claims de autenticação e serialização padronizada de retornos.

---

## 2. Tarefas e Entregáveis

| Item | Componente | Descrição | Status |
| ---- | ---------- | --------- | ------ |
| **API-01** | `ApiBaseController` | Criação da classe base abstrata herdando de `ControllerBase` com helpers de resposta. | ✅ Concluído |
| **API-02** | Extração de Claims | Métodos protegidos para obter `UserId`, `UserEmail` e `UserRole` de forma segura. | ✅ Concluído |
| **API-03** | `LanguageActionFilterAttribute` | Filtro de ação para captura do header `Accept-Language` e definição de `CultureInfo`. | ✅ Concluído |
| **API-04** | Integração WebAPI | Validação de consumo pelos controllers em `SmartDigitalPsico.WebAPI`. | ✅ Concluído |
| **API-05** | Testes Unitários | Testes unitários para validação dos métodos de resposta e filtros. | ✅ Concluído |

---

## 3. Diretrizes de Evolução e Manutenção

1. **Assinaturas HTTP:** Manter total compatibilidade com `IActionResult` e tipos de retorno genéricos `ServiceResponse<T>`.
2. **Versionamento de API:** Suportar futuras expansões para API Versioning (`Asp.Versioning.Mvc`) sem introduzir breaking changes em `ApiBaseController`.
3. **Resiliência e Segurança:** Garantir que nenhum cabeçalho ou claim de autenticação cause `NullReferenceException` quando ausente.

---

## 4. Relações com Outros Documentos

- [Especificação - API](./SmartDigitalPsico.Core.SDK.Especificacao.API.md)
- [Plano de Implementação Geral](./SmartDigitalPsico.Core.SDK.PlanoImplementacao.md)
- [Progresso e Status](./SmartDigitalPsico.Core.SDK.Progresso.md)
