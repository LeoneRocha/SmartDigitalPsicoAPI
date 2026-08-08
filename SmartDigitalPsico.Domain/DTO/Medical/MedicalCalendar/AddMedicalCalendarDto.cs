using SmartDigitalPsico.Domain.Interfaces;

namespace SmartDigitalPsico.Domain.DTO.Medical.MedicalCalendar
{
    /// <summary>
    /// Classe responsável por AddMedicalCalendarDto.
    /// Responsabilidade: DTO de transferência de dados entre camadas da API.
    /// Relação: usado por Controllers, Services e Validators.
    /// </summary>
    public class AddMedicalCalendarDto : ActionMedicalCalendarDtoBase, SmartDigitalPsicoAPI.Core.SDK.Domain.Interfaces.IEntityDtoAdd
    {
       
    }
}
