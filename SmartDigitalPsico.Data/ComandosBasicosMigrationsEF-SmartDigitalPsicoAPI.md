# Comandos básicos — Migrations EF Core (SmartDigitalPsicoAPI)

**Projeto de dados:** `SmartDigitalPsico.Data`  
**Startup:** `SmartDigitalPsico.WebAPI`  
**Providers:** MySQL (Pomelo) e SQL Server  

## Estrutura de pastas

```text
SmartDigitalPsicoAPI/
├── SmartDigitalPsico.Data/
│   ├── Context/
│   │   ├── SmartDigitalPsicoDataContextMySql.cs
│   │   └── SmartDigitalPsicoDataContextSqlServer.cs
│   └── Migrations/
│       ├── MySql/          ← migrations MySQL (Pomelo)
│       └── SqlServer/      ← migrations SQL Server
└── SmartDigitalPsico.WebAPI/   ← startup-project (connection strings + TypeDataBase)
```

| Provider   | Context                            | Pasta de saída           | `TypeDataBase` |
| ---------- | ---------------------------------- | ------------------------ | -------------- |
| MySQL      | `SmartDigitalPsicoDataContextMySql` | `Migrations/MySql`       | `1` (`Mysql`)  |
| SQL Server | `SmartDigitalPsicoDataContextSqlServer` | `Migrations/SqlServer` | `0` (`MSsqlServer`) |

Connection strings (em `appsettings` / `appsettings.Development.json`):

- MySQL: `ConnectionStrings:SmartDigitalPsicoDBConnectionMySQL`
- SQL Server: `ConnectionStrings:SmartDigitalPsicoDBConnectionSQLServer`
- Tipo ativo: `DataBaseConfigurations:TypeDataBase`

## Pré-requisitos

Rodar **na raiz** `SmartDigitalPsicoAPI/`:

```powershell
cd c:\git\SMARTDIGITALPSICO\SmartDigitalPsicoAPI
dotnet tool restore   # se usar manifesto local
dotnet ef --version   # precisa da ferramenta global ou local
```

Instalar a ferramenta (se necessário):

```powershell
dotnet tool install --global dotnet-ef
# ou alinhar à versão do EF do projeto, ex.:
dotnet tool update --global dotnet-ef --version 9.0.18
```

Definir ambiente para carregar `appsettings.Development.json`:

```powershell
$env:ASPNETCORE_ENVIRONMENT = "Development"
```

> O log `HostAbortedException` / `The host was aborted` durante `dotnet ef` é **esperado** (design-time). Não indica falha se o comando terminar com `Done.`

---

## 1. Listar migrations

### MySQL

```powershell
dotnet ef migrations list `
  --project SmartDigitalPsico.Data/SmartDigitalPsico.Data.csproj `
  --startup-project SmartDigitalPsico.WebAPI/SmartDigitalPsico.WebAPI.csproj `
  --context SmartDigitalPsicoDataContextMySql
```

### SQL Server

```powershell
dotnet ef migrations list `
  --project SmartDigitalPsico.Data/SmartDigitalPsico.Data.csproj `
  --startup-project SmartDigitalPsico.WebAPI/SmartDigitalPsico.WebAPI.csproj `
  --context SmartDigitalPsicoDataContextSqlServer
```

---

## 2. Adicionar migration

**Não edite manualmente** o `.cs` gerado (exceto revisão pontual justificada). Sempre use o CLI.

### MySQL — primeira criação (banco vazio)

```powershell
dotnet ef migrations add InitialCreateMySql `
  --project SmartDigitalPsico.Data/SmartDigitalPsico.Data.csproj `
  --startup-project SmartDigitalPsico.WebAPI/SmartDigitalPsico.WebAPI.csproj `
  --context SmartDigitalPsicoDataContextMySql `
  --output-dir Migrations/MySql
```

### MySQL — mudanças incrementais de schema

```powershell
dotnet ef migrations add NomeDaAlteracao `
  --project SmartDigitalPsico.Data/SmartDigitalPsico.Data.csproj `
  --startup-project SmartDigitalPsico.WebAPI/SmartDigitalPsico.WebAPI.csproj `
  --context SmartDigitalPsicoDataContextMySql `
  --output-dir Migrations/MySql
```

Arquivos gerados em `SmartDigitalPsico.Data/Migrations/MySql/`:

- `{timestamp}_NomeDaAlteracao.cs`
- `{timestamp}_NomeDaAlteracao.Designer.cs`
- `SmartDigitalPsicoDataContextMySqlModelSnapshot.cs` (atualizado)

### SQL Server — equivalente

```powershell
dotnet ef migrations add InitialCreateSqlServer `
  --project SmartDigitalPsico.Data/SmartDigitalPsico.Data.csproj `
  --startup-project SmartDigitalPsico.WebAPI/SmartDigitalPsico.WebAPI.csproj `
  --context SmartDigitalPsicoDataContextSqlServer `
  --output-dir Migrations/SqlServer
```

```powershell
dotnet ef migrations add NomeDaAlteracao `
  --project SmartDigitalPsico.Data/SmartDigitalPsico.Data.csproj `
  --startup-project SmartDigitalPsico.WebAPI/SmartDigitalPsico.WebAPI.csproj `
  --context SmartDigitalPsicoDataContextSqlServer `
  --output-dir Migrations/SqlServer
```

---

## 3. Atualizar o banco (`database update`)

Aplica migrations **pendentes** no banco configurado pela connection string do startup.

### MySQL

```powershell
dotnet ef database update `
  --project SmartDigitalPsico.Data/SmartDigitalPsico.Data.csproj `
  --startup-project SmartDigitalPsico.WebAPI/SmartDigitalPsico.WebAPI.csproj `
  --context SmartDigitalPsicoDataContextMySql
```

### SQL Server

```powershell
dotnet ef database update `
  --project SmartDigitalPsico.Data/SmartDigitalPsico.Data.csproj `
  --startup-project SmartDigitalPsico.WebAPI/SmartDigitalPsico.WebAPI.csproj `
  --context SmartDigitalPsicoDataContextSqlServer
```

### Atualizar até uma migration específica

```powershell
dotnet ef database update 20260801192347_InitialCreateMySql `
  --project SmartDigitalPsico.Data/SmartDigitalPsico.Data.csproj `
  --startup-project SmartDigitalPsico.WebAPI/SmartDigitalPsico.WebAPI.csproj `
  --context SmartDigitalPsicoDataContextMySql
```

### Voltar ao estado “sem migrations” (drop schema via history)

```powershell
dotnet ef database update 0 `
  --project SmartDigitalPsico.Data/SmartDigitalPsico.Data.csproj `
  --startup-project SmartDigitalPsico.WebAPI/SmartDigitalPsico.WebAPI.csproj `
  --context SmartDigitalPsicoDataContextMySql
```

> Em runtime, a WebAPI também chama `Database.Migrate()` no startup (`addAutoMigrate`). Em produção, o deploy aplica o que estiver no assembly; use o CLI em local/homolog para controlar o que sobe.

---

## 4. Remover a última migration

Remove **apenas a última** migration do projeto (arquivos + snapshot). Só funciona se ela **ainda não foi aplicada** no banco alvo — ou use `--force` com cuidado.

### MySQL

```powershell
dotnet ef migrations remove `
  --project SmartDigitalPsico.Data/SmartDigitalPsico.Data.csproj `
  --startup-project SmartDigitalPsico.WebAPI/SmartDigitalPsico.WebAPI.csproj `
  --context SmartDigitalPsicoDataContextMySql
```

Se já estiver aplicada e quiser forçar a remoção dos arquivos (o banco **não** é revertido automaticamente):

```powershell
dotnet ef migrations remove --force `
  --project SmartDigitalPsico.Data/SmartDigitalPsico.Data.csproj `
  --startup-project SmartDigitalPsico.WebAPI/SmartDigitalPsico.WebAPI.csproj `
  --context SmartDigitalPsicoDataContextMySql
```

Nesse caso, alinhe o banco antes: `database update` para a migration anterior, ou `database update 0` + recriar.

### SQL Server

```powershell
dotnet ef migrations remove `
  --project SmartDigitalPsico.Data/SmartDigitalPsico.Data.csproj `
  --startup-project SmartDigitalPsico.WebAPI/SmartDigitalPsico.WebAPI.csproj `
  --context SmartDigitalPsicoDataContextSqlServer
