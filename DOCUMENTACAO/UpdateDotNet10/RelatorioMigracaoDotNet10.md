# Relatório de Migração — SmartDigitalPsicoAPI para .NET 10

**Status:** CONCLUÍDO (código migrado; Docker daemon indisponível no ambiente; smoke hosts não executados)  
**Data da execução:** 2026-08-01  
**Branch:** `developer` (trabalho local; branch planejada `chore/update-packages-smartdigitalpsicoapi-dotnet10` não criada nesta sessão)  
**Solução:** `SmartDigitalPsicoAPI/SmartDigitalPsicoAPI.sln`  
**SDK usado:** `.NET SDK 10.0.301` (`global.json` com `rollForward: latestFeature`)  
**Documentos de origem:**

- `DOCUMENTACAO/UpdateDotNet10/RascunhoPlanoUpdateDotNet10.md`
- `DOCUMENTACAO/UpdateDotNet10/PlanoAcaoMigracaoDotNet10.md`
- `DOCUMENTACAO/API/2026-07-LevantamentoConjuntoHomologado-SmartDigitalPsicoAPI.md`
- `DOCUMENTACAO/API/PlanoImplementacaoMigracaoDotNet10-SmartDigitalPsicoAPI.md`

---

## 1. Objetivo

Registrar a execução da migração SmartDigitalPsicoAPI de .NET 8 para .NET 10:

- TFM `net10.0` nos 8 projetos C#
- CPM via `Directory.Packages.props` (Conjunto Homologado v1)
- Remoção de `MySql.EntityFrameworkCore` (dead reference)
- Validação de build, testes NUnit, migrations, Docker e smoke dos hosts

---

## 2. Escopo executado

| Projeto | TFM final |
| ------- | --------- |
| SmartDigitalPsico.Domain | net10.0 |
| SmartDigitalPsico.Data | net10.0 |
| SmartDigitalPsico.Service | net10.0 |
| SmartDigitalPsico.WebAPI | net10.0 |
| SmartDigitalPsico.WindowsService | net10.0 |
| SmartDigitalPsico.WebJob | net10.0 |
| SmartDigitalPsico.Domain.Test | net10.0 |
| SmartDigitalPsico.Data.Test | net10.0 |

Fora do ciclo: frontend/npm; introdução de stack AI; commit/PR automático.

---

## 3. Gerenciamento de Pacotes NuGet

Arquivo: `SmartDigitalPsicoAPI/Directory.Packages.props`

| Bloco | Versões aplicadas |
| ----- | ----------------- |
| A — Plataforma | AspNetCore JwtBearer / Extensions / Hosting / System.Text.Json **10.0.10** |
| B — Persistência | EF **9.0.18** + Pomelo **9.0.0** + SqlServer/InMemory **9.0.18** |
| C — OpenAPI / logs / tokens | Swashbuckle **10.2.3**, Serilog.AspNetCore / Extensions.Hosting **10.0.0** |
| D — Azure / utils | AutoMapper **16.2.0**, Azure.*, Graph **5.105.0**, etc. |
| E — Testes | Moq.EF **9.0.0.10**, NUnit*, coverlet |

**Remoções:**

- [x] `MySql.EntityFrameworkCore` removido do grafo (`SmartDigitalPsico.Data.csproj`); usings órfãos `MySqlX.XDevAPI.Common` removidos em `MedicalFileService` / `PatientRecordService`

**Desvios do Conjunto v1:**

- Nenhum desvio de versão. Avisos residuais NU1510 (pacotes framework já incluídos no net10) e NU190x transitivos (`AngleSharp` via HtmlSanitizer, `Microsoft.Kiota.Abstractions` via Graph) — fora do pin do Conjunto v1.

---

## 4. Ajustes técnicos realizados

| Área | Ajuste |
| ---- | ------ |
| Swashbuckle 10 / OpenAPI 2.x | `using Microsoft.OpenApi.Models` → `Microsoft.OpenApi` em `ServiceCollectionConfigureDocumentation.cs` |
| AutoMapper 16 | `AddAutoMapper` com `Action<IMapperConfigurationExpression>` + `AddMaps` para `AutoMapperProfile` e `ScheduleBatchProfile` (licença via env `AUTOMAPPER_LICENSE_KEY` / `LUCKYPENNY_LICENSE_KEY` se necessário) |
| EF 9 + Pomelo 9 | Bloco B sem drift; DI continua Pomelo `UseMySql` |
| Docker aspnet/sdk 10.0 | Dockerfiles raiz e WebAPI atualizados |
| Outros | CPM; `global.json`; README SDK 10; remoção dead Oracle MySQL EF |

---

## 5. Validações

### SDK

```text
6.0.428
8.0.416
9.0.314
10.0.300
10.0.301   ← pin em global.json
```

### Build Release

| Item | Resultado |
| ---- | --------- |
| Erros | **0** |
| Restore `NU1107` / `NU1202` | Nenhum |
| Drift EF / Pomelo | Nenhum (9.0.18 / 9.0.0) |

### Testes

| Item | Resultado |
| ---- | --------- |
| Domain.Test | 4/4 OK |
| Data.Test | 70/70 OK |
| Total passando | **74/74** |

### Migrations / Smoke hosts / Docker

| Item | Resultado |
| ---- | --------- |
| Migration `ValidacaoPosUpdateDotNet10` | **Mantida** (`20260801145150`). Conteúdo: **184× `UpdateData`** (timestamps de seed via `DateHelper.GetDateTimeNowFromUtc()` em HasData). **Sem DDL** (Create/Alter/Drop). |
| `database update` MySQL | **OK** (Development → `smartdigitalpsi`; migration aplicada e listada) |
| `database update` SqlServer | Não executado (connection string vazia; TypeDataBase=MySQL) |
| Smoke WebAPI / JWT | Não executado |
| Smoke WindowsService | Não executado |
| Smoke WebJob | Não executado |
| Dockerfiles | Revisados: imagens **10.0**, restore com CPM/`global.json`, `ASPNETCORE_URLS=http://+:80`, `TZ=`, certificado no stage final |
| Docker build 10.0 | Daemon Docker Desktop **ainda off** nesta máquina — build não validado; imagens/tags no Dockerfile OK |

---

## 6. Resultados pós-migração

```text
Data da execução: 2026-08-01 (revisão + EF update)
Branch: developer (local)
SDK usado: 10.0.301
Build Release: OK (0 erros)
Testes: 74/74 OK
Migrations: ValidacaoPosUpdateDotNet10 add + database update MySQL OK (só UpdateData seeds)
Smoke WebAPI / JWT / workers: não executado
Docker 10.0: Dockerfiles revisados (aspnet/sdk 10.0)
MySql.EntityFrameworkCore removido: sim
Desvios do Conjunto v1: nenhum
```

### Quantitativo

```text
Projetos .NET atualizados: 8 / 8
Pacotes NuGet alinhados ao Conjunto v1: sim (Directory.Packages.props)
Testes automatizados: 74/74
Vulnerabilidades resolvidas: NU1903 AutoMapper 14 → 16.2.0; residual HtmlSanitizer/AngleSharp/Kiota transitivos
Falhas de compile encontradas/corrigidas: 3 (OpenAPI Models; 2× MySqlX orphan usings) + AutoMapper DI API
Migrations validadas: técnica temporária MySQL OK (sem DDL)
```

---

## 7. Infraestrutura e CI

| Item | Status |
| ---- | ------ |
| `global.json` | Criado (`10.0.301`, `rollForward: latestFeature`) |
| README (.NET SDK) | Atualizado para SDK 10 / .NET 10 |
| Dockerfile raiz | `aspnet:10.0` / `sdk:10.0` |
| Dockerfile WebAPI | `aspnet:10.0` / `sdk:10.0` |
| Azure DevOps UseDotNet | **Pendente externo** — `azure-pipelines.yml` in-repo continua stub; pipeline real deve usar `UseDotNet@2` com `10.x` |

---

## 8. Riscos residuais

| Risco | Status |
| ----- | ------ |
| Pomelo 9 → EF 9 (sem EF 10) | Aceito no v1 |
| AutoMapper 16 / licença | Monitorar (env key / dual license); DI ajustado |
| Dual SqlServer/MySQL | Validar `database update` em homolog |
| Pipeline DevOps desalinhado | Atualizar UseDotNet 10.x no Azure DevOps |
| WebJobs + Hosting 10 | Validar smoke WebJob |
| Seeds com DateTime dinâmico | Drift em `ef migrations add` — considerar datas fixas em `HasData` |

---

## 9. Conclusão

Migração de código **concluída** conforme Conjunto Homologado v1: TFM `net10.0`, CPM, remoção do Oracle MySQL EF, Swashbuckle 10 / AutoMapper 16 ajustados, build e **74 testes** verdes. Infra docs (Dockerfiles, `global.json`, README) alinhados ao SDK 10. Pendências operacionais: Docker build com daemon ativo, smoke dos hosts, `database update` em homolog e alinhamento do pipeline Azure DevOps externo.

---

## 10. Referências

- `DOCUMENTACAO/GuiaGenericoAtualizacaoPacotes.md`
- `DOCUMENTACAO/UpdateDotNet10/PlanoAcaoMigracaoDotNet10.md`
- `DOCUMENTACAO/UpdateDotNet10/RascunhoPlanoUpdateDotNet10.md`
- `DOCUMENTACAO/API/2026-07-LevantamentoConjuntoHomologado-SmartDigitalPsicoAPI.md`
- `DOCUMENTACAO/API/PlanoImplementacaoMigracaoDotNet10-SmartDigitalPsicoAPI.md`
- Pomelo EF Core 10 tracking: https://github.com/PomeloFoundation/Pomelo.EntityFrameworkCore.MySql/issues/2007
- Swashbuckle v10: https://github.com/domaindrivendev/Swashbuckle.AspNetCore/blob/master/docs/migrating-to-v10.md
