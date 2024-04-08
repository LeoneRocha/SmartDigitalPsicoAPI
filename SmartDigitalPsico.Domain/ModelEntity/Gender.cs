using SmartDigitalPsico.Domain.Contracts;
using SmartDigitalPsico.Domain.Interfaces.Repository;

namespace SmartDigitalPsico.Domain.ModelEntity
{
    public class Gender : EntityBase, IEntityBaseDomains
    {
        public Gender()
        {
            Patients = new List<Patient>();
        }
        public string Description { get; set; } = string.Empty;
        public string Language { get; set; } = string.Empty;
        public ICollection<Patient> Patients { get; set; } 
    }
}