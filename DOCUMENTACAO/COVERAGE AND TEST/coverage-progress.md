# Coverage Progress — SmartDigitalPsicoAPI

## Meta
- **100% literal** de linhas e ramos (sem exclusões Sonar/Coverlet).
- Escopo: Domain, Data, Service, WebAPI, WebJob, WindowsService.
- Convenções: NUnit, Moq, Bogus, AwesomeAssertions; nomes `Metodo_Cenario_Resultado`; `// Cenário:` / `// Objetivo:`; AAA.

## Como medir

```bash
cd C:\git\SMARTDIGITALPSICO\SmartDigitalPsicoAPI
dotnet build SmartDigitalPsicoAPI.sln
dotnet test SmartDigitalPsicoAPI.sln /p:CollectCoverage=true /p:CoverletOutputFormat=cobertura /p:CoverletOutput=coverage/
```

Relatórios por projeto: `*/coverage/coverage.cobertura.xml`.

## Tabela de fases

| Fase | Projeto | Escopo | Status | Line% | Branch% | Atualizado em |
|------|---------|--------|--------|-------|---------|---------------|
| 0 | — | Fundação (tooling + este doc) | Concluída | — | — | 2026-08-03 |
| 1 | Domain | Helpers, Security, Resiliency, AppException, Constants, Events, Mapper, Report, API | Concluída | 100% | 100% | 2026-08-03 |
| 2 | Domain | Validation | Concluída | 100% | 100% | 2026-08-03 |
| 3 | Domain | DTO, VO, Enums, EntityModels, Hypermedia, DI, Contracts | Concluída | 100% | 100% | 2026-08-03 |
| 4 | Data | Repositories | Concluída | 100% | 100% | 2026-08-03 |
| 5 | Data | Context / Configure / Audit | Concluída | 100% | 100% | 2026-08-03 |
| 6 | Data | Migrations | Concluída | 100% | 100% | 2026-08-03 |
| 7 | Service | Bussines + DataEntity | Concluída | 100% | 100% | 2026-08-03 |
| 8 | Service | Configure + Infrastructure | Concluída | 100% | 100% | 2026-08-03 |
| 9 | Service | Audit + Report + Security | Concluída | 100% | 100% | 2026-08-03 |
| 10 | WebAPI | Controllers + Configure | Concluída | 100% | 100% | 2026-08-03 |
| 11 | WebJob + WindowsService | Hosts | Concluída | 100% | 100% | 2026-08-03 |
| 12 | Global | Merge 100% | Concluída | 100% | 100% | 2026-08-03 |
| 13 | Todos `*.Test` | Padronização AAA + Cenário/Objetivo | Concluída | — | — | 2026-08-04 |

## Resultado final por assembly (Coverlet)

| Assembly | Line | Branch | Method | Testes |
|----------|------|--------|--------|--------|
| SmartDigitalPsico.Domain | 100% | 100% | 100% | Domain.Test |
| SmartDigitalPsico.Data | 100% | 100% | 100% | Data.Test |
| SmartDigitalPsico.Service | 100% | 100% | 100% | Service.Test |
| SmartDigitalPsico.WebAPI | 100% | 100% | 100% | WebAPI.Test |
| SmartDigitalPsico.WebJob | 100% | 100% | 100% | WebJob.Test |
| SmartDigitalPsico.WindowsService | 100% | 100% | 100% | WindowsService.Test |

## Checklist por fase

### Fase 0
- [x] AwesomeAssertions + coverlet.msbuild em Directory.Packages.props
- [x] Referências nos projetos `*.Test`
- [x] Baseline Coverlet registrada

### Fase 1 — Domain utilitário
- [x] Helpers/ (+ Schedule, Medical, Security)
- [x] Security/, Resiliency/, AppException/
- [x] Constants/, Events/, Mapper/, Report/, API/

### Fase 2 — Domain Validation
- [x] Validation/SystemDomains
- [x] Validation/Principals
- [x] Validation/PatientValidations
- [x] Validation/Schedule + demais

### Fase 3 — Domain modelos
- [x] DTO/, VO/, Enuns/
- [x] EntityModels/, TableEntityNoSQL/, Hypermedia/
- [x] DependeciesCollection/, Contracts/
- [x] Interfaces (N/A — sem IL)

### Fase 4–6 — Data
- [x] Repository/ + TableEntityRepository/
- [x] Context/ + Audit/
- [x] Migrations/

### Fase 7–9 — Service
- [x] Service.Test criado
- [x] Bussines + DataEntity
- [x] Configure + Infrastructure
- [x] Audit + Report + Security

### Fase 10–11 — Hosts
- [x] WebAPI.Test
- [x] WebJob.Test + WindowsService.Test

### Fase 12
- [x] Coverlet 100% line + branch por assembly
- [x] Build e testes verdes

### Fase 13 — Padronização AAA e documentação
- [x] Todo `[Test]`/`[TestCase]` com `// Cenário:` e `// Objetivo:`
- [x] Corpo com `// Arrange`, `// Act`, `// Assert`
- [x] Audit automatizado: 0 gaps nos 6 projetos (815 métodos)
- [x] `dotnet test SmartDigitalPsicoAPI.sln -c Release` verde (1281 passed, 5 skipped Azurite)

## Gaps Coverlet (última medição)

Nenhum — 100% line e branch em todos os assemblies de produção.

## Histórico de baselines

| Data | Observação | Domain Line | Data Line | Service Line | WebAPI Line | Hosts Line |
|------|------------|-------------|-----------|--------------|-------------|------------|
| 2026-08-03 | Baseline pós-Fase 0 (4 Domain + 69 Data tests) | 0.38% | 3.19% | — | — | — |
| 2026-08-03 | Domain/Data em progresso | 97.4% | 99.21% | 17% | 86% | parcial |
| 2026-08-03 | **Meta atingida — 100% literal line+branch** | 100% | 100% | 100% | 100% | 100% |
| 2026-08-04 | Padronização AAA/docs em todos os `*.Test` | 100% | 100% | 100% | 100% | 100% |
