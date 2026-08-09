# Padrões de Código — SmartDigitalPsicoAPI

## Diretivas `using` — Regras obrigatórias

| Regra | Diagnóstico | Configuração |
|---|---|---|
| Remover `using` não utilizados | `IDE0005` | `.editorconfig` |
| Ordenar e formatar `using` | `IDE0055` | `.editorconfig` |
| `using` fora do bloco `namespace` | `IDE0065` | `.editorconfig` |
| `System.*` sempre primeiro | — | `dotnet_sort_system_directives_first = true` |

---

## Comandos `dotnet format`

### Corrigir automaticamente (modo manual)

```bash
dotnet format SmartDigitalPsicoAPI.sln --diagnostics IDE0005 IDE0055 IDE0065 --severity info
```

- Remove `using` desnecessários
- Ordena os `using` (`System.*` primeiro)
- Garante que `using` fique fora do namespace

### Verificar sem alterar (modo verificação)

```bash
dotnet format SmartDigitalPsicoAPI.sln --diagnostics IDE0005 IDE0055 IDE0065 --severity info --verify-no-changes
```

---

## Ordenação esperada dos `using`

```csharp
// 1. System.* primeiro
using System;
using System.Collections.Generic;
using System.Reflection;

// 2. Demais namespaces em ordem alfabética
using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
using SmartDigitalPsico.Domain.Interfaces.Common;
```

> Configurado via `dotnet_sort_system_directives_first = true` no `.editorconfig`.

---

## Arquivos de configuração

| Arquivo | Função |
|---|---|
| `.editorconfig` | Regras IDE0005, IDE0055, IDE0065, ordenação |
