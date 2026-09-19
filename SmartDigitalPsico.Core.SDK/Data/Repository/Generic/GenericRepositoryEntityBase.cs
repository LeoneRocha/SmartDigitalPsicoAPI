using Microsoft.EntityFrameworkCore;
using SmartCoreHub.Core.SDK.Common.Attributes;
using SmartDigitalPsico.Core.SDK.Data.Context.Interface;
using SmartDigitalPsico.Core.SDK.Domain.Contracts;
using SmartDigitalPsico.Core.SDK.Domain.Interfaces.Repository;
using Sch = SmartCoreHub.Core.SDK.Infrastructure.Data;

namespace SmartDigitalPsico.Core.SDK.Data.Repository.Generic;

/// <summary>
/// Casca GenericRepositoryEntityBase — herda a impl SCH já portada.
/// </summary>
[SdkWrappedSource(
    targetType: "SmartCoreHub.Core.SDK.Infrastructure.Data.GenericRepositoryEntityBase`1",
    targetPackage: "SmartCoreHub.Core.SDK",
    description: "AJ.1: herda SCH GenericRepositoryEntityBase; constraint EntityBase SDP.")]
public abstract class GenericRepositoryEntityBase<T>
    : Sch.GenericRepositoryEntityBase<T>, IEntityBaseRepository<T>
    where T : EntityBase
{
    /// <summary>Cria o repositório a partir de <see cref="IEntityDataContext"/>.</summary>
    protected GenericRepositoryEntityBase(IEntityDataContext context)
        : base(context)
    {
    }

    /// <summary>Conveniência para DbContext concreto (produção tipada / testes InMemory).</summary>
    protected GenericRepositoryEntityBase(DbContext context)
        : base(context)
    {
    }

    /// <summary>Construtor para mocks de teste que fornecem DbSet diretamente.</summary>
    protected GenericRepositoryEntityBase(DbSet<T> dataset, IEntityDataContext? context = null)
        : base(dataset, context)
    {
    }

    /// <summary>Construtor para mocks com DbContext opcional.</summary>
    protected GenericRepositoryEntityBase(DbSet<T> dataset, DbContext? context)
        : base(dataset, context)
    {
    }
}
