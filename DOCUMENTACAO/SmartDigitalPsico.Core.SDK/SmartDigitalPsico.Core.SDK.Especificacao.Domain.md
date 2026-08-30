# SmartDigitalPsico.Core.SDK — Especificação Técnica: Domain

Especificação técnica da camada **Domain** do pacote `SmartDigitalPsico.Core.SDK` (`SmartDigitalPsico.Core.SDK.Domain`).

---

## 1. Visão Geral

A camada Domain do SDK concentra os blocos de construção fundamentais do domínio, contratos de persistência, objetos de valor (VOs), DTOs compartilhados, modelos de hypermedia (HATEOAS), segurança, criptografia, geração de relatórios, resiliência e utilitários auxiliares (helpers).

---

## 2. Estrutura de Pastas

```text
SmartDigitalPsico.Core.SDK/
└── Domain/
    ├── Contracts/              # Entidades base e contratos de identidade
    ├── DTO/                    # DTOs de autenticação, relatórios, e-mail, etc.
    ├── Enuns/                  # Enumerações compartilhadas
    ├── Helpers/                # Métodos estáticos auxiliares (texto, data, cripto, etc.)
    ├── Hypermedia/             # HATEOAS, links, filtros e paginação
    ├── Interfaces/             # Contratos de repositórios, serviços e infraestrutura
    ├── Report/                 # Adaptadores de relatórios (QuestPDF, PDFsharp, OpenXML)
    ├── Resiliency/             # Políticas de resiliência e retry com Polly
    ├── Security/               # Criptografia AES/RSA e serviços de Token JWT
    ├── TableEntityNoSQL/       # Entidades base para Azure Table Storage
    ├── Validation/             # Helper de validações e códigos de erro padrão
    └── VO/                     # ServiceResponse, ErrorResponse, etc.
```

---

## 3. Especificação dos Componentes

### 3.1 Entidades Base e Contratos (`Domain/Contracts` e `Domain/Interfaces`)

#### `EntityBase`
Base para todas as entidades do banco de dados relacional.

```csharp
namespace SmartDigitalPsico.Core.SDK.Domain.Contracts
{
    public abstract class EntityBase : IEntityBase, IEntityBaseLog
    {
        public long Id { get; set; }
        public bool Enable { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? ModifyDate { get; set; }
        public DateTime? LastAccessDate { get; set; }
    }
}
```

#### Contratos Adicionais:
- `IEntityDto`, `IEntityDtoAdd`: Contratos para Data Transfer Objects com chave identificadora.
- `ITableBaseEntity`, `IStorageTableContract`: Contratos para persistência no Azure Table Storage.

---

### 3.2 Objetos de Valor e Respostas (`Domain/VO`)

#### `ServiceResponse<T>`
Padrão de encapsulamento de retorno para todas as operações da camada de serviço.

```csharp
namespace SmartDigitalPsico.Core.SDK.Domain.VO
{
    public class ServiceResponse<T> : IServiceResponse<T>
    {
        public T? Data { get; set; }
        public bool Success { get; set; } = true;
        public string Message { get; set; } = string.Empty;
        public List<ErrorResponse> Errors { get; set; } = new();
        public bool Unauthorized { get; set; } = false;
    }
}
```

#### `ErrorResponse`
Estrutura para detalhamento de erros e falhas de validação:
- `ErrorCode`: Código de erro padronizado.
- `ErrorMessage`: Mensagem descritiva traduzida ou chave de recurso.
- `FieldName`: Nome do campo associado (opcional).

---

### 3.3 Hypermedia e HATEOAS (`Domain/Hypermedia`)

- `HyperMediaLink`: Representa uma ação navegável (`Href`, `Rel`, `Action`, `Type`).
- `ISupportsHyperMedia`: Interface implementada por DTOs/VOs que suportam links REST.
- `ContentResponseEnricher<T>` / `IResponseEnricher`: Classes base para injeção automática de links nas respostas de API.
- `PagedSearchVO<T>`: Objeto de transporte para resultados paginados com metadados (`CurrentPage`, `PageSize`, `TotalResults`, `SortFields`, `SortDirections`, `List`).

---

### 3.4 Segurança e Criptografia (`Domain/Security`)

- **`CryptoService` / `CryptoAdapterFactory`:** Orquestrador desacoplado com suporte a múltiplos algoritmos criptográficos:
  - `AesCryptoAdpter`: Criptografia simétrica com chave AES 256-bit.
  - `RsaCryptoAdpter`: Criptografia assimétrica com chave pública/privada RSA.
- **`TokenService` (`ITokenService`):** Geração e validação de tokens JWT (`AccessToken`, `RefreshToken`), claims e tempos de expiração com base em `ITokenConfigurationDto`.

---

### 3.5 Geração de Relatórios (`Domain/Report`)

- **`ExcelGeneratorOpenXmlAdapter`:** Geração performática e nativa de planilhas `.xlsx` utilizando DocumentFormat.OpenXml, suportando múltiplas abas, estilos, auto-filtro e auto-fit de colunas.
- **`QuestPDFReportAdapter`:** Geração moderna e fluente de documentos PDF utilizando QuestPDF.
- **`PDFsharpMigraDocReportAdapter`:** Adaptador legado de PDF baseado em PDFsharp e MigraDoc.

---

### 3.6 Resiliência e Polly (`Domain/Resiliency`)

- **`ResiliencePolicies`:** Configuração centralizada de políticas de retry, circuit breaker e timeout para chamadas HTTP, Azure Storage e serviços externos.
- **`ResiliencePolicyConfig`:** Objeto de configuração para parâmetros de tentativas, intervalos de backoff exponencial e tempos limite.

---

### 3.7 Helpers e Utilitários (`Domain/Helpers`)

| Helper | Responsabilidade |
| ------ | ---------------- |
| `CharHelper` | Manipulação e validação de caracteres, limpeza de acentuação e normalização. |
| `CriptoHelper` | Utilitários de hash (SHA-256, SHA-512, MD5) e geração de chaves seguras. |
| `CultureHelper` | Conversão e validação de formatos culturais e datas/números regionalizados. |
| `DateHelper` | Manipulação de datas UTC, cálculos de idade e conversão de timestamps. |
| `DirectoryHelper` | Criação e sanitização segura de caminhos e diretórios de disco. |
| `FileHelper` | Leitura, escrita em streams, cálculo de MIME types e validação de extensões. |
| `SanitizeHelper` | Sanitização de strings e remoção de scripts maliciosos (XSS / HTML injection). |
| `TypeValidatorHelper` | Validação de tipos primitivos, enums e conversões seguras. |

---

## 4. Relações com Outros Documentos

- [Levantamento Técnico](./SmartDigitalPsico.Core.SDK.Levantamento.md)
- [Especificação - API](./SmartDigitalPsico.Core.SDK.Especificacao.API.md)
- [Especificação - Data](./SmartDigitalPsico.Core.SDK.Especificacao.Data.md)
- [Especificação - Service](./SmartDigitalPsico.Core.SDK.Especificacao.Service.md)
- [Plano de Implementação - Domain](./SmartDigitalPsico.Core.SDK.PlanoImplementacao.Domain.md)
