namespace SmartDigitalPsico.Domain.DTO.Contracts
{
    public abstract class EntityDtoBaseDomain : EntityDtoBase
    {
        public string Description { get; set; } = string.Empty;     
        public string Language { get; set; } = "en";
    }
}