# Análise Técnica — Arquitetura de Testes no .NET 10: NUnit 4 vs Microsoft Testing Platform (MTP v2) / xUnit v4

**Data:** 2026-08-22  
**Documento de Referência:** [GuiaGenericoAtualizacaoPacotes.md](file:///c:/git/SMARTDIGITALPSICO/SmartDigitalPsicoAPI/DOCUMENTACAO/UpdatePackages/GuiaGenericoAtualizacaoPacotes.md)  
**Solução:** [SmartDigitalPsicoAPI.sln](file:///c:/git/SMARTDIGITALPSICO/SmartDigitalPsicoAPI/SmartDigitalPsicoAPI.sln)  
**Escopo:** Suíte de Testes Automatizados (.NET 10)  

---

## 1. Resumo Executivo

Durante a governança e evolução de pacotes do backend **SmartDigitalPsicoAPI** no runtime **.NET 10**, foi realizada uma análise aprofundada dos frameworks e runners de testes disponíveis no ecossistema .NET.

A solução **SmartDigitalPsicoAPI** padroniza integralmente seus **7 projetos de teste** em **NUnit 4.6.1**, utilizando o adaptador estável **`NUnit3TestAdapter 6.2.0`** sob o motor **VSTest (`dotnet test`)**.

Esta análise técnica documenta:
1. Por que frameworks baseados na **Microsoft Testing Platform v2 (MTP v2)** (como o `xUnit 4.0.0`) exigem quebras arquiteturais significativas no .NET 10 SDK.
2. A decisão de governança de manter a suíte consolidada e homologada em **NUnit 4.6.1 + VSTest**, garantindo execução transparente via CLI, Visual Studio, scripts de cobertura (`coverlet`) e pipelines de CI/CD.

---

## 2. Diagnóstico Técnico — Desafios do MTP v2 no .NET 10 SDK

Ao avaliar runners baseados na nova engine **Microsoft Testing Platform (MTP v2)** no .NET 10 SDK, foram identificados os seguintes bloqueios impeditivos:

### 2.1 Incompatibilidade de Execução com VSTest no .NET 10 SDK

No .NET 10 SDK, o suporte ao target legado do `VSTest` foi descontinuado pelo MTP v2 quando invocado através do comando tradicional `dotnet test` sem configurações de opt-in explícitas:

```text
Microsoft.Testing.Platform.MSBuild.targets: 
error : Testing with VSTest target is no longer supported by Microsoft.Testing.Platform on .NET 10 SDK and later. 
If you use dotnet test, you should opt-in to the new dotnet test experience. 
For more information, see https://aka.ms/dotnet-test-mtp-error
```

### 2.2 Conflito de Versões e Analisadores em Central Package Management (CPM)

Projetos que migram para o MTP v2 exigem pacotes coordenados de analisadores estáticos e geradores de código. Quando o repositório adota **Central Package Management (`Directory.Packages.props`)**, a mistura de referências ou analisadores transitivos gera erros do tipo `NU1109` (downgrade de pacote detectado) e falhas no restore.

### 2.3 Impacto na Coleta de Cobertura de Código (`coverlet`) e CI/CD

O runner MTP v2 substitui a engine tradicional de execução de testes por executáveis diretos do projeto. Isso impacta ferramentas consolidadas de coleta de cobertura como:
- `coverlet.collector` (`/p:CollectCoverage=true`)
- `coverlet.msbuild`
- Exportação de relatórios OpenCover/Cobertura consumidos pelo script [analyze_coverage.ps1](file:///c:/git/SMARTDIGITALPSICO/SmartDigitalPsicoAPI/analyze_coverage.ps1) e pelas tasks do Azure DevOps (`DotNetCoreCLI@2` / `PublishCodeCoverageResults@2`).

---

## 3. Padrão Homologado no SmartDigitalPsicoAPI

A governança de dependências do repositório ([GuiaGenericoAtualizacaoPacotes.md](file:///c:/git/SMARTDIGITALPSICO/SmartDigitalPsicoAPI/DOCUMENTACAO/UpdatePackages/GuiaGenericoAtualizacaoPacotes.md)) estabelece como padrão oficial da solução a stack **NUnit 4**:

| Componente | Pacote / Ferramenta | Versão Homologada | Status |
| ---------- | ------------------- | ------------------ | ------ |
| **Test Runner** | `Microsoft.NET.Test.Sdk` | **`18.8.1`** | Estável / VSTest |
| **Framework de Testes** | `NUnit` | **`4.6.1`** | Estável (.NET 10) |
| **Adaptador de Testes** | `NUnit3TestAdapter` | **`6.2.0`** | Totalmente integrado ao `dotnet test` |
| **Analisadores** | `NUnit.Analyzers` | **`4.14.0`** | Alinhado ao NUnit 4 |
| **Mocking** | `Moq` | **`4.20.72`** | Estável |
| **Mocking EF Core** | `Moq.EntityFrameworkCore` | **`9.0.0.10`** | Alinhado ao EF Core 9 (Bloco B) |
| **Asserções Fluentes** | `AwesomeAssertions` | **`9.5.0`** | Estável |
| **Cobertura de Código** | `coverlet.collector` / `coverlet.msbuild` | **`10.0.1`** | Integrado a relatórios OpenCover |

---

## 4. Validação da Suíte de Testes

A execução completa de todos os 7 projetos de teste da solução confirma 100% de estabilidade:

```powershell
dotnet test SmartDigitalPsicoAPI.sln -c Release
```

**Resultado Consolidado:**

| Projeto de Teste | Quantidade de Testes | Status |
| ---------------- | -------------------- | ------ |
| [SmartDigitalPsico.Domain.Test](file:///c:/git/SMARTDIGITALPSICO/SmartDigitalPsicoAPI/SmartDigitalPsico.Domain.Test/SmartDigitalPsico.Domain.Test.csproj) | **569** | 100% Aprovados |
| [SmartDigitalPsico.Service.Test](file:///c:/git/SMARTDIGITALPSICO/SmartDigitalPsicoAPI/SmartDigitalPsico.Service.Test/SmartDigitalPsico.Service.Test.csproj) | **448** | 100% Aprovados |
| [SmartDigitalPsico.Core.SDK.Tests](file:///c:/git/SMARTDIGITALPSICO/SmartDigitalPsicoAPI/SmartDigitalPsico.Core.SDK.Tests/SmartDigitalPsico.Core.SDK.Tests.csproj) | **141** | 100% Aprovados |
| [SmartDigitalPsico.Data.Test](file:///c:/git/SMARTDIGITALPSICO/SmartDigitalPsicoAPI/SmartDigitalPsico.Data.Test/SmartDigitalPsico.Data.Test.csproj) | **126** | 100% Aprovados |
| [SmartDigitalPsico.WebAPI.Test](file:///c:/git/SMARTDIGITALPSICO/SmartDigitalPsicoAPI/SmartDigitalPsico.WebAPI.Test/SmartDigitalPsico.WebAPI.Test.csproj) | **27** | 100% Aprovados |
| [SmartDigitalPsico.WebJob.Test](file:///c:/git/SMARTDIGITALPSICO/SmartDigitalPsicoAPI/SmartDigitalPsico.WebJob.Test/SmartDigitalPsico.WebJob.Test.csproj) | **18** | 100% Aprovados |
| [SmartDigitalPsico.WindowsService.Test](file:///c:/git/SMARTDIGITALPSICO/SmartDigitalPsicoAPI/SmartDigitalPsico.WindowsService.Test/SmartDigitalPsico.WindowsService.Test.csproj) | **15** | 100% Aprovados |
| **Total Geral da Solução** | **1.344** | **1.344 Aprovados (0 Falhas)** |

---

## 5. Diretrizes para Futuras Avaliações de MTP

Caso a Microsoft Testing Platform amadureça nos ecossistemas NUnit/VSTest e o time decida realizar um ciclo de avaliação:

1. **Configuração de Opt-In no `.csproj` / `Directory.Build.props`:**
   ```xml
   <PropertyGroup>
     <TestingPlatformDotnetTestSupport>true</TestingPlatformDotnetTestSupport>
     <TestingPlatformCaptureOutput>false</TestingPlatformCaptureOutput>
   </PropertyGroup>
   ```
2. **Atualização Coordenada no `Directory.Packages.props`:**
   Garantir alinhamento entre adapters, analisadores e pacotes de plataforma sem conflitos de CPM.
3. **Validação da Coleta de Cobertura:**
   Validar compatibilidade do `coverlet` ou transição para `Microsoft.Testing.Extensions.CodeCoverage`.
4. **Validação no Pipeline CI/CD:**
   Garantir que os passos de teste no Azure DevOps (`DotNetCoreCLI@2`) publiquem os resultados TRX e cobertura sem perda de rastreabilidade.
