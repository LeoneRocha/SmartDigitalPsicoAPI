using SmartDigitalPsico.Domain.DTO.Medical.MedicalCalendar.Common;
namespace SmartDigitalPsico.Domain.DTO.Medical.MedicalCalendar.UPDATE
{
    /// <summary>
    /// Classe responsável por UpdateMedicalCalendarDto.
    /// Responsabilidade: DTO de transferência de dados entre camadas da API.
    /// Relação: usado por Controllers, Services e Validators.
    /// </summary>
    public class UpdateMedicalCalendarDto : ActionMedicalCalendarDtoBase
    {
        public bool IsUpdate { get; set; }        
    } 
}
