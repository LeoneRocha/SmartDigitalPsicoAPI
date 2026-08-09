using SmartDigitalPsico.Core.SDK.Domain.EntityModels.Contracts;
using SmartDigitalPsico.Domain.Interfaces.Common;
using SmartDigitalPsico.Domain.Interfaces.Patient;
namespace SmartDigitalPsico.Domain.EntityModels
{
    /// <summary>
    /// Classe responsável por PatientFile.
    /// Responsabilidade: entidade de domínio persistida via EF Core.
    /// Relação: mapeada no Data Context e usada pelos repositórios.
    /// </summary>
    public class PatientFile : FileBase, IEntityBaseLogUser, IEntityPatientBase
    {
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
