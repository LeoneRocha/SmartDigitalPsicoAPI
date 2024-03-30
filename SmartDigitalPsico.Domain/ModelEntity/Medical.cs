using SmartDigitalPsico.Domain.Contracts;
using SmartDigitalPsico.Domain.Enuns;
using SmartDigitalPsico.Domain.Interfaces;

namespace SmartDigitalPsico.Domain.ModelEntity
{
    public class Medical : EntityBaseWithNameEmail, IEntityBaseLogUser
    {
        #region Columns

        public string Accreditation { get; set; } = string.Empty;
        public ETypeAccreditation TypeAccreditation { get; set; }
        public string SecurityKey { get; set; } = string.Empty;

        #endregion Columns 

        #region Relationship 
        public long OfficeId { get; set; }
        public Office Office { get; set; } = new Office();
        public User? User { get; set; }
        public long? UserId { get; set; }
        public User? CreatedUser { get; set; }
        public long? CreatedUserId { get; set; }
        public User? ModifyUser { get; set; }
        public long? ModifyUserId { get; set; }
        public ICollection<Specialty> Specialties { get; set; }

        public List<Patient> Patienties { get; set; }
        #endregion Relationship
    }
}