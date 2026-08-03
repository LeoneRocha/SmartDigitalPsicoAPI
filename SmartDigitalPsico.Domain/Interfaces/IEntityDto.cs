namespace SmartDigitalPsico.Domain.Interfaces
{
    /// <summary>
    /// Interface (contrato) responsável por IEntityDto.
    /// Responsabilidade: contrato de abstração do domínio.
    /// Relação: implementado nas camadas Data/Service.
    /// </summary>
    public interface IEntityDto
    {
        public long Id { get; set; }
    }
}
