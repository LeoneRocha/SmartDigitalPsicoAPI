using SmartDigitalPsico.Domain.EntityModels;

namespace SmartDigitalPsico.Domain.Interfaces.Medical
{
    /// <summary>
    /// Interface (contrato) responsável por IMedicalSettingsRepository.
    /// Responsabilidade: repositório de persistência.
    /// Relação: integra as camadas Domain/Data/Service/WebAPI do SmartDigitalPsico.
    /// </summary>
    public interface IMedicalSettingsRepository : SmartDigitalPsico.Core.SDK.Domain.Interfaces.Repository.IEntityBaseRepository<MedicalSettings>
    {
    }
}
