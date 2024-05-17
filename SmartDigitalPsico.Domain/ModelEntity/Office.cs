using SmartDigitalPsico.Domain.Contracts;
using SmartDigitalPsico.Domain.Interfaces.Repository;

namespace SmartDigitalPsico.Domain.ModelEntity
{
    public class Office : EntityBase, IEntityBaseDomains
    {
        public Office()
        {
            Medicals = new List<Medical>();
        }
        public string Description { get; set; } = string.Empty;                 
        public string Language { get; set; } = "en";
        public ICollection<Medical> Medicals { get; set; }
    }
}