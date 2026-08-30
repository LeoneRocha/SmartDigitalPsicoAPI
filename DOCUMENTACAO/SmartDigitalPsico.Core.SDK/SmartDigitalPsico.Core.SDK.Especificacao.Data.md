# SmartDigitalPsico.Core.SDK — Especificação Técnica: Data

Especificação técnica da camada **Data** do pacote `SmartDigitalPsico.Core.SDK` (`SmartDigitalPsico.Core.SDK.Data`).

---

## 1. Visão Geral

A camada de dados do SDK encapsula o acesso ao banco de dados relacional através do Entity Framework Core, repositórios de cache (memória e disco), gerenciamento de arquivos e persistência de dados semiestruturados em tabelas e filas NoSQL (Azure Storage).

### Objetivos

- Fornecer um repositório genérico assíncrono para entidades derivadas de `EntityBase`.
- Abstrair o contexto do Entity Framework Core (`DbContext`) por meio da interface `IEntityDataContext`.
- Padronizar configurações de mapeamento EF Core (`EntityBaseConfiguration`), charsets e comparadores de valor.
- Disponibilizar repositórios de cache local (Memory/Disk) e repositórios de storage NoSQL (Azure Table e Queue).

---

## 2. Estrutura de Pastas e Componentes

```text
SmartDigitalPsico.Core.SDK/
└── Data/
    ├── Context/
    │   ├── Configure/
    │   │   ├── Helper/
    │   │   │   ├── CollectionValueComparerHelper.cs
    │   │   │   ├── HelperCharSet.cs
    │   │   │   └── ModelBuilderExtensions.cs
    │   │   └── EntityBaseConfiguration.cs
    │   ├── Interface/
    │   │   └── IEntityDataContext.cs
    │   └── DbContextEntityDataContextAdapter.cs
    ├── Repository/
    │   ├── CacheManager/
    │   │   ├── DiskCacheRepository.cs
    │   │   └── MemoryCacheRepository.cs
    │   ├── FileManager/
    │   │   └── FileDiskRepository.cs
    │   ├── Generic/
    │   │   └── GenericRepositoryEntityBase.cs
    │   └── Infrastructure/
    │       └── GenericStorageQueueRepository.cs
    └── TableEntityRepository/
        └── GenericTableEntityRepository.cs
```

---

## 3. Especificação dos Componentes

### 3.1 Contexto e Mapeamento EF Core

#### `IEntityDataContext` e `DbContextEntityDataContextAdapter`
Abstração que permite aos repositórios genéricos acessar `Set<TEntity>()`, `SaveChangesAsync()`, `Database` e `Entry()` sem acoplamento direto a um tipo de `DbContext` específico.

```csharp
namespace SmartDigitalPsico.Core.SDK.Data.Context.Interface
{
    public interface IEntityDataContext : IDisposable
    {
        DbSet<TEntity> Set<TEntity>() where TEntity : class;
        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
        EntityEntry<TEntity> Entry<TEntity>(TEntity entity) where TEntity : class;
        DatabaseFacade Database { get; }
    }
}
```

#### `EntityBaseConfiguration<TEntity>`
Classe de configuração `IEntityTypeConfiguration<TEntity>` que aplica as regras padrão para entidades `EntityBase`:
- `Id`: Chave primária obrigatória (ValueGeneratedOnAdd).
- `Enable`: Booleano obrigatório com valor padrão `true`.
- `CreatedDate`: DateTime obrigatório com valor padrão UTC.
- `ModifyDate`: DateTime opcional.
- `LastAccessDate`: DateTime opcional.

#### Helpers de Contexto:
- `CollectionValueComparerHelper`: Comparadores para serialização de coleções primitivas em colunas JSON/texto no EF Core.
- `HelperCharSet`: Definição padronizada de charsets e collations (`utf8mb4`, `latin1`, etc.).
- `ModelBuilderExtensions`: Métodos de extensão para aplicar convenções globais de nomenclatura e tipos nos modelos do EF Core.

---

### 3.2 Repositório Genérico Relacional

#### `GenericRepositoryEntityBase<T>`
Implementa `IEntityBaseRepository<T>` fornecendo operações completas de CRUD assíncrono:

```csharp
namespace SmartDigitalPsico.Core.SDK.Data.Repository.Generic
{
    public class GenericRepositoryEntityBase<T> : IEntityBaseRepository<T> where T : EntityBase
    {
        public virtual async Task<T> Create(T item);
        public virtual async Task<T> Update(T item);
        public virtual async Task<bool> Delete(long id);
        public virtual async Task<T?> FindByID(long id);
        public virtual async Task<List<T>> FindAll();
        public virtual async Task<bool> Exists(long id);
        public virtual async Task<PagedSearchVO<T>> FindWithPagedSearch(
            string sortFields, string sortDirections, int pageSize, int page, 
            Expression<Func<T, bool>>? filter = null, 
            Func<IQueryable<T>, IIncludableQueryable<T, object>>? includes = null);
    }
}
```

- **Características:**
  - Atualização automática de `ModifyDate` e `LastAccessDate`.
  - Suporte a `includes` fortemente tipados para eager loading de relacionamentos.
  - Suporte a ordenação dinâmica e paginação com contagem total de registros.

---

### 3.3 Repositórios de Cache e Arquivo

| Componente | Interface | Descrição |
| ---------- | --------- | --------- |
| `MemoryCacheRepository` | `IMemoryCacheRepository` | Cache em memória volátil via `IMemoryCache` com expiração configurável. |
| `DiskCacheRepository` | `IDiskCacheRepository` | Cache persistente serializado em disco para cenários offline ou persistência local. |
| `FileDiskRepository` | `IFileDiskRepository` | Gravação, leitura, exclusão e verificação de arquivos físicos em diretórios do servidor. |

---

### 3.4 Repositórios Azure NoSQL

- **`GenericTableEntityRepository`:** Repositório para inserção, consulta, atualização e exclusão em tabelas do **Azure Table Storage** (`ITableBaseEntity`).
- **`GenericStorageQueueRepository`:** Repositório para envio, leitura, remoção e monitoramento de mensagens no **Azure Queue Storage**.

---

## 4. Integração com a Camada Data do Produto

No projeto `SmartDigitalPsico.Data`, os repositórios específicos estendem `GenericRepositoryEntityBase<T>`:

```csharp
public class PatientRepository : GenericRepositoryEntityBase<Patient>, IPatientRepository
{
    public PatientRepository(SmartDigitalPsicoDataContext context) : base(context)
    {
    }

    public async Task<Patient?> FindByCpf(string cpf)
    {
        return await _dataset.AsNoTracking().FirstOrDefaultAsync(p => p.Cpf == cpf);
    }
}
```

---

## 5. Relações com Outros Documentos

- [Levantamento Técnico](./SmartDigitalPsico.Core.SDK.Levantamento.md)
- [Especificação - Domain](./SmartDigitalPsico.Core.SDK.Especificacao.Domain.md)
- [Especificação - Service](./SmartDigitalPsico.Core.SDK.Especificacao.Service.md)
- [Plano de Implementação - Data](./SmartDigitalPsico.Core.SDK.PlanoImplementacao.Data.md)
