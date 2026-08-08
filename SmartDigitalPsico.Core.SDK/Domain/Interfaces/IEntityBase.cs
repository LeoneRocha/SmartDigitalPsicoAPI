namespace SmartDigitalPsico.Core.SDK.Domain.Interfaces
{ 
    /// <summary>
    /// Interface (contrato) responsável por IEntityBase.
    /// Responsabilidade: contrato de abstração do domínio.
    /// Relação: implementado nas camadas Data/Service.
    /// </summary>
    public interface IEntityBase 
    {
        long Id { get; set; }
        bool Enable { get; set; } 
    } 
}
