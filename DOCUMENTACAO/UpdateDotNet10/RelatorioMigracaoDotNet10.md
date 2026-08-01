# Relatório de Migração — SmartDigitalPsicoAPI para .NET 10

**Status:** PENDENTE (não executado)  
**Data da execução:** _a preencher_  
**Branch:** `chore/update-packages-smartdigitalpsicoapi-dotnet10`  
**Solução:** `SmartDigitalPsicoAPI/SmartDigitalPsicoAPI.sln`  
**SDK usado:** _a preencher_ (esperado `.NET SDK 10.0.x` com `global.json` e `rollForward: latestFeature`)  
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
| SmartDigitalPsico.Domain | _pendente_ |
| SmartDigitalPsico.Data | _pendente_ |
| SmartDigitalPsico.Service | _pendente_ |
| SmartDigitalPsico.WebAPI | _pendente_ |
| SmartDigitalPsico.WindowsService | _pendente_ |
| SmartDigitalPsico.WebJob | _pendente_ |
| SmartDigitalPsico.Domain.Test | _pendente_ |
| SmartDigitalPsico.Data.Test | _pendente_ |

Fora do ciclo: frontend/npm; introdução de stack AI.

---

## 3. Gerenciamento de Pacotes NuGet

Arquivo previsto: `SmartDigitalPsicoAPI/Directory.Packages.props`

| Bloco | Versões aplicadas |
| ----- | ----------------- |
| A — Plataforma | AspNetCore JwtBearer / Extensions / Hosting / System.Text.Json **10.0.10** — _pendente confirmação_ |
| B — Persistência | EF **9.0.18** + Pomelo **9.0.0** + SqlServer/InMemory **9.0.18** — _pendente_ |
| C — OpenAPI / logs / tokens | Swashbuckle **10.2.3**, Serilog.AspNetCore / Extensions.Hosting **10.0.0** — _pendente_ |
| D — Azure / utils | AutoMapper **16.2.0**, Azure.*, Graph **5.105.0**, etc. — _pendente_ |
| E — Testes | Moq.EF **9.0.0.10**, NUnit*, coverlet — _pendente_ |

**Remoções:**

- [ ] `MySql.EntityFrameworkCore` removido do grafo

**Desvios do Conjunto v1:**

- _listar aqui durante a execução_

---

## 4. Ajustes técnicos realizados

| Área | Ajuste |
| ---- | ------ |
| Swashbuckle 10 / OpenAPI 2.x | _pendente_ |
| AutoMapper 16 | _pendente_ |
| EF 9 + Pomelo 9 | _pendente_ |
| Docker aspnet/sdk 10.0 | _pendente_ |
| Outros | _pendente_ |

---

## 5. Validações

### SDK

```text
_a preencher: saída de dotnet --list-sdks_
```

### Build Release

| Item | Resultado |
| ---- | --------- |
| Erros | _pendente_ |
| Restore `NU1107` / `NU1202` | _pendente_ |
| Drift EF / Pomelo | _pendente_ |

### Testes

| Item | Resultado |
| ---- | --------- |
| Domain.Test | _pendente_ |
| Data.Test | _pendente_ |
| Total passando | _pendente_ N/N |

### Migrations / Smoke hosts / Docker

| Item | Resultado |
| ---- | --------- |
| Migration temporária `ValidacaoPosUpdateDotNet10` | _pendente_ |
| `database update` (SqlServer / MySQL) | _pendente_ |
| Smoke WebAPI / JWT | _pendente_ |
| Smoke WindowsService | _pendente_ |
| Smoke WebJob | _pendente_ |
| Docker build 10.0 | _pendente_ |

---

## 6. Resultados pós-migração

```text
Data da execução: _
Branch: chore/update-packages-smartdigitalpsicoapi-dotnet10
SDK usado: _
Build Release: _
Testes: _
Migrations: _
Smoke WebAPI / JWT / workers: _
Docker 10.0: _
MySql.EntityFrameworkCore removido: _
Desvios do Conjunto v1: _
```

### Quantitativo

```text
Projetos .NET atualizados: _ / 8
Pacotes NuGet alinhados ao Conjunto v1: _
Testes automatizados: _/_
Vulnerabilidades resolvidas: _
Falhas de build encontradas/corrigidas: _
Migrations validadas: _
```

---

## 7. Infraestrutura e CI

| Item | Status |
| ---- | ------ |
| `global.json` | _pendente_ |
| README (.NET SDK) | _pendente_ |
| Dockerfile raiz | _pendente_ (`aspnet:10.0` / `sdk:10.0`) |
| Dockerfile WebAPI | _pendente_ |
| Azure DevOps UseDotNet | _pendente (fora do tree / stub in-repo)_ |

---

## 8. Riscos residuais

| Risco | Status |
| ----- | ------ |
| Pomelo 9 → EF 9 (sem EF 10) | Aceito no v1 |
| AutoMapper 16 / licença | _monitorar_ |
| Dual SqlServer/MySQL | _validar em homolog_ |
| Pipeline DevOps desalinhado | _pendente_ |
| WebJobs + Hosting 10 | _validar_ |

---

## 9. Conclusão

_Preencher após a execução._ Enquanto este documento permanecer **PENDENTE**, a migração de código **não** foi realizada — apenas a documentação de planejamento/conjunto homologado está pronta.

---

## 10. Referências

- `DOCUMENTACAO/GuiaGenericoAtualizacaoPacotes.md`
- `DOCUMENTACAO/UpdateDotNet10/PlanoAcaoMigracaoDotNet10.md`
- `DOCUMENTACAO/UpdateDotNet10/RascunhoPlanoUpdateDotNet10.md`
- `DOCUMENTACAO/API/2026-07-LevantamentoConjuntoHomologado-SmartDigitalPsicoAPI.md`
- `DOCUMENTACAO/API/PlanoImplementacaoMigracaoDotNet10-SmartDigitalPsicoAPI.md`
- Pomelo EF Core 10 tracking: https://github.com/PomeloFoundation/Pomelo.EntityFrameworkCore.MySql/issues/2007
- Swashbuckle v10: https://github.com/domaindrivendev/Swashbuckle.AspNetCore/blob/master/docs/migrating-to-v10.md
