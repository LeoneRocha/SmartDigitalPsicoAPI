# Sugestão — Migrar SmartDigitalPsico.WebJob para Azure Functions (Worker Isolated)

**Status:** SUGESTÃO (não implementado)  
**Data:** 2026-08-01  
**Escopo:** documento de melhoria futura — **não faz parte** da migração .NET 8 → .NET 10 já concluída  
**Projeto atual:** `SmartDigitalPsicoAPI/SmartDigitalPsico.WebJob`  
**Camada de negócio a preservar:** `IBackgroundJobService` / `BackgroundJobService` → `INotificationDispatchJobService`

---

## 1. Resumo executivo

Hoje o processamento de notificações em background roda em um **Worker** (`Microsoft.NET.Sdk.Worker`) que ainda referencia o **Azure WebJobs SDK clássico** (`Microsoft.Azure.WebJobs*`) e um `BackgroundService` com loop + `Task.Delay`.

A melhoria sugerida é **substituir esse host** por **Azure Functions no modelo Worker Isolated** (`.NET isolated`), mantendo a lógica de negócio em `SmartDigitalPsico.Service` e apenas trocando o *hosting*/triggers.

| Item | Valor sugerido |
| ---- | -------------- |
| Prioridade | Média (pós-estabilização .NET 10) |
| Esforço estimado | 3–8 dias (dev + DevOps + homolog) |
| Risco | Médio (deploy, schedule, cold start, conexões) |
| Breaking de API REST | Nenhum (WebAPI intacta) |
| Breaking de domínio | Nenhum se `IBackgroundJobService` for reutilizado |

**Este documento não autoriza implementação automática.** Implementar somente após decisão explícita de produto/arquitetura.

---

## 2. Situação atual

### 2.1 Host e pacotes

- Projeto: `SmartDigitalPsico.WebJob` (`net10.0`, SDK Worker)
- Pacotes: `Microsoft.Azure.WebJobs` / `Core` / `Extensions` (+ Hosting + Serilog)
- Bootstrap: `HostBuilder().ConfigureWebJobs(...).AddFiles()` em `Program.cs`
- DI: `WebJobConfigureServiceCollections` → mesma cadeia `Service` usada pela WebAPI

### 2.2 Modos de execução

Configuração `JobSettings:ExecutionMode`:

| Modo | Comportamento atual |
| ---- | ------------------- |
| `OneTime` | Resolve `IBackgroundJobService`, chama `ExecuteNotificationProcessAsync()`, encerra o processo |
| `Continuous` | Registra `ContinuousJobHostedService` (`BackgroundService`) que, em loop, chama o mesmo método e aguarda `JobSettings:TaskDelayMinutes` |

### 2.3 Trabalho real

```text
ContinuousJobHostedService / OneTime
  → IBackgroundJobService.ExecuteNotificationProcessAsync()
    → INotificationDispatchJobService.ProcessPendingNotificationsAsync()
```

A regra de negócio **já está desacoplada do host**. Isso favorece a migração: o Functions app vira um *thin host* com triggers.

### 2.4 Limitações do modelo atual

1. **WebJobs SDK clássico** não é o caminho recomendado de longo prazo pela Microsoft para novos workloads .NET (o ecossistema evoluiu para **Functions Isolated** / Durable / Container Apps Jobs).
2. O loop com `Task.Delay` em Continuous é um **pseudo-scheduler** (sem CRON nativo, sem retry policy do host, sem escala automática por evento).
3. Observabilidade e governança no Azure (Application Insights, Identity, slots, scale-out) são mais maduras no modelo Functions.
4. Pacotes `Microsoft.Azure.WebJobs*` continuam listados no NuGet, mas o **destino estratégico** para jobs .NET na Azure é o **Worker Isolated**.
5. Após a migração TFM para .NET 10, este host ficou funcional, porém **fora do padrão moderno** de hosting serverless/event-driven.

---

## 3. Objetivo da melhoria

Migrar o host `SmartDigitalPsico.WebJob` para um projeto **Azure Functions Isolated Worker** que:

1. Dispare o processamento de notificações via **Timer Trigger** (equivalente ao Continuous + delay) e, opcionalmente, **HTTP Trigger** (equivalente operacional ao OneTime / smoke manual).
2. Continue chamando `IBackgroundJobService` (ou diretamente `INotificationDispatchJobService`) sem alterar o domínio.
3. Remova dependências diretas de `Microsoft.Azure.WebJobs*` do grafo da solução.
4. Alinhe deploy Azure (Function App + `FUNCTIONS_WORKER_RUNTIME=dotnet-isolated`) e pipeline DevOps.

**Fora de escopo desta sugestão:** reescrever regras de notificação, WindowsService, WebAPI, EF/Pomelo, ou Durable Functions (pode ser fase 2).

---

## 4. Arquitetura proposta (alvo)

```text
                    ┌──────────────────────────────┐
  Timer / HTTP      │  SmartDigitalPsico.Functions │  (novo projeto Isolated)
  triggers          │  - NotificationTimerFunction │
                    │  - NotificationHttpFunction  │
                    └──────────────┬───────────────┘
                                   │ DI (Program.cs HostBuilder)
                                   ▼
                    ┌──────────────────────────────┐
                    │  SmartDigitalPsico.Service   │  (inalterado na medida do possível)
                    │  BackgroundJobService        │
                    │  NotificationDispatchJob…    │
                    └──────────────┬───────────────┘
                                   ▼
                              Data / Domain
```

### 4.1 Mapeamento de modos

| Hoje (WebJob) | Sugestão Isolated |
| ------------- | ----------------- |
| `Continuous` + `TaskDelayMinutes` | `[TimerTrigger("0 */{N} * * * *")]` (CRON) ou NCRONTAB equivalente |
| `OneTime` | HTTP Trigger autenticado **ou** execução via `func start` / pipeline one-shot |
| `ConfigureWebJobs` + `AddFiles` | Remover; só usar se houver trigger de File/Blob real (hoje o AddFiles parece residual) |

### 4.2 Pacotes alvo (orientação)

Substituir:

- `Microsoft.Azure.WebJobs`
- `Microsoft.Azure.WebJobs.Core`
- `Microsoft.Azure.WebJobs.Extensions`

Por (versões a homologar na época da implementação):

- `Microsoft.Azure.Functions.Worker`
- `Microsoft.Azure.Functions.Worker.Sdk`
- `Microsoft.Azure.Functions.Worker.Extensions.Timer`
- `Microsoft.Azure.Functions.Worker.Extensions.Http` (se OneTime/manual)
- `Microsoft.ApplicationInsights.WorkerService` / integração Serilog (opcional, alinhada à WebAPI)

TFM sugerido: **`net10.0`**, alinhado ao restante da solução (Isolated permite .NET 10; in-process **não**).

### 4.3 Esboço ilustrativo (não implementar agora)

```csharp
// APENAS EXEMPLO — não faz parte do código atual
public class NotificationFunctions
{
    private readonly IBackgroundJobService _jobs;

    public NotificationFunctions(IBackgroundJobService jobs) => _jobs = jobs;

    [Function("ProcessPendingNotificationsTimer")]
    public async Task RunTimer(
        [TimerTrigger("%NotificationTimerSchedule%")] TimerInfo timer,
        FunctionContext context)
    {
        await _jobs.ExecuteNotificationProcessAsync();
    }

    [Function("ProcessPendingNotificationsHttp")]
    public async Task<HttpResponseData> RunHttp(
        [HttpTrigger(AuthorizationLevel.Function, "post")] HttpRequestData req)
    {
        await _jobs.ExecuteNotificationProcessAsync();
        var res = req.CreateResponse(HttpStatusCode.OK);
        await res.WriteStringAsync("ok");
        return res;
    }
}
```

`Program.cs` Isolated registraria o mesmo bloco de DI hoje em `WebJobConfigureServiceCollections` (extrair para um método compartilhado se necessário).

---

## 5. Benefícios esperados

1. **Alinhamento com o modelo suportado** pela Microsoft para jobs .NET na Azure (Isolated).
2. **Scheduler nativo** (Timer) em vez de loop + `Delay` no processo.
3. **Escala e hosting** mais claros (Consumption / Flex / Premium / Dedicated) sem acoplar a um WebJob “escondido” no App Service da API.
4. **Remoção de WebJobs*** do CPM — grafo NuGet mais limpo pós-.NET 10.
5. **Operação**: invocação manual via HTTP Function key; logs estruturados no portal Functions; health/metrics padrão.
6. **Segurança**: Managed Identity + Key Vault no Function App, padrão Azure moderno.

---

## 6. Riscos e trade-offs

| Risco | Mitigação |
| ----- | --------- |
| Cold start (Consumption) | Premium/Dedicated, ou Always On; medir latência do job de notificação |
| Sobreposição de execuções do Timer | `Singleton` / `RunOnStartup=false` / lock distribuído se o job não for idempotente |
| Dupla execução durante cutover | Feature flag: desligar WebJob antigo antes de ligar Function App |
| Diferenças de config (`appsettings` vs App Settings) | Documentar mapeamento `JobSettings:*` → Application Settings |
| Conexões EF / MySQL no Functions | Validar pooling e timeout; reutilizar padrões da WebAPI |
| Custo Azure | Comparar plano atual (WebJob no App Service) vs Function plan |
| WindowsService paralelo | Manter separado; esta sugestão **não** unifica WindowsService |

---

## 7. Plano de implementação sugerido (quando aprovado)

> Checklist futuro — **não executar neste ciclo**.

### Fase A — Descoberta

- [ ] Inventariar onde o WebJob é publicado hoje (App Service slot, pipeline, CRON externo).
- [ ] Confirmar se `AddFiles()` é usado de fato ou é código morto.
- [ ] Medir duração média de `ProcessPendingNotificationsAsync` e volume.

### Fase B — Spike técnico (1–2 dias)

- [ ] Criar branch/spike `feat/functions-isolated-notifications` com projeto Functions Isolated `net10.0`.
- [ ] Reutilizar DI de `WebJobConfigureServiceCollections` (extrair shared se preciso).
- [ ] Timer Trigger + HTTP Trigger apontando para `IBackgroundJobService`.
- [ ] Validar local com Azure Functions Core Tools.

### Fase C — Homologação

- [ ] Function App de homolog + Application Insights.
- [ ] Comparar resultado do job (contagens, erros) com o WebJob atual.
- [ ] Testar sobreposição de Timer e falha/retry.

### Fase D — Cutover

- [ ] Desabilitar Continuous/OneTime do WebJob antigo.
- [ ] Ativar Function App em produção.
- [ ] Remover projeto `SmartDigitalPsico.WebJob` **ou** marcá-lo obsolete e retirar `Microsoft.Azure.WebJobs*` do `Directory.Packages.props`.
- [ ] Atualizar README + pipeline Azure DevOps (`dotnet publish` Functions + zip deploy / `AzureFunctionApp@2`).

### Fase E — Opcional (fase 2)

- [ ] Durable Functions para orquestração se o job crescer.
- [ ] Queue Trigger (Storage Queue já existe no Service) em vez de polling Timer.
- [ ] Unificar observabilidade Serilog ↔ App Insights.

---

## 8. Critérios de aceite (futuros)

1. Function App Isolated `net10.0` processa notificações com o **mesmo** serviço de domínio.
2. Zero referências a `Microsoft.Azure.WebJobs*` na solução (após remoção do host antigo).
3. Timer configurável por App Setting (paridade com `TaskDelayMinutes` / CRON).
4. Smoke HTTP (homolog) retorna sucesso e gera o mesmo efeito operacional do OneTime.
5. Documentação de deploy e rollback publicada.
6. Sem regressão na WebAPI / WindowsService.

---

## 9. Alternativas consideradas

| Alternativa | Prós | Contras | Veredito |
| ----------- | ---- | ------- | --------|
| Manter WebJob SDK atual | Zero esforço | Modelo legado, loop manual | Aceitável curto prazo |
| Só `BackgroundService` sem WebJobs* | Remove pacotes WebJobs | Continua processo sempre ligado no App Service | Bom paliativo |
| **Functions Isolated** | Padrão Azure, Timer, escala | Cutover DevOps | **Recomendado** |
| Container Apps Jobs | Flexível, containers | Mais ops; overkill se só Timer | Avaliar se já houver AKS/ACA |
| Hangfire / Quartz in-process na WebAPI | Simples | Acopla job à API; escala ruim | Não recomendado |

**Paliativo rápido (se a migração Isolated atrasar):** remover `Microsoft.Azure.WebJobs*` e manter apenas `Host` + `ContinuousJobHostedService` — documentar como passo intermediário, não como alvo final.

---

## 10. Relação com a migração .NET 10

| Tema | Status |
| ---- | ------ |
| TFM `net10.0` no WebJob atual | Já feito |
| CPM / remoção de vulns | Já feito; WebJobs* mantidos porque ainda em uso |
| Migração Functions Isolated | **Sugestão futura** (este documento) |
| Implementação de código | **Não iniciada de propósito** |

Referências internas:

- `DOCUMENTACAO/UpdateDotNet10/RelatorioMigracaoDotNet10.md`
- `DOCUMENTACAO/API/2026-07-LevantamentoConjuntoHomologado-SmartDigitalPsicoAPI.md`
- Código atual: `SmartDigitalPsico.WebJob/Program.cs`, `ContinuousJobHostedService.cs`, `SmartDigitalPsico.Service/Bussines/BackgroundJobService.cs`

Referências externas:

- [Migrate from in-process to isolated worker model](https://learn.microsoft.com/en-us/azure/azure-functions/migrate-dotnet-to-isolated-model)
- [Guide for running C# Azure Functions in an isolated worker process](https://learn.microsoft.com/en-us/azure/azure-functions/dotnet-isolated-process-guide)
- [Timer trigger for Azure Functions](https://learn.microsoft.com/en-us/azure/azure-functions/functions-bindings-timer)

---

## 11. Decisão pendente

| Pergunta | Opção sugerida |
| -------- | -------------- |
| Aprovar spike Functions Isolated? | Sim, após estabilizar produção .NET 10 |
| Manter WebJob em paralelo durante homolog? | Sim (cutover controlado) |
| Plano Azure inicial | Premium/Dedicated se job > ~1–2 min ou precisar VNET; senão Consumption/Flex com medição |
| Remover projeto WebJob após cutover? | Sim, para evitar dois hosts |

**Ação imediata recomendada:** apenas registrar esta melhoria no backlog (ex.: Azure DevOps / Notion) com link para este arquivo. **Não implementar código nesta etapa.**
