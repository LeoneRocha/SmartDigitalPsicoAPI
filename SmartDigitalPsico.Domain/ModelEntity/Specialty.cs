using SmartDigitalPsico.Domain.Contracts;
using SmartDigitalPsico.Domain.Interfaces.Repository;

namespace SmartDigitalPsico.Domain.ModelEntity
{
    public class Specialty : EntityBase, IEntityBaseDomains
    {
        public Specialty()
        {
            Medicals = new List<Medical>();
            //MedicalSpecialties = new List<MedicalSpecialty>();
        }
        public string Description { get; set; } = string.Empty;
        public string Language { get; set; } = string.Empty;
        public ICollection<Medical> Medicals { get; set; }
        //public ICollection<MedicalSpecialty> MedicalSpecialties { get; set; }
    }
}