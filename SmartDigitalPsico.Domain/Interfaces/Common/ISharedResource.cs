namespace SmartDigitalPsico.Domain.Interfaces.Common
{
    /// <summary>
    /// Interface (contrato) responsável por ISharedResource.
    /// Responsabilidade: contrato de abstração do domínio.
    /// Relação: implementado nas camadas Data/Service.
    /// </summary>
    public interface ISharedResource
    {
        public string Name { get; set; }
    }
}
