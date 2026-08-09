using SmartDigitalPsico.Domain.Interfaces.Common;
using SmartDigitalPsico.Domain.Interfaces.Patient;
using EntityBase = SmartDigitalPsico.Core.SDK.Domain.Contracts.EntityBase;
namespace SmartDigitalPsico.Domain.EntityModels
{
    /// <summary>
    /// Classe responsável por PatientAdditionalInformation.
    /// Responsabilidade: entidade de domínio persistida via EF Core.
    /// Relação: mapeada no Data Context e usada pelos repositórios.
    /// </summary>
    public class PatientAdditionalInformation : EntityBase, IEntityBaseLogUser, IEntityPatientBase
    {
        #region Columns         
        public string FollowUp_Psychiatric { get; set; } = string.Empty;
        public string FollowUp_Neurological { get; set; } = string.Empty;
        #endregion Columns 

        #region Relationship
        public Patient? Patient { get; set; }
        public long PatientId { get; set; }
        public User? CreatedUser { get; set; }
        public long? CreatedUserId { get; set; }
        public User? ModifyUser { get; set; }
        public long? ModifyUserId { get; set; }
        #endregion Relationship
    }
}
