using SmartDigitalPsico.Domain.Hypermedia;
using SmartDigitalPsico.Core.SDK.Domain.Hypermedia;
using SmartDigitalPsico.Core.SDK.Domain.Hypermedia.Abstract;


namespace SmartDigitalPsico.Domain.DTO.Domains.GetDTOs
{
    /// <summary>
    /// Classe responsável por GetNotificationRecordsDto.
    /// Responsabilidade: DTO de transferência de dados entre camadas da API.
    /// Relação: usado por Controllers, Services e Validators.
    /// </summary>
    public class GetNotificationRecordsDto : NotificationRecordsBaseDto, ISupportsHyperMedia
    {
        public List<SmartDigitalPsico.Core.SDK.Domain.Hypermedia.HyperMediaLink> Links { get; set; } = new List<SmartDigitalPsico.Core.SDK.Domain.Hypermedia.HyperMediaLink>();
    }
}
