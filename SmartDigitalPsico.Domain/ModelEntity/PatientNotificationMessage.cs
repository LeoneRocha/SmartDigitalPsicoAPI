using SmartDigitalPsico.Domain.Contracts;
using SmartDigitalPsico.Core.SDK.Domain.Contracts;
using EntityBase = SmartDigitalPsico.Core.SDK.Domain.Contracts.EntityBase;
using SmartDigitalPsico.Domain.Interfaces;

namespace SmartDigitalPsico.Domain.ModelEntity
{
    /// <summary>
    /// Classe responsável por PatientNotificationMessage.
    /// Responsabilidade: entidade de domínio persistida via EF Core.
    /// Relação: mapeada no Data Context e usada pelos repositórios.
    /// </summary>
    public class PatientNotificationMessage : EntityBase, IEntityBaseLogUser, IEntityPatientBase
    { 
        #region Columns  
        public string MessagePatient { get; set; } = string.Empty;         
        public bool IsReaded { get; set; } 
        public DateTime? ReadingDate { get; set; } 
        public bool Notified { get; set; } 
        public DateTime? NotifiedDate { get; set; }
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
