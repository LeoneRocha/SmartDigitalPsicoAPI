using SmartDigitalPsico.Domain.DTO.Medical.MedicalCalendar.Common;
namespace SmartDigitalPsico.Domain.DTO.Medical.MedicalCalendar.ADD
{
    /// <summary>
    /// Classe responsável por AddMedicalCalendarDto.
    /// Responsabilidade: DTO de transferência de dados entre camadas da API.
    /// Relação: usado por Controllers, Services e Validators.
    /// </summary>
    public class AddMedicalCalendarDto : ActionMedicalCalendarDtoBase, SmartDigitalPsico.Core.SDK.Domain.Interfaces.IEntityDtoAdd
    {

    }
}
