using SmartDigitalPsico.Domain.Contracts;
using SmartDigitalPsico.Domain.Enuns;
using SmartDigitalPsico.Domain.Interfaces;

namespace SmartDigitalPsico.Domain.ModelEntity
{
    public class Medical : EntityBaseWithNameEmail, IEntityBaseLogUser
    {
        public Medical()
        {  
            Patienties = new List<Patient>();
            MedicalSpecialties = new List<MedicalSpecialty>();
        }
        #region Columns
        public string Accreditation { get; set; } = string.Empty;
        public ETypeAccreditation TypeAccreditation { get; set; }
        public string SecurityKey { get; set; } = string.Empty;
        #endregion Columns 

        #region Relationship 
        public long OfficeId { get; set; }
        public Office? Office { get; set; }
        public User? User { get; set; }
        public long? UserId { get; set; }
        public User? CreatedUser { get; set; }
        public long? CreatedUserId { get; set; }
        public User? ModifyUser { get; set; }
        public long? ModifyUserId { get; set; } 
        public ICollection<Patient> Patienties { get; set; }
        
        public ICollection<MedicalSpecialty> MedicalSpecialties { get; set; }
        public TimeSpan StartWorkingTime { get; set; }
        public TimeSpan EndWorkingTime { get; set; } 
        public DayOfWeek[] WorkingDays { get; set; } = []; // 0 = Sunday  1 = Monday  6 = Saturday

        #endregion Relationship
    }
}