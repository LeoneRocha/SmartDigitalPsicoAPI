using SmartDigitalPsico.Core.SDK.Domain.Hypermedia.Abstract;

using SmartDigitalPsico.Domain.DTO.Notification.Common;
namespace SmartDigitalPsico.Domain.DTO.Notification.GET
{
    /// <summary>
    /// Classe responsável por GetNotificationTemplateDto.
    /// Responsabilidade: DTO de transferência de dados entre camadas da API.
    /// Relação: usado por Controllers, Services e Validators.
    /// </summary>
    public class GetNotificationTemplateDto : NotificationTemplateBaseDto, ISupportsHyperMedia
    {
        public List<SmartDigitalPsico.Core.SDK.Domain.Hypermedia.HyperMediaLink> Links { get; set; } = new List<SmartDigitalPsico.Core.SDK.Domain.Hypermedia.HyperMediaLink>();
    }
}
