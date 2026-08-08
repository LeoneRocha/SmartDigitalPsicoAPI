using System.ComponentModel.DataAnnotations;

namespace SmartDigitalPsico.Core.SDK.Domain.DTO.Contracts
{
    /// <summary>
    /// Classe responsável por EntityDtoBaseName.
    /// Responsabilidade: contrato compartilhado entre camadas.
    /// Relação: integra as camadas Domain/Data/Service/WebAPI do SmartDigitalPsico.
    /// </summary>
    public abstract class EntityDtoBaseName : EntityDtoBase
    { 
        public string Name { get; set; } = string.Empty;         
        public string Email { get; set; } = string.Empty; 
    }
}
