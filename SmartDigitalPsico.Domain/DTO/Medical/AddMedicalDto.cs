using SmartDigitalPsico.Domain.Interfaces;

namespace SmartDigitalPsico.Domain.DTO.Medical
{
    public class AddMedicalDto : ActionMedicalDtoBase, IEntityDtoAdd
    {
        #region Relationship   
        public long OfficeId { get; set; }
        public List<long> SpecialtiesIds { get; set; } = new List<long>(); 
        #endregion Relationship 
    }
}