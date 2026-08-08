using SmartDigitalPsico.Domain.ModelEntity;

using LeavesEntity = SmartDigitalPsico.Domain.ModelEntity.Leaves;

namespace SmartDigitalPsico.Domain.Interfaces.Leaves
{
    /// <summary>
    /// Interface (contrato) responsável por ILeavesRepository.
    /// Responsabilidade: repositório de persistência.
    /// Relação: integra as camadas Domain/Data/Service/WebAPI do SmartDigitalPsico.
    /// </summary>
    public interface ILeavesRepository : SmartDigitalPsico.Core.SDK.Domain.Interfaces.Repository.IEntityBaseRepository<LeavesEntity>
    { 
    }
} 
