using System.ComponentModel.DataAnnotations;

namespace SmartDigitalPsico.Domain.DTO.Contracts
{
    public abstract class EntityDtoBaseName : EntityDtoBase
    { 
        public string Name { get; set; } = string.Empty;         
        public string Email { get; set; } = string.Empty; 
    }
}