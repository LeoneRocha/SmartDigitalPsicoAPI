using SmartDigitalPsico.Core.SDK.Domain.Interfaces;

namespace SmartDigitalPsico.Core.SDK.Domain.DTO.Contracts
{
    /// <summary>
    /// Classe responsável por EntityDtoBaseAdd.
    /// Responsabilidade: contrato compartilhado entre camadas.
    /// Relação: integra as camadas Domain/Data/Service/WebAPI do SmartDigitalPsico.
    /// </summary>
    public abstract class EntityDtoBaseAdd : IEntityDtoAdd
    {
        public bool Enable { get; set; }
    }
}
