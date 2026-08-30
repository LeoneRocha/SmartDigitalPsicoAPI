# Plano de Implementação — SmartDigitalPsico.Core.SDK

> **Banner:** este plano operacional (2026-06) está **concluído / supersedido**. O estado atual do pacote e da migração está em [MigracaoGenericos.md](./SmartDigitalPsico.Core.SDK-MigracaoGenericos.md) e [Remocao-Shims.md](./SmartDigitalPsico.Core.SDK-Remocao-Shims.md). README NuGet: [`SmartDigitalPsico.Core.SDK/README.md`](../../../../SmartDigitalPsico.Core.SDK/README.md).
>
> **Complemento (2026-07-15):** extrações pendentes pós-migração executadas — ver [Extracao-Pendencias.md](./SmartDigitalPsico.Core.SDK-Extracao-Pendencias.md).

**Documento:** Plano de execução operacional (histórico)  
**Baseado em:** [SmartDigitalPsico.Core.SDK-Especificacao.md](./SmartDigitalPsico.Core.SDK-Especificacao.md)  
**Data:** 2026-06-07  
**Restrição absoluta (da época):** não mover, alterar ou apagar código existente no backend; apenas criar novos arquivos em `SmartDigitalPsico.Core.SDK/`.

---

## 1. Objetivo operacional

Entregar o pacote NuGet `SmartDigitalPsico.Core.SDK` em **PRs pequenos e revisáveis**, validando build e testes a cada fase antes de avançar.

Ordem de execução:

1. Documentação (spec + plano)
2. Scaffold do projeto (`.csproj`, LICENSE, solução)
3. Módulos fundacionais (`Result`, `EntityBase`) + testes
4. Abstrações e utilitários (Tier A)
5. Infraestrutura SDK (Tier B)
6. Domain avançado e helpers (Tier C)
7. CI build + test
8. CI publish NuGet

---

## 2. Inventário e premissas técnicas

### 2.1 Localização do projeto

O Core.SDK fica **dentro de ``**, na pasta **`core`**, separada dos SDKs de feature em `SDKs/`:

```text
SmartDigitalPsicoAPI/
├── 
│   ├── SmartDigitalPsicoAPI.sln
│   ├── Directory.Build.props
│   ├── Directory.Packages.props
│   ├── Implementations/
│   │   ├── Implementations/SmartDigitalPsico.Domain/
│   │   └── Implementations/SmartDigitalPsico.Service/
│   ├── SDKs/
│   │   ├── SmartDigitalPsico.Localization.SDK/      # referência de convenções NuGet
│   │   ├── SmartDigitalPsico.Localization.SDK.Tests/
│   │   ├── SmartDigitalPsico.ClientSDK/
│   │   └── SmartDigitalPsico.ClientSDK.Tests/
│   └── Core/
│       ├── SmartDigitalPsico.Core.SDK/              # novo
│       └── SmartDigitalPsico.Core.SDK.Tests/        # novo
└── Documentation/Features/
    ├── SmartDigitalPsico.Core.SDK-Especificacao.md
    └── SmartDigitalPsico.Core.SDK-PlanoImplementacao.md
```

**Referências na solução:**

```text
Project = "SmartDigitalPsico.Core.SDK", "SmartDigitalPsico.Core.SDK\SmartDigitalPsico.Core.SDK.csproj"
Project = "SmartDigitalPsico.Core.SDK.Tests", "SmartDigitalPsico.Core.SDK.Tests\SmartDigitalPsico.Core.SDK.Tests.csproj"
```

Ambos aninhados na pasta virtual **Core** de `SmartDigitalPsicoAPI.sln` (distinta da pasta virtual **SDKs**).

### 2.2 Referência de empacotamento

Espelhar integralmente:

- [SDKs/SmartDigitalPsico.Localization.SDK/SmartDigitalPsico.Localization.SDK.csproj](../../../../SDKs/SmartDigitalPsico.Localization.SDK/SmartDigitalPsico.Localization.SDK.csproj)
- [Documentation/Features/FEITOS/SDK/SmartDigitalPsico.Localization.SDK-Requisitos.md](../SDK/SmartDigitalPsico.Localization.SDK-Requisitos.md)

O Core.SDK reutiliza `Directory.Build.props` e `Directory.Packages.props` — **não** cria arquivos de build separados fora de ``.

### 2.3 Stack de testes

| Pacote | Uso |
| ------ | --- |
| xUnit | Framework de testes (Core.SDK) |
| FluentAssertions | Asserts legíveis |
| Moq | Isolamento |
| coverlet.collector | Cobertura |

---

## 3. Estratégia de entrega (fases e PRs)

