using SmartDigitalPsico.Domain.DTO.Notification.Common;
namespace SmartDigitalPsico.Domain.DTO.Notification.ADD
{
    /// <summary>
    /// Classe responsável por AddNotificationRecordsDto.
    /// Responsabilidade: DTO de transferência de dados entre camadas da API.
    /// Relação: usado por Controllers, Services e Validators.
    /// </summary>
    public class AddNotificationRecordsDto : NotificationRecordsBaseDto, SmartDigitalPsico.Core.SDK.Domain.Interfaces.IEntityDtoAdd
    {
    }
}
