using SmartDigitalPsico.Domain.Interfaces;

namespace SmartDigitalPsico.Domain.DTO.Contracts
{
    /// <summary>
    /// Classe responsável por EntityDtoBase.
    /// Responsabilidade: contrato compartilhado entre camadas.
    /// Relação: integra as camadas Domain/Data/Service/WebAPI do SmartDigitalPsico.
    /// </summary>
    public abstract class EntityDtoBase : IEntityDto
    {
        public long Id { get; set; }
        public bool Enable { get; set; }
    }
}