| Fase | PR | Escopo | Critério de aceite | Estimativa |
| ---- | -- | ------ | ----------------- | ---------- |
| **0** | — | Spec + plano (este documento) | Markdown revisado | Concluído |
| **1** | PR-1 | Scaffold: `.csproj`, LICENSE, GlobalUsings, solução | `dotnet build` OK | 0,5 dia |
| **2** | PR-2 | `Result`/`Error` + `EntityBase` + testes | `dotnet test` verde | 1 dia |
| **3** | PR-3 | `IClock`, `IAppLogger`, `Guard`, `ParallelOptionsHelper` | Build + test verde | 1 dia |
| **4** | PR-4 | HTTP/Cache/Auth (Tier B) | `dotnet pack` sem warnings | 2 dias |
| **5** | PR-5 | `ValueObject`, `AuditableEntity`, exceções base | XML docs gerada | 2 dias |
| **6** | PR-6 | `StringHelper`, `DateTimeHelper`, Extensions | ≥ 90% cobertura módulos entregues | 2 dias |
| **7** | PR-7 | Pipeline CI build + test | YAML/checklist documentado | 1 dia |
| **8** | PR-8 | Pipeline publish NuGet | Pacote no feed interno | 1 dia |

**Total estimado:** 10–11 dias úteis (1 dev).

---

## 4. Fase 1 — Scaffold (PR-1)

### 4.1 Tarefas

- [ ] Criar `SmartDigitalPsico.Core.SDK/SmartDigitalPsico.Core.SDK.csproj` (multi-TFM, metadados NuGet)
- [ ] Criar `SmartDigitalPsico.Core.SDK.Tests/SmartDigitalPsico.Core.SDK.Tests.csproj`
- [ ] Copiar `LICENSE` de `SmartDigitalPsico.Localization.SDK`
- [ ] Criar `GlobalUsings.cs` e `README.md`
- [ ] Adicionar projetos à `SmartDigitalPsicoAPI.sln` (pasta virtual **Core**)
- [ ] Adicionar pacotes xUnit em `Directory.Packages.props` (se ainda não existirem)

### 4.2 Comandos de validação

```powershell
cd c:\git\repos\SmartDigitalPsico\backend
dotnet build SmartDigitalPsico.Core.SDK\SmartDigitalPsico.Core.SDK.csproj -c Release
```

### 4.3 Critério de aceite

- Build Release sem erros em todos os TFMs
- Projetos visíveis na solução, agrupados em **core**

---

## 5. Fase 2 — Fundação (PR-2)

### 5.1 Arquivos

| Arquivo | Descrição |
| ------- | --------- |
| `SmartDigitalPsico.Core.SDK/Common/Error.cs` | Record com Code, Message, Metadata |
| `SmartDigitalPsico.Core.SDK/Common/Result.cs` | Result + Result&lt;T&gt; |
| `SmartDigitalPsico.Core.SDK/Domain/EntityBase.cs` | Adaptado de BaseEntity (Guid Id) |
| `SmartDigitalPsico.Core.SDK.Tests/Common/ResultTests.cs` | Sucesso, falha, múltiplos erros, acesso a Value |
| `SmartDigitalPsico.Core.SDK.Tests/Domain/EntityBaseTests.cs` | Igualdade, Activate/Deactivate |

### 5.2 Comandos

```powershell
cd c:\git\repos\SmartDigitalPsico\backend
dotnet test SmartDigitalPsico.Core.SDK.Tests\SmartDigitalPsico.Core.SDK.Tests.csproj -c Release
```

### 5.3 Critério de aceite

- Todos os testes passam
- Cobertura dos dois módulos implementados

---

## 6. Fase 3 — Abstrações Tier A (PR-3)

Copiar/adaptar (originais intactos em `SmartDigitalPsico.Domain`):

| Origem | Destino |
| ------ | ------- |
| `Implementations/SmartDigitalPsico.Domain/Interfaces/Common/IClock.cs` | `SmartDigitalPsico.Core.SDK/Abstractions/IClock.cs` |
| `Implementations/SmartDigitalPsico.Domain/Interfaces/Common/IAppLogger.cs` | `SmartDigitalPsico.Core.SDK/Logging/IAppLogger.cs` |
| Rascunho Guard | `SmartDigitalPsico.Core.SDK/Validation/Guard.cs` |
| `Implementations/SmartDigitalPsico.Domain/Helpers/ParallelOptionsHelper.cs` | `SmartDigitalPsico.Core.SDK/Helpers/ParallelOptionsHelper.cs` |

Testes unitários para cada módulo.

---

## 7. Fase 4 — Infraestrutura SDK Tier B (PR-4)

Copiar/adaptar de Localization.SDK e ClientSDK:

- `SmartDigitalPsico.Core.SDK/Http/HttpHeaderNamesHelper.cs`
- `SmartDigitalPsico.Core.SDK/Abstractions/IAuthHeaderProvider.cs`
- `SmartDigitalPsico.Core.SDK/Authentication/ApiKeyAuthHeaderProvider.cs`
- `SmartDigitalPsico.Core.SDK/Abstractions/IApiErrorMapper.cs`
- `SmartDigitalPsico.Core.SDK/Caching/MemoryCacheProvider.cs`
- `SmartDigitalPsico.Core.SDK/Http/HttpRequestExecutorBase.cs` (extrair de BaseHttpService)
- `SmartDigitalPsico.Core.SDK/Polyfills/IsExternalInit.cs`

