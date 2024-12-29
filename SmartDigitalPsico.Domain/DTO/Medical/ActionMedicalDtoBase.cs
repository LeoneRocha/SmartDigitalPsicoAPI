using SmartDigitalPsico.Domain.DTO.Contracts;
using SmartDigitalPsico.Domain.Enuns;

namespace SmartDigitalPsico.Domain.DTO.Medical
{
    public abstract class ActionMedicalDtoBase  
    {
        public long Id { get; set; }
        public bool Enable { get; set; }
        #region Columns 
        public string Name { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Accreditation { get; set; } = string.Empty;
        public ETypeAccreditation TypeAccreditation { get; set; }
        public TimeSpan StartWorkingTime { get; set; }
        public TimeSpan EndWorkingTime { get; set; }
        public DayOfWeek[] WorkingDays { get; set; } = [];
        public byte PatientIntervalTimeMinutes { get; set; }
        #endregion Columns  
    }
}
