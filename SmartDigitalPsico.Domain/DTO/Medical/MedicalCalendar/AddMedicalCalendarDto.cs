using SmartDigitalPsico.Domain.Interfaces;

namespace SmartDigitalPsico.Domain.DTO.Medical.MedicalCalendar
{
    public class AddMedicalCalendarDto : UpdateMedicalCalendarDtoBase, IEntityDtoAdd
    {
        #region Relationship 
        public long MedicalId { get; set; }
        public long? PatientId { get; set; }
        #endregion Relationship


    }
}