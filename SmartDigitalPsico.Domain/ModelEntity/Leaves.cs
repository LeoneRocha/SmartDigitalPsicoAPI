using SmartDigitalPsico.Domain.Contracts;
using SmartDigitalPsico.Domain.Interfaces.Repository;

namespace SmartDigitalPsico.Domain.ModelEntity
{
    public class Leaves : EntityBase, IEntityBaseDomains 
    {
        #region Relationship  
        public Medical? Medical { get; set; }
        public long? MedicalId { get; set; }
        #endregion Relationship  

        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string Description { get; set; } = string.Empty;
        public string Language { get; set; } = "en";
        public bool IsRecurring { get; set; }
    }
}
