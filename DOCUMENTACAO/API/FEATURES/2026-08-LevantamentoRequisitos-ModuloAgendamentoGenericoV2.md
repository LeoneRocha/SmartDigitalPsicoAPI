  # Levantamento de Requisitos — Módulo Genérico de Agendamento

  **Documento:** Levantamento de requisitos (produto + técnico)  
  **Solução de origem:** `SmartDigitalPsicoAPI/SmartDigitalPsicoAPI.sln`  
  **Plano de implementação:** `DOCUMENTACAO/API/FEATURES/2026-08-PlanoImplementacao-ModuloAgendamentoGenerico.md`  
  **Controller congelado (FE):** `SmartDigitalPsico.WebAPI/Controllers/v1/Principals/MedicalCalendarController.cs`  
  **Data:** 2026-08-02 (rev. **ScheduleCalendar + services por ação**)  
  **Status:** HOMOLOGÁVEL — SoT = `ScheduleCalendar` + JSON `ScheduleCalendarItem[]` (genérico, desacoplado)

  > Objetivo: módulo genérico de agendamento performático (estilo Google Agenda), extratável, **sem alterar** rotas/DTOs do frontend — com **1 tabela de core** (`ScheduleCalendar`: `TenantKey`/`OwnerKey`/`SubjectKey`, **sem** FKs Medical/Patient), onde cada dia/intervalo **não** vira 1 registro no banco e sim item em `ScheduleData`. Fachada medical + **services por ação**. `ScheduleBatch` = legado acoplado Medical — **não** é SoT. Inventário de regras/performance do legado preservado.

  ---

  ## 1. Objetivo e motivação

  ### 1.1 Objetivo

  1. Substituir/melhorar, **por baixo**, o fluxo de `MedicalCalendarService` (persistência, conflitos, recorrência, slots)
  2. Introduzir SoT genérico [`ScheduleCalendar`](../../../../SmartDigitalPsico.Domain/EntityModels/Schedule/ScheduleCalendar.cs) + [`ScheduleCalendarItem`](../../../../SmartDigitalPsico.Domain/EntityModels/Schedule/ScheduleCalendarItem.cs) (keys; sem Medical/Patient)
  3. Quebrar o adapter monolítico em **services por ação** + facade (`IScheduleCalendarFacade`)
  4. Manter a API médica **100% compatível** com o Angular
  5. Core reutilizável por outros sistemas (`IScheduleCalendarService`); `ScheduleBatch` legado fora do caminho crítico

  ### 1.2 Motivação

  O calendário médico concentra regras e performance em um serviço grande (~1000+ linhas), com dual-write parcial para `ScheduleBatch` e leituras em `MedicalCalendar`. Isso gera:

  - Manutenção difícil (CRUD + recorrência + grade + appointments + notificações no mesmo lugar)
  - Performance degradada em conflitos, recorrência e geração de slots
  - `MedicalCalendar` materializa **1 row por ocorrência** → caro em séries
  - `ScheduleBatch` já agrupa ocorrências em **1 row + JSON** — modelo a consolidar como SoT
  - Um desvio MVP chegou a criar `ScheduleSeries` / `ScheduleOccurrence` (+ um `ScheduleCalendar` normalizado 3 tabelas) — **fora da meta**; revertido. O SoT atual é **1 tabela** `ScheduleCalendar` + JSON items (não 1 row por intervalo).

  ### 1.3 Princípio de compatibilidade com o frontend (obrigatório)

  | Regra | Detalhe |
  | ----- | ------- |
  | **Não alterar endpoints medical** | Mesmas rotas, verbos, nomes de actions e padrões de `Ok`/`BadRequest` |
  | **Não alterar DTOs públicos medical** | `Add/Update/Delete/GetMedicalCalendarDto`, `CalendarCriteriaDto`, `CalendarDto`, `ScheduleCriteriaDto`, `AppointmentCriteriaDto`, `AppointmentDto`, etc. |
  | **Não alterar envelope** | Continuar `ServiceResponse<T>` |
  | **Não alterar auth** | `[Authorize("Bearer")]` + `SetUserId` / culture como hoje |
  | **Mudança só interna** | Persistência Batch-JSON, helpers, adapter — atrás da fachada |
  | **API `api/schedule/v1`** | Opcional / P2 para outros sistemas; **não** é contrato do FE SDP |

  ---

  ## 2. Escopo e não escopo

  ### 2.1 Escopo

  | Categoria | Incluso |
  | --------- | ------- |
  | Modelo core | **1 tabela** `ScheduleCalendar` + JSON `ScheduleCalendarItem` (`TenantKey`/`OwnerKey`/`SubjectKey`) |
  | Sync | `UniqueToken` = `TokenRecurrence`; Create/Update/Delete via `IScheduleCalendarService` |
  | Helpers | Recorrência, overlap, slots sobre intervals / items in-memory |
  | Fachada SDP | Controller + **Facade** + services Find/Create/Update/Delete/Grade/Appointment; dual-write MC (shadow) + Agenda (SoT) |
  | Regras clínicas | Services medical (working hours, 23h/12h, appointments) — **preservar comportamento** |
  | Correção performance | Overlap real, 1 validate de janela, slots só na janela útil |
  | Legado | `ScheduleBatch` permanece no banco; **não** usado pelo path medical |

  ### 2.2 Não escopo

  | Item | Motivo |
  | ---- | ------ |
  | Tabelas `ScheduleSeries` / `ScheduleOccurrence` (ou 1 row DB por intervalo) | Desvio 3 tabelas; não são o alvo |
  | 1 registro DB por dia/intervalo no core | Viola performance e meta Batch-JSON |
  | GraphQL / FCM / Google sync | Fora da v1 |
  | Breaking change no Angular | Proibido |
  | API `api/schedule/v1` | P2 opcional |
  | Dropar `MedicalCalendar` na mesma release do cutover | Shadow FE até migração estável |

  ---

  ## 3. Análise do legado (as-is)

  ### 3.1 Fluxo atual (visão geral)

  ```mermaid
  flowchart LR
    FE[Frontend_Angular] --> API[MedicalCalendarController]
    API --> Facade[ScheduleCalendarFacade]
    Facade --> ActionSvcs[Find_Create_Update_Delete_Grade_Appointment]
    ActionSvcs --> MC[(MedicalCalendar_shadow)]
    ActionSvcs -->|"dual_write"| Agenda[IScheduleCalendarService]
    Agenda --> AS[(ScheduleCalendar_JSON)]
    ActionSvcs --> Notif[NotificationRecords_Email]
  ```

  | Aspecto | MedicalCalendar (shadow FE) | ScheduleCalendar (SoT) | ScheduleBatch (legado) |
  | ------- | --------------------------- | -------------------- | ---------------------- |
  | Persistência | 1 linha por ocorrência | 1 linha / lote; items em JSON | Idem, acoplado Medical — Obsolete |
  | Consumido pelo FE | **Sim** (única API) | Via dual-write / cutover futuro | Não (fora do path medical) |
  | Create | Sim + dual-write ScheduleCalendar | `CreateOrUpdateAsync` | Não usar |
  | Token | `TokenRecurrence` | `UniqueToken` (= TokenRecurrence) | — |
  | Acoplamento | `MedicalId`, `PatientId` | `TenantKey`/`OwnerKey`/`SubjectKey` | MedicalId/PatientId |

  ### 3.2 Componentes inventariados

  #### MedicalCalendar

  | Camada | Caminho |
  | ------ | ------- |
  | Entity | `Domain/EntityModels/MedicalCalendar.cs` |
  | Service / fachada fina | `Service/DataEntity/Principals/MedicalCalendarService.cs` |
  | Facade + action services | `Service/Bussines/Schedule/Actions/` |
  | Interface adapter | `Domain/Interfaces/Service/Schedule/IScheduleCalendarFacade.cs` |
  | Repository | `Data/Repository/Principals/MedicalCalendarRepository.cs` |
  | Controller | `WebAPI/Controllers/v1/Principals/MedicalCalendarController.cs` |
  | EF config | `Data/Context/Configure/Entity/MedicalCalendarConfiguration.cs` |
  | Validators | `Domain/Validation/Principals/Calendar/*` |
  | DTOs schedule | `Domain/DTO/Medical/MedicalCalendar/*` |
  | DTOs calendar/appointment | `Domain/DTO/Medical/Calendar/*` |

  #### ScheduleCalendar (SoT genérico)

  | Camada | Caminho |
  | ------ | ------- |
  | Entity / Item | `Domain/EntityModels/Schedule/ScheduleCalendar.cs`, `ScheduleCalendarItem.cs` |
  | Service | `Service/Bussines/Schedule/ScheduleCalendarService.cs` |
  | Repository | `Data/Repository/Schedule/ScheduleCalendarRepository.cs` |
  | EF config | `Data/Context/Configure/Entity/ScheduleCalendarConfiguration.cs` |
  | Writer SDP | `Service/Bussines/Schedule/Actions/ScheduleCalendarSyncWriter.cs` |

  #### ScheduleBatch (legado Obsolete)

  | Camada | Caminho |
  | ------ | ------- |
  | Entity / Item | `Domain/EntityModels/Schedule/ScheduleBatch.cs`, `ScheduleItem.cs` |
  | Service | `Service/Bussines/Schedule/ScheduleBatchService.cs` (`[Obsolete]`) |
  | Repository | `Data/Repository/Schedule/ScheduleBatchRepository.cs` |
  | EF config | `Data/Context/Configure/Entity/ScheduleBatchConfiguration.cs` |
  | Status | Fora do path medical; tabela permanece no banco |

  ### 3.3 Contrato HTTP congelado — `MedicalCalendarController`

  **Base imutável:** `api/medical/v1/MedicalCalendar`  
  **Auth imutável:** `[Authorize("Bearer")]`  
  **Pré-processamento imutável por action:** `setUserIdCurrent()` + `SetCurrentCulture()`

  #### 3.3.1 Catálogo completo dos 8 endpoints

  | # | HTTP | Rota completa | Action controller | Service / adapter | Request | Response `ServiceResponse<T>` | Sucesso | Erro |
  | - | ---- | ------------- | ----------------- | ----------------- | ------- | ----------------------------- | ------- | ---- |
  | E1 | GET | `.../MedicalCalendar/schedule/{id}` | `FindByID` | `FindByID` | route `id` | `GetMedicalCalendarDto` | `200 Ok` | `400` se `!Success` |
  | E2 | POST | `.../MedicalCalendar/schedule` | `Create` | `Create` | `AddMedicalCalendarDto` | `GetMedicalCalendarDto` | `200 Ok` | `400` se `!Success` |
  | E3 | PUT | `.../MedicalCalendar/schedule` | `Update` | `Update` | `UpdateMedicalCalendarDto` | `GetMedicalCalendarDto` | `200 Ok` | `400` se `Data == null` |
  | E4 | DELETE | `.../MedicalCalendar/schedule` | `Delete` | `DeleteOneOrRecurrence` | `DeleteMedicalCalendarDto` | `bool` | `200 Ok` | `400` se `!Success` |
  | E5 | POST | `.../MedicalCalendar/calendar` | `GetMonthlyCalendar` | `GetMonthlyCalendar` | `CalendarCriteriaDto` | `CalendarDto` | `200 Ok` | sempre `Ok` (erro no envelope) |
  | E6 | POST | `.../MedicalCalendar/available` | `GetAvailableMedicalCalendar` | `GetAvailableMedicalCalendar` | `CalendarCriteriaDto` | `CalendarDto` | `200 Ok` | sempre `Ok` |
  | E7 | POST | `.../MedicalCalendar/appointment/send` | `SendAppointments` | `RequestAppointment` | `ScheduleCriteriaDto` | tipagem controller `CalendarDto` (*) | `200 Ok` | sempre `Ok` |
  | E8 | POST | `.../MedicalCalendar/appointment/get` | `GetAppointments` | `GetAppointments` | `AppointmentCriteriaDto` | `AppointmentDto[]` | `200 Ok` | sempre `Ok` |

  (*) Controller tipa `ServiceResponse<CalendarDto>`; interface service declara `ServiceResponse<bool>` — **preservar o JSON que o Angular já consome**.

  **Hypermedia:** E1–E4 usam `[TypeFilter(typeof(HyperMediaFilterrAttribute))]`. E5–E8 não.

  #### 3.3.2 DTOs de contrato (não breaking)

  **`AddMedicalCalendarDto` / `UpdateMedicalCalendarDto` / bases:**

  | Campo | Tipo | Uso |
  | ----- | ---- | --- |
  | `Id` | long | Update / Get |
  | `Enable` | bool | |
  | `MedicalId`, `PatientId?` | long | Relacionamento clínico |
  | `Title`, `Description`, `Location` | string | |
  | `StartDateTime`, `EndDateTime?` | DateTime | |
  | `IsAllDay` | bool | |
  | `Status` | `EStatusCalendar` | |
  | `ColorCategoryHexa`, `TimeZone` | string | |
  | `IsPushedCalendar` | bool | |
  | `RecurrenceDays` | `DayOfWeek[]` | |
  | `RecurrenceType` | `ERecurrenceCalendarType` | |
  | `RecurrenceEndDate?`, `RecurrenceCount` | DateTime? / short | |
  | `UpdateSeries` | bool | Update série |
  | `TokenRecurrence` | string | Série |
  | `CreatedUserId?`, `ModifyUserId?` | long? | |

  **`GetMedicalCalendarDto`:** action base + nav `Medical`, `Patient?`, `CreatedUser?`, `ModifyUser?` + `Links`.  
  **`DeleteMedicalCalendarDto`:** `Id`, `DeleteSeries`, `TokenRecurrence`, `MedicalId`, `PatientId`.  
  **`CalendarCriteriaDto`:** `MedicalId`, `Month`, `Year`, `StartDate?`, `EndDate?`, `IntervalInMinutes`, `FilterDaysAndTimesWithAppointments`, `FilterByDate?`.  
  **`CalendarDto`:** `MedicalId`, `MedicalName`, `Days[]` → `DayCalendarDto` (`Date`, `IsPast`, `TimeSlots[]`) → `TimeSlotDto`.  
  **`ScheduleCriteriaDto`:** `AppointmentDateTime`, `Reason`, `TimeZone`, `ScheduleType`, `PatientId`, `MedicalId`.  
  **`AppointmentCriteriaDto` / `AppointmentDto`:** critérios + lista com `IsPast`.

  #### 3.3.3 Fluxos por endpoint (as-is)

  ```mermaid
  flowchart TD
    subgraph e1 [E1_GET_schedule_id]
      A1[FindByID] --> B1[MedicalCalendar_repo]
    end

    subgraph e2 [E2_POST_schedule]
      A2[Validate_DTO] --> B2{Recurrence?}
      B2 -->|Yes| C2[Generate_N_MC_rows]
      B2 -->|No| D2[Insert_one_MC]
      C2 --> E2n[Notifications]
      D2 --> E2n
      E2n --> F2[DualWrite_ScheduleBatch]
      F2 --> G2[Email_notify]
    end

    subgraph e3 [E3_PUT_schedule]
      A3[Lookup_CreatedDate] --> B3[Validate]
      B3 --> C3{UpdateSeries?}
      C3 -->|Yes| D3[Delete_regen_series]
      C3 -->|No| E3u[Update_one]
      D3 --> F3[Notify_DualWrite_Batch]
      E3u --> F3
    end

    subgraph e4 [E4_DELETE_schedule]
      A4{DeleteSeries?} -->|Yes| B4[Delete_by_token]
      A4 -->|No| C4[Delete_one]
      B4 --> D4[Clean_NotificationRecords]
      C4 --> D4
    end
  ```

  ```mermaid
  flowchart TD
    subgraph e5 [E5_POST_calendar]
      A5[Validate_criteria] --> B5[Load_MC_range]
      B5 --> C5[GenerateDays_TimeSlots]
      C5 --> D5[Filter_working_past_available]
      D5 --> E5o[CalendarDto]
    end

    subgraph e6 [E6_POST_available]
      A6[Load_MC_range] --> B6[Generate_slots]
      B6 --> C6[Filter_IsAvailable_not_past]
    end

    subgraph e7 [E7_POST_appointment_send]
      A7{ScheduleType} -->|Schedule| B7[Create_PendingConfirmation]
      A7 -->|Cancel| C7[Cancel_rules_12h]
    end

    subgraph e8 [E8_POST_appointment_get]
      A8[GetAppointmentsForMonth] --> B8[Map_AppointmentDto_IsPast]
    end
  ```

  #### 3.3.4 Interface de serviço da fachada (assinaturas a preservar)

  ```csharp
  Task<ServiceResponse<GetMedicalCalendarDto>> FindByID(...);
  Task<ServiceResponse<GetMedicalCalendarDto>> Create(AddMedicalCalendarDto);
  Task<ServiceResponse<GetMedicalCalendarDto>> Update(UpdateMedicalCalendarDto);
  Task<ServiceResponse<bool>> DeleteOneOrRecurrence(DeleteMedicalCalendarDto);
  Task<ServiceResponse<CalendarDto>> GetMonthlyCalendar(CalendarCriteriaDto);
  Task<ServiceResponse<CalendarDto>> GetAvailableMedicalCalendar(CalendarCriteriaDto);
  Task<ServiceResponse<bool>> RequestAppointment(ScheduleCriteriaDto);
  Task<ServiceResponse<AppointmentDto[]>> GetAppointments(AppointmentCriteriaDto);
  ```

  O controller medical continua sendo o **único** ponto de integração do frontend SDP com o calendário.

  ### 3.4 Modelo de dados atual

  #### MedicalCalendar

  `EntityBase` + `MedicalId`, `PatientId?`, `Title`, `StartDateTime`, `EndDateTime?`, `IsAllDay`, `Status`, `ColorCategoryHexa`, `IsPushedCalendar`, `TimeZone`, `Location`, `Description`, `RecurrenceDays`, `RecurrenceType`, `RecurrenceEndDate`, `RecurrenceCount`, `TokenRecurrence`, `ReasonCancellation`, users de auditoria.

  #### ScheduleBatch

  `MedicalId`, `PatientId?`, `ScheduleData` (`ScheduleItem[]` → JSON text ≤ ~65KB), `UniqueToken`, `StartPeriod`, `EndPeriod`.

  #### ScheduleItem (JSON only)

  Title, Start/End, IsAllDay, Status, Color, TimeZone, Location, Description, Recurrence*, ReasonCancellation, MedicalId, PatientId.

  ### 3.5 Regras de negócio (preservar no adapter; corrigir implementação)

  #### Conflitos

  1. Create/Update médico: overlap teórico `Start < other.End && End > other.Start`, excluindo mesmo `Id`
  2. **Problema histórico:** query por **contenção** (`Start >= rangeStart AND End <= rangeEnd`) → **falsos negativos**
  3. Helpers/métodos de overlap corretos no repositório existiam e nem sempre eram usados pelos validators
  4. Appointment do paciente: conflito por **mesmo `StartDateTime` exato** (inconsistente com overlap de faixa)
  5. ScheduleBatch e MedicalCalendar historicamente **não cruzavam** na validação de conflito

  **Alvo:** overlap real; no Batch: pruning por `StartPeriod`/`EndPeriod` + overlap in-memory nos `ScheduleItem`.

  #### Recorrência

  - Tipos: `None`, `Daily`, `Weekly`, `Monthly`, `Yearly`
  - Create com recorrência: gera `TokenRecurrence`, materializa N ocorrências em MC (`AddRangeAsync`)
  - Update com `UpdateSeries`: apaga série a partir da semente e regenera
  - Cada ocorrência gerada historicamente **revalidava conflito no banco** (custo alto)
  - Dual-write Batch: deve usar o **mesmo** token e regenerar `ScheduleData` completo

  **Alvo core:** materializar intervals in-memory → **1** write de `ScheduleBatch` (não N rows no core).

  #### Working hours / grade

  - Start/End no futuro (timezone do usuário)
  - Dentro de `WorkingDays` e `StartWorkingTime`–`EndWorkingTime` do médico
  - `RecurrenceDays` ⊆ working days
  - Intervalo de grade: **15–1440** minutos; range de critérios ≤ **90** dias

  #### Appointments (paciente) — regras clínicas no adapter

  | Ação | Regra |
  | ---- | ----- |
  | Agendar | Status `PendingConfirmation`; duração = intervalo do médico; ≥ **23h** de antecedência |
  | Cancelar `PendingConfirmation` | → `Canceled` |
  | Cancelar `Confirmed` | → `PendingCancellation` |
  | Cancelar | Status Confirmed ou PendingConfirmation; ≥ **12h** antes do início |

  Essas regras **permanecem no adapter SDP**, não no core genérico Batch.

  #### Notificações

  - Após create/update: `NotificationRecords` (`BeforeAppointment`)
  - Após create: e-mail via `IMedicalCalenderNotificationService`
  - Delete limpa records por id(s)
  - **Gap histórico:** cancel appointment **não** limpava notificações — corrigir **sem** mudar endpoint E7

  #### Permissões

  - Create/Update: usuário logado deve ser o médico dono
  - List/Delete: ownership alinhado ao usuário / `MedicalId`
  - `GetAvailableMedicalCalendar` historicamente com rigor menor de ownership (gap a alinhar sem quebrar contrato)

  ### 3.6 Gargalos de performance (débito técnico)

  | Problema | Evidência / onde |
  | -------- | ---------------- |
  | DB call / validate por ocorrência na recorrência | `AddEventAsync` → validator → conflito |
  | Query de conflito por contenção (não overlap) | `GetMedicalCalendarsForMedicalAsync` (legado) |
  | N+1 Medical/User nos FluentValidation | `MedicalCalendarValidator` (working days/hours/future) |
  | Slots O(dias × slots × calendários) com `ToList().Find` por slot | `GenerateTimeSlots` |
  | Loop de slots do dia inteiro antes de filtrar horário útil | `GenerateTimeSlots` |
  | Dual-write Create frágil / tokens desalinhados | `migrationProcess` histórico; Guid ≠ `TokenRecurrence` |
  | JSON 65KB + filtro in-memory sem pruning adequado | `ScheduleBatchRepository` |
  | Update/Delete sem sync completo do Batch | débito de ciclo de vida |
  | Dual-write Create fazendo **mais** trabalho (N MC + batch) até cutover de leituras | Create path |

  **Direção de correção (Batch-JSON):**

  - 1 conflict-window (período) + check in-memory nos items gerados
  - `TimeSlotGenerator` só na janela útil + estrutura eficiente para busy
  - `UniqueToken` = `TokenRecurrence`
  - Série = 1 insert/update de `ScheduleBatch`

  ### 3.7 Padrões arquiteturais do host

  Camadas WebAPI → Service → Data → Domain; JWT Bearer; `ServiceResponse<T>`; FluentValidation; notificações Email + job; testes NUnit principalmente em Data/Domain; DI por convenção `*Service` / `*Repository`.

  ---

  ## 4. Arquitetura alvo (to-be) — FE intacto + ScheduleCalendar

  ```mermaid
  flowchart TD
    FE[Angular] -->|"MESMOS_8_endpoints"| API[MedicalCalendarController]
    API --> Facade[ScheduleCalendarFacade]
    Facade --> ActionSvcs[Find_Create_Update_Delete_Grade_Appointment]
    ActionSvcs --> Clinical[Validators_regras_clinicas]
    ActionSvcs --> AgendaSvc[IScheduleCalendarService]
    ActionSvcs --> MCRepo[MedicalCalendarRepository_shadow]
    AgendaSvc --> AS[(ScheduleCalendar)]
    ActionSvcs --> Helpers[Recurrence_Overlap_Slots]
    ActionSvcs --> Notif[NotificationRecords_Email]
    OtherSys[Outros_sistemas] -.->|"IScheduleCalendarService"| AgendaSvc
  ```

  **Regra de ouro:** o Angular **não precisa saber** que o SoT é ScheduleCalendar.  
  **Regra de modelo:** 1 série/lote = **1** `ScheduleCalendar`; N intervalos = N `ScheduleCalendarItem` **dentro** de `ScheduleData`.  
  **Legado:** `ScheduleBatch` não é SoT do path medical.

  ---

  ## 5. Modelo de dados proposto (to-be)

  ### 5.1 Uma tabela core

  #### `ScheduleCalendar`

  | Coluna | Descrição |
  | ------ | --------- |
  | `Id`, `Enable`, datas auditoria | `EntityBase` |
  | `TenantKey`, `OwnerKey`, `SubjectKey?` | Chaves genéricas (ex.: `sdp` / `medical:{id}` / `patient:{id}`) |
  | `UniqueToken` | UK; = `TokenRecurrence` no adapter SDP |
  | `StartPeriod`, `EndPeriod` | Janela do lote (índice / pruning) |
  | `ScheduleData` | JSON `ScheduleCalendarItem[]` (text ~65KB) |

  #### `ScheduleCalendarItem` (somente JSON)

  Title, Start/End, Status, Recurrence*, TimeZone, Location, Description — **sem** MedicalId/PatientId.

  ### 5.2 O que NÃO fazer

  - Não usar `ScheduleOccurrence` / `ScheduleSeries` (1 row por intervalo) como SoT
  - Não usar `ScheduleBatch` (acoplado Medical) como SoT do core genérico
  - Não materializar cada dia como row EF no core
  - Não dropar `MedicalCalendar` na mesma release do cutover

  ### 5.3 Índices

  1. `UX_ScheduleCalendar_UniqueToken` (UNIQUE)  
  2. `IX_ScheduleCalendar_Tenant_Owner_Period`  
  3. Conflict: overlap de período na tabela → overlap in-memory nos items  

  ---

  ## 6. Requisitos funcionais (to-be)

  Prioridade: **P0** = MVP + FE estável; **P1** = cutover; **P2** = multi-sistema.

  ### 6.1 Compatibilidade frontend (P0 absoluto)

  | ID | Requisito | Prioridade |
  | -- | --------- | ---------- |
  | RF-FE-01 | Manter as 8 rotas de `MedicalCalendarController` | P0 |
  | RF-FE-02 | Manter verbos HTTP, path params e bodies | P0 |
  | RF-FE-03 | Manter shapes JSON dos DTOs medical/calendar/appointment | P0 |
  | RF-FE-04 | Manter padrões de status HTTP por action | P0 |
  | RF-FE-05 | Manter HypermediaFilter em E1–E4 | P0 |
  | RF-FE-06 | Regressão black-box dos 8 endpoints | P0 |
  | RF-FE-07 | Proibido exigir mudanças no Angular | P0 |

  ### 6.2 Ciclo de vida / Batch

  | ID | Requisito | Prioridade |
  | -- | --------- | ---------- |
  | RF-01…05,07,09 | CRUD/série via E2–E4; persistir **um** batch com `ScheduleData` materializado in-memory | P0 |
  | RF-BATCH-01 | Core **não** persiste 1 entidade DB por ocorrência de recorrência | P0 |
  | RF-06,08 | Split / exceções de série | P2 |
  | RF-10…14 | Grade/slots via helper; response `CalendarDto` | P0 |
  | RF-16…19 | Overlap real; 1 load de batches na janela + check in-memory | P0 |
  | RF-24 | Agenda = batches por Owner/Tenant (sem tabela Calendar) | P0 |
  | RF-28…30 | Contrato público = medical | P0 |
  | RF-31 | `api/schedule/v1` | P2 |
  | RF-33…40 | Notificações + regras clínicas no adapter (23h/12h, working hours, status) | P0/P1 |

  ---

  ## 7. Requisitos não funcionais

  | ID | Meta / critério |
  | -- | --------------- |
  | RNF-01 | Leitura range (E5/E6): P95 &lt; 100 ms para ≤ 5k items no range (ambiente alvo) — pruning período + expand JSON |
  | RNF-02 | Create série (E2): **1** insert/update batch; **1** conflict-window (não N round-trips) |
  | RNF-03 | Cap configurável de items por `ScheduleData` (limite text ~65KB) |
  | RNF-04 | Zero breaking FE |
  | RNF-05 | Helpers sem I/O; services testáveis |
  | RNF-06 | Extração: reduzir FKs Medical/Patient → keys |
  | RNF-07 | Observabilidade: Stopwatch em create série, conflict, range query |
  | RNF-08 | Notificações fora do caminho crítico (job) |

  ---

  ## 8. Separação de responsabilidades

  | Componente | Papel |
  | ---------- | ----- |
  | `ScheduleCalendarFacade` | Congelado contrato `IScheduleCalendarFacade` |
  | Services por ação | Find / Create / Update / Delete / Grade / Appointment (`Service/Bussines/Schedule/Actions/`) |
  | `IScheduleCalendarService` | SoT CRUD lote / items JSON genérico |
  | Helpers | `RecurrenceMaterializer`, `ScheduleOverlapHelper`, `TimeSlotGenerator`, `ScheduleKeyHelper`, `SchedulePeriodHelper` |
  | `ScheduleCalendarSyncWriter` | Dual-write MC → Agenda (keys) |
  | `ScheduleBatchService` | Legado Obsolete — não usar no path medical |

  ---

  ## 9. Gaps atuais vs alvo

  | Capacidade | Hoje / débito | Alvo |
  | ---------- | ------------- | ---- |
  | SoT | Dual; leituras ainda MC | `ScheduleBatch.ScheduleData` |
  | 1 row/dia no core | MC (e desvio Occurrence) | Proibido |
  | Conflito | Contenção / exact start | Overlap período + items |
  | Performance recorrência / slots | N validates / O(n³) | Batch + generator eficiente |
  | Token | Desalinhado historicamente | `UniqueToken` = `TokenRecurrence` |
  | Update/Delete batch | Incompleto | Sync com série |
  | Cancel + notifications | Gap | Limpar no adapter |
  | Modelo 3 tabelas | Desvio | Removido / não usado |

  ---

  ## 10. Critérios de aceite

  1. Core genérico usa **1 tabela** `ScheduleBatch`; items só em JSON.  
  2. Criar série de 50–100 ocorrências = **1** write de batch (não 50–100 rows core).  
  3. FE: 8 endpoints sem mudança de contrato; regressão E1–E8.  
  4. Conflito usa overlap real (período + items).  
  5. Create série sem N round-trips de validação de conflito.  
  6. E5 mensal atende meta RNF-01 no ambiente de carga.  
  7. `UniqueToken` = `TokenRecurrence` no dual-write.  
  8. Adapter preserva working hours, 23h/12h, status appointment.  
  9. Cancel limpa `NotificationRecords`.  
  10. Código das 3 tabelas normalizadas removido ou não usado.

  ---

  ## 11. Riscos e premissas

  | Risco | Mitigação |
  | ----- | --------- |
  | JSON &gt; 65KB | Cap de items + alerta |
  | Query por campo interno do JSON | Sempre filtrar por período na tabela primeiro |
  | Quebra silenciosa de contrato FE | Freeze + suite E1–E8 |
  | Dados históricos só em MC | Dual-write + job de migração posterior |
  | Domínio clínico no core | Adapter obrigatório |

  **Premissas:** JWT Bearer; MySQL/SqlServer; materialização de recorrência in-memory na v1; FE Angular único consumidor medical.

  ---

  ## 12. Referências

  | Artefato | Path |
  | -------- | ---- |
  | ScheduleBatch / ScheduleItem | `Domain/EntityModels/Schedule/` |
  | ScheduleBatchConfiguration | `Data/Context/Configure/Entity/ScheduleBatchConfiguration.cs` |
  | Adapter | `Service/Bussines/Schedule/Adapters/MedicalCalendarScheduleAdapter.cs` |
  | Controller | `WebAPI/Controllers/v1/Principals/MedicalCalendarController.cs` |
  | Plano | `DOCUMENTACAO/API/FEATURES/2026-08-PlanoImplementacao-ModuloAgendamentoGenerico.md` |

  ---

  **Fim do Levantamento (rev. Batch-JSON + regras/performance).**