Validação:

```powershell
cd c:\git\repos\SmartDigitalPsico\backend
dotnet pack SmartDigitalPsico.Core.SDK\SmartDigitalPsico.Core.SDK.csproj -c Release --no-build
```

---

## 8. Fase 5 — Domain avançado (PR-5)

- `SmartDigitalPsico.Core.SDK/Domain/ValueObject.cs`
- `SmartDigitalPsico.Core.SDK/Domain/AuditableEntity.cs` (string CreatedBy/UpdatedBy, sem entidade User)
- `SmartDigitalPsico.Core.SDK/Exceptions/SmartDigitalPsicoSdkException.cs` + hierarquia base

---

## 9. Fase 6 — Helpers e Extensions (PR-6)

Implementar conforme spec:

- `StringHelper` / `StringExtensions` (Normalize, Slugify, MaskDocument, etc.)
- `DateTimeHelper` / `DateTimeExtensions` (UTC, StartOfDay, CalculateAge, etc.)

Meta: ≥ 90% cobertura com `[Theory]` / `[InlineData]`.

---

## 10. Fase 7 — CI build + test (PR-7)

Reutilizar padrão de Localization.SDK:

- Restore → Build (multi-TFM) → Test → (sem pack/publish inicialmente)
- Documentar steps em checklist Azure DevOps / GitHub Actions
- Referência: [Documentation/Features/FEITOS/AZURE-PIPELINE-LOCALIZATION-CHECKLIST.md](../AZURE-PIPELINE-LOCALIZATION-CHECKLIST.md)

### Checklist CI inicial

- [ ] Job `build-core-sdk` na pipeline existente ou pipeline dedicada
- [ ] `dotnet restore` na solução `SmartDigitalPsicoAPI.sln`
- [ ] `dotnet build SmartDigitalPsico.Core.SDK/SmartDigitalPsico.Core.SDK.csproj -c Release` multi-TFM
- [ ] `dotnet test SmartDigitalPsico.Core.SDK.Tests/SmartDigitalPsico.Core.SDK.Tests.csproj -c Release --no-build`
- [ ] Artefato de cobertura (opcional)

---

## 11. Fase 8 — CI publish NuGet (PR-8)

- `dotnet pack` após build completo
- Push para feed interno (mesmos secrets do Localization.SDK)
- Referência: [Documentation/Features/FEITOS/NUGET-PUBLISH-POWERSHELL-ONLY.md](../NUGET-PUBLISH-POWERSHELL-ONLY.md)

---

## 12. Migração gradual (pós-estabilização)

Ordem sugerida de adoção pelos consumidores:

1. `SmartDigitalPsico.Localization.SDK` — referenciar Core.SDK; remover duplicatas (HttpHeaderNamesHelper, ICacheProvider, etc.)
2. `SmartDigitalPsico.CloudClientSDK` — referenciar Core.SDK; extrair BaseHttpService
3. `SmartDigitalPsico.Domain` — avaliar substituição de BaseEntity/IClock por tipos Core (breaking change interno)
4. Demais camadas — fase a fase conforme aprovação

**Regra:** cada migração em PR separado; nunca alterar originais e consumidor no mesmo PR.

---

## 13. Riscos e mitigações

| Risco | Mitigação |
| ----- | --------- |
| Divergência `Guid` vs `long` Id | Documentar; `EntityBase` futuro |
| Duplicação temporária | Esperado até migração; catalogar em spec |
| Multi-TFM netstandard | Polyfills (`IsExternalInit`); testes em net10.0 |
| Breaking changes acidentais | SemVer rigoroso; changelog no pacote |

---

## 14. Comandos úteis (referência rápida)

```powershell
cd c:\git\repos\SmartDigitalPsico\backend

# Build
dotnet build SmartDigitalPsico.Core.SDK\SmartDigitalPsico.Core.SDK.csproj -c Release

# Test
dotnet test SmartDigitalPsico.Core.SDK.Tests\SmartDigitalPsico.Core.SDK.Tests.csproj -c Release

# Pack
dotnet build SmartDigitalPsico.Core.SDK\SmartDigitalPsico.Core.SDK.csproj -c Release
dotnet pack SmartDigitalPsico.Core.SDK\SmartDigitalPsico.Core.SDK.csproj -c Release --no-build
```

---

## 15. Status atual

| Item | Status |
| ---- | ------ |
| Documentação spec + plano | Concluído |
| Localização definida (`Core/`) | Concluído |
| Scaffold projeto | Pendente |
| Fase 2 (Result + EntityBase) | Pendente |
| Fases 3–8 | Pendente |
