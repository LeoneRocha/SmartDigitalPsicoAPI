# SmartDigitalPsico.Core.SDK — Especificação Técnica: API

Especificação técnica da camada **API** do pacote `SmartDigitalPsico.Core.SDK` (`SmartDigitalPsico.Core.SDK.API`).

---

## 1. Visão Geral

A camada de API do SDK fornece classes base, atributos, filtros de requisição e convenções para os controladores HTTP do ecossistema SmartDigitalPsico (utilizados principalmente por `SmartDigitalPsico.WebAPI`).

### Objetivos

- Padronizar respostas REST com status HTTP consistentes (`200 OK`, `201 Created`, `400 BadRequest`, `401 Unauthorized`, `404 NotFound`, etc.).
- Tratar internacionalização e cultura (`CultureInfo`) em tempo de execução via cabeçalhos HTTP (`Accept-Language`).
- Fornecer utilitários de extração de dados da sessão e claims do usuário autenticado.

---

## 2. Estrutura de Arquivos e Classes

```text
SmartDigitalPsico.Core.SDK/
└── API/
    ├── ApiBaseController.cs
    └── LanguageActionFilterAttribute.cs
```

---

## 3. Especificação dos Componentes

### 3.1 `ApiBaseController`

Classe abstrata base derivada de `Microsoft.AspNetCore.Mvc.ControllerBase`. Todos os controllers de API da solução derivam direta ou indiretamente desta classe.

```csharp
namespace SmartDigitalPsico.Core.SDK.API
{
    [ApiController]
    public abstract class ApiBaseController : ControllerBase
    {
        // Utilitários de Resposta
        protected IActionResult ResponseResult<T>(ServiceResponse<T> serviceResponse);
        protected IActionResult CustomResponse(ModelStateDictionary modelState);
        protected IActionResult CustomResponse(ServiceResponse<object> serviceResponse);
        
        // Identificação e Cultura
        protected string GetCultureHeader();
        protected long? GetUserId();
        protected string? GetUserEmail();
        protected string? GetUserRole();
    }
}
```

#### Comportamento e Funcionalidades:

1. **Processamento de `ServiceResponse<T>`:**
   - Se `serviceResponse.Success == true` e `serviceResponse.Data != null`: Retorna `Ok(serviceResponse.Data)` ou `Ok(serviceResponse)`.
   - Se `serviceResponse.Unauthorized == true`: Retorna `Unauthorized(serviceResponse)`.
   - Se `serviceResponse.Success == false`: Retorna `BadRequest(serviceResponse)`.
2. **Validação de ModelState:**
   - Converte erros de validação do modelo ASP.NET em uma lista padronizada de `ErrorResponse` encapsulada em `ServiceResponse`.
3. **Extração de Claims:**
   - Métodos auxiliares para ler com segurança `UserId`, `Email` e `Roles` a partir do `HttpContext.User.Claims`.

---

### 3.2 `LanguageActionFilterAttribute`

Filtro de ação (`ActionFilterAttribute`) que intercepta requisições HTTP para definir a cultura da thread de execução de acordo com o cabeçalho `Accept-Language` ou parâmetro de rota.

```csharp
namespace SmartDigitalPsico.Core.SDK.API
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, Inherited = true, AllowMultiple = false)]
    public class LanguageActionFilterAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext context);
    }
}
```

#### Comportamento:

- Lê o cabeçalho `Accept-Language` da requisição HTTP atual.
- Convalida e atribui a cultura (`CultureInfo.CurrentCulture` e `CultureInfo.CurrentUICulture`) correspondente suportada pela aplicação (ex.: `pt-BR`, `en-US`, `es-ES`).
- Caso nenhum cabeçalho válido seja enviado, assume o fallback padrão (`pt-BR`).

---

## 4. Integração com a WebAPI

No projeto `SmartDigitalPsico.WebAPI`, o controller herda de `ApiBaseController`:

```csharp
[ApiController]
[Route("api/[controller]")]
[Authorize("Bearer")]
[ServiceFilter(typeof(LanguageActionFilterAttribute))]
public class PatientController : ApiBaseController
{
    private readonly IPatientService _patientService;

    public PatientController(IPatientService patientService)
    {
        _patientService = patientService;
    }

    [HttpGet("{id:long}")]
    [ProducesResponseType(typeof(ServiceResponse<PatientVO>), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(ServiceResponse<PatientVO>), StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> FindById(long id)
    {
        var response = await _patientService.FindById(id);
        return ResponseResult(response);
    }
}
```

---

## 5. Relações com Outros Documentos

- [Levantamento Técnico](./SmartDigitalPsico.Core.SDK.Levantamento.md)
- [Especificação - Domain](./SmartDigitalPsico.Core.SDK.Especificacao.Domain.md)
- [Especificação - Service](./SmartDigitalPsico.Core.SDK.Especificacao.Service.md)
- [Plano de Implementação - API](./SmartDigitalPsico.Core.SDK.PlanoImplementacao.API.md)
