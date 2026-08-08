namespace SmartDigitalPsicoAPI.Core.SDK.Domain.Interfaces
{
    /// <summary>
    /// Interface (contrato) responsável por IEntityBaseLog.
    /// Responsabilidade: contrato de abstração do domínio.
    /// Relação: implementado nas camadas Data/Service.
    /// </summary>
    public interface IEntityBaseLog
    {

        DateTime CreatedDate { get; set; }

        DateTime ModifyDate { get; set; }

        DateTime LastAccessDate { get; set; }

    }
}