```

---

## 5. Fluxo recomendado (banco apagado / recriado)

1. Garantir pastas `Migrations/MySql` (e/ou `SqlServer`) limpas **ou** sem migrations antigas incompatíveis.
2. `ASPNETCORE_ENVIRONMENT=Development` e connection string apontando para o banco novo.
3. `dotnet ef migrations add InitialCreateMySql ... --output-dir Migrations/MySql`
4. `dotnet ef database update ... --context SmartDigitalPsicoDataContextMySql`
5. `dotnet ef migrations list ...` — confirmar a migration listada/aplicada.

**Não** substitua um `InitialCreate` já aplicado em produção por outro com o mesmo propósito sem limpar o banco ou sem alinhar `__EFMigrationsHistory` — isso causa erros do tipo `Table '...' already exists`.

### Seeds / HasData — datas estáticas

Mocks em `SmartDigitalPsico.Data/Context/Configure/Mock/` devem usar `MockSeedDates.SeedUtc` (nunca `DateTime.Now` / `DateHelper.GetDateTimeNowFromUtc()` / `CreatePasswordHash` em seed). Caso contrário, cada `migrations add` gera `UpdateData` espúrio.

Validação: gerar migration temporária; se `Up`/`Down` vazios, o modelo está estável — remover com `migrations remove --force`.

---

## 6. Script SQL (opcional)

Gerar script sem aplicar:

```powershell
dotnet ef migrations script `
  --project SmartDigitalPsico.Data/SmartDigitalPsico.Data.csproj `
  --startup-project SmartDigitalPsico.WebAPI/SmartDigitalPsico.WebAPI.csproj `
  --context SmartDigitalPsicoDataContextMySql `
  --output ./Migrations/MySql/script.sql
```

De uma migration até outra:

```powershell
dotnet ef migrations script 0 InitialCreateMySql `
  --project SmartDigitalPsico.Data/SmartDigitalPsico.Data.csproj `
  --startup-project SmartDigitalPsico.WebAPI/SmartDigitalPsico.WebAPI.csproj `
  --context SmartDigitalPsicoDataContextMySql `
  --output ./Migrations/MySql/script-from-empty.sql
```

---

## 7. Checklist rápido

| Ação              | Comando-chave                                      | Context / output-dir        |
| ----------------- | -------------------------------------------------- | --------------------------- |
| Listar            | `dotnet ef migrations list`                        | `--context` correto         |
| Adicionar         | `dotnet ef migrations add Nome`                    | `--output-dir Migrations/MySql` ou `SqlServer` |
| Aplicar no banco  | `dotnet ef database update`                        | mesmo `--context`           |
| Remover última    | `dotnet ef migrations remove`                      | mesmo `--context`           |
| Script            | `dotnet ef migrations script`                      | mesmo `--context`           |

Sempre informar:

- `--project SmartDigitalPsico.Data/SmartDigitalPsico.Data.csproj`
- `--startup-project SmartDigitalPsico.WebAPI/SmartDigitalPsico.WebAPI.csproj`
- `--context` do provider desejado
- `--output-dir` alinhado à pasta do provider (ao **adicionar**)

---

## Referência da execução (2026-08-01)

Banco MySQL recriado do zero. Comandos executados (sem edição manual dos arquivos gerados):

```powershell
$env:ASPNETCORE_ENVIRONMENT = "Development"

dotnet ef migrations add InitialCreateMySql `
  --project SmartDigitalPsico.Data/SmartDigitalPsico.Data.csproj `
  --startup-project SmartDigitalPsico.WebAPI/SmartDigitalPsico.WebAPI.csproj `
  --context SmartDigitalPsicoDataContextMySql `
  --output-dir Migrations/MySql

dotnet ef database update `
  --project SmartDigitalPsico.Data/SmartDigitalPsico.Data.csproj `
  --startup-project SmartDigitalPsico.WebAPI/SmartDigitalPsico.WebAPI.csproj `
  --context SmartDigitalPsicoDataContextMySql
```

Resultado: `20260801192347_InitialCreateMySql` criada em `Migrations/MySql/` e aplicada no banco.
