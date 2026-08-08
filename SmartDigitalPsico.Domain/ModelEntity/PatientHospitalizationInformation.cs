using SmartDigitalPsico.Domain.Contracts;
using SmartDigitalPsicoAPI.Core.SDK.Domain.Contracts;
using EntityBase = SmartDigitalPsicoAPI.Core.SDK.Domain.Contracts.EntityBase;
using SmartDigitalPsico.Domain.Interfaces;

namespace SmartDigitalPsico.Domain.ModelEntity
{
    /// <summary>
    /// Classe responsável por PatientHospitalizationInformation.
    /// Responsabilidade: entidade de domínio persistida via EF Core.
    /// Relação: mapeada no Data Context e usada pelos repositórios.
    /// </summary>
    public class PatientHospitalizationInformation : EntityBase, IEntityBaseLogUser, IEntityPatientBase
    { 
        #region Columns  
        public string Description { get; set; } = string.Empty;
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; } 
        public string CID { get; set; } = string.Empty; 
        public string Observation { get; set; } = string.Empty;         
        #endregion Columns 

        #region Relationship 
        public Patient? Patient { get; set; } 
        public long PatientId { get; set; }
        public User? CreatedUser { get; set; }
        public User? ModifyUser { get; set; }
        public long? CreatedUserId { get; set; }
        public long? ModifyUserId { get; set; }
        #endregion Relationship
    }
}
