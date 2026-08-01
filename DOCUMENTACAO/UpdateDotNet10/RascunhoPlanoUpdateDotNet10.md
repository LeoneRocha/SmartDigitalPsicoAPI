# Rascunho / RFC — Migração SmartDigitalPsicoAPI .NET 8 → .NET 10

**Documento:** RFC + prompt operacional para IA/agente  
**Solução:** `SmartDigitalPsicoAPI/SmartDigitalPsicoAPI.sln`  
**Data:** 2026-07-31  
**Status:** CONCLUÍDO (2026-08-01) — ver `RelatorioMigracaoDotNet10.md`  
**Planos oficiais:**  
- `DOCUMENTACAO/UpdateDotNet10/PlanoAcaoMigracaoDotNet10.md`  
- `DOCUMENTACAO/API/2026-07-LevantamentoConjuntoHomologado-SmartDigitalPsicoAPI.md`  
- `DOCUMENTACAO/API/PlanoImplementacaoMigracaoDotNet10-SmartDigitalPsicoAPI.md`

> RFC histórico. Destino aplicado: **.NET 10** (`net10.0`), SDK `10.0.301`.

---

## Prompt para Cursor IA

**Objetivo:**  
Atualizar a solução **SmartDigitalPsicoAPI** de **.NET 8** para **.NET 10**, aplicando o **Conjunto Homologado v1**, garantindo build, testes NUnit, migrations EF, startup da WebAPI/WindowsService/WebJob e smoke de DI/JWT — **sem** alterar regras de negócio nem contratos públicos.

### Tarefas principais

- Migrar os 8 projetos C# do `.sln` para `net10.0`.
- Introduzir CPM (`SmartDigitalPsicoAPI/Directory.Packages.props`) e remover `Version=` dos `.csproj`.
- Remover `MySql.EntityFrameworkCore` (dead reference; DI usa Pomelo).
- Aplicar **somente** versões do Conjunto Homologado v1 (não improvisar).
- Validar migrations MySQL/Pomelo e SqlServer (técnica da migration temporária).
- Build Release da solução; `dotnet test` Domain.Test + Data.Test.
- Executar WebAPI (e smoke workers); validar DI, Swagger, JWT.
- Atualizar Dockerfiles para `aspnet:10.0` / `sdk:10.0`; README / `global.json` para SDK 10; anotar pipeline Azure DevOps externo.
- Preencher `RelatorioMigracaoDotNet10.md` com evidências.

### Pontos de atenção

- **Pomelo oficial = 9.0.0** → EF Core permanece em **9.0.18** no runtime `net10.0` (não forçar EF 10).
- **Não usar** forks Pomelo sem RFC.
- Persistência dual: MySQL (Pomelo) **e** SqlServer na **mesma major EF 9**.
- **Moq.EntityFrameworkCore** deve permanecer na linha **9.x** (`9.0.0.10`), não 10.x.
- Há projetos de teste — `dotnet test` é **obrigatório**.
- Dockerfiles .NET da API **existem** e devem subir para 10.0.
- Auth é **JwtBearer** (não Identity.Web).
- Não há Semantic Kernel / Groq nos `.csproj` deste ciclo.

### Critérios de aceite

- [ ] Todos os projetos C# em `net10.0`.
- [ ] CPM ativo; versões = Conjunto v1.
- [ ] Build Release 0 erros; testes 100% passando.
- [ ] Migrations validadas; migration temporária vazia (ou desvio justificado).
- [ ] WebAPI sobe; DI OK; Swagger OK; smoke JWT; workers smoke OK.
- [ ] Dockerfiles 10.0; README + `global.json` SDK 10; CI externo anotado.
- [ ] Relatório de evidências preenchido.

### Diretrizes para a IA

1. Ler o Conjunto Homologado e o Plano de Implementação **antes** de editar código.
2. Abordagem incremental por fases (CPM → Domain/Data/Service → hosts → testes → EF → código → Docker/docs).
3. Validar `dotnet build -c Release` e `dotnet test` ao fim das fases relevantes.
4. Não introduzir stack AI neste ciclo.
5. Não commitar/PR sem pedido explícito do responsável.

### Modo de execução sugerido

1. Apresentar plano de alteração dos `.csproj` + amostra do `Directory.Packages.props` alinhada ao Conjunto v1.  
2. Aguardar validação (se o usuário pedir).  
3. Executar fases 0–7.  
4. Preencher o relatório.

---

# RFC-001 — Migração SmartDigitalPsicoAPI para .NET 10

## 1. Objetivo

Migrar a plataforma backend SmartDigitalPsico de `net8.0` para `net10.0`, centralizando NuGet via CPM, preservando a compatibilidade Pomelo/EF e a suíte de testes, sem regressões funcionais.

## 2. Escopo

| Inclui | Não inclui |
| ------ | ---------- |
| 8 projetos C# do `SmartDigitalPsicoAPI.sln` | Frontend / npm |
| CPM + Conjunto Homologado v1 | Fork Pomelo / EF 10 |
| Migrations EF (MySQL + SqlServer) | Nova suíte de testes do zero |
| Dockerfiles aspnet/sdk 10.0 | Stack AI nova |
| README / global.json / nota CI | Mudança de contratos REST |

## 3. Arquitetura atual

```text
SmartDigitalPsico.WebAPI (Web)
  └── SmartDigitalPsico.Service
        └── SmartDigitalPsico.Data     (EF + Pomelo MySQL + SqlServer)
              └── SmartDigitalPsico.Domain   (JWT, Swagger, Serilog, PDF, Polly)

SmartDigitalPsico.WindowsService → Service, Data
SmartDigitalPsico.WebJob → Service
Domain.Test / Data.Test (NUnit)
```

- Auth: `JwtBearer`  
- Logging: Serilog  
- ORM: Pomelo MySQL **ou** SqlServer (flag `UseSqlServer` em appsettings)

## 4. Estratégia de migração

1. **Inventário e Conjunto Homologado** (já feito em `DOCUMENTACAO/API/`).
2. **CPM primeiro** como fonte única de versões.
3. **Bibliotecas** Domain → Data → Service.
4. **Executáveis** WebAPI + WindowsService + WebJob.
5. **Testes** Domain.Test + Data.Test.
6. **EF / migrations** com prova de schema inalterado.
7. **Ajustes de código** (Swagger 10, LINQ, AutoMapper).
8. **Docker + docs** (SDK 10) + relatório.

## 5. Análise de impacto

| Área | Impacto | Severidade |
| ---- | ------- | ---------- |
| TFM net10 | Recompile + peers AspNet 10 | Alta |
| EF 8→9 + Pomelo 8→9 | Migrations / provider | Alta |
| Swashbuckle 8→10 | OpenAPI 2.x | Média |
| AutoMapper 14→16 | Mapping + licença | Média |
| Docker 8→10 | Deploy/runtime | Alta |
| Remoção Oracle MySQL EF | Limpeza de grafo | Baixa |
| Testes existentes | Rede de segurança | Positiva (mitiga regressão) |

## 6. Riscos e mitigações

| Risco | Mitigação |
| ----- | --------- |
| `NU1107` EF10+Pomelo9 | Conjunto v1 = EF 9.0.18 |
| Moq.EF 10 com EF 9 | Usar Moq.EF **9.0.0.10** |
| CI .NET desalinhado | `global.json` + UseDotNet 10.x |
| Dual DB | Validar SqlServer e MySQL se ambos forem usados |

## 7. Plano de rollback

`git reset --hard <baseline>` + `dotnet restore/build/test`. Restaurar `Directory.Packages.props` + `.csproj` + Dockerfiles + `global.json` juntos.

## 8. Qualidade e evidências

- Build Release 0 erros  
- `dotnet test` 100%  
- Migration temporária vazia  
- Smoke WebAPI / JWT / workers  
- Docker build 10.0  
- Relatório preenchido em `RelatorioMigracaoDotNet10.md`

## 9. Pipeline CI/CD

- `azure-pipelines.yml` in-repo é stub.  
- Pipeline real: Azure DevOps externo — alinhar SDK para **10.x**.  
- Local: `global.json` com rollForward `latestFeature`.

## 10. Observabilidade

- Manter Serilog; validar sinks Console/File após upgrade.  
- Não introduzir Application Insights neste ciclo (não é dependência atual obrigatória).

## 11. Checklist resumido

- [ ] Conjunto v1 aplicado via CPM  
- [ ] TFMs corretos  
- [ ] Build + testes OK  
- [ ] EF migrations OK  
- [ ] Smoke WebAPI OK  
- [ ] Docker 10.0 OK  
- [ ] Docs + relatório OK  

## 12. Referências

- `DOCUMENTACAO/GuiaGenericoAtualizacaoPacotes.md`  
- `DOCUMENTACAO/UpdateDotNet10/PlanoAcaoMigracaoDotNet10.md`  
- `DOCUMENTACAO/API/2026-07-LevantamentoConjuntoHomologado-SmartDigitalPsicoAPI.md`  
- `DOCUMENTACAO/API/PlanoImplementacaoMigracaoDotNet10-SmartDigitalPsicoAPI.md`  
- Pomelo EF10 tracking: https://github.com/PomeloFoundation/Pomelo.EntityFrameworkCore.MySql/issues/2007
