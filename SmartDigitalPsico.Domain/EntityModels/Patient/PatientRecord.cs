using EntityBase = SmartDigitalPsico.Core.SDK.Domain.Contracts.EntityBase;

using SmartDigitalPsico.Domain.Interfaces.Common;
using SmartDigitalPsico.Domain.Interfaces.Patient;
namespace SmartDigitalPsico.Domain.EntityModels
{
    /// <summary>
    /// Classe responsável por PatientRecord.
    /// Responsabilidade: entidade de domínio persistida via EF Core.
    /// Relação: mapeada no Data Context e usada pelos repositórios.
    /// </summary>
    public class PatientRecord : EntityBase, IEntityBaseLogUser, IEntityPatientBase
    {
        #region Columns 
        public string Description { get; set; } = string.Empty;
        public string Annotation { get; set; } = string.Empty;
        public DateTime AnnotationDate { get; set; }
        #endregion Columns 

        #region Relationship   
        public Patient? Patient { get; set; }
        public long PatientId { get; set; }
        public User? CreatedUser { get; set; }
        public User? ModifyUser { get; set; }
        public long? CreatedUserId { get; set; }
        public long? ModifyUserId { get; set; }

        public string TableStorageRowKey { get; set; } = string.Empty;
        #endregion Relationship
    }
}
