using SmartDigitalPsico.Core.SDK.Domain.EntityModels.Contracts;
using SmartDigitalPsico.Domain.Interfaces.Common;
using SmartDigitalPsico.Domain.Interfaces.Medical;
namespace SmartDigitalPsico.Domain.EntityModels
{
    /// <summary>
    /// Classe responsável por MedicalFile.
    /// Responsabilidade: entidade de domínio persistida via EF Core.
    /// Relação: mapeada no Data Context e usada pelos repositórios.
    /// </summary>
    public class MedicalFile : FileBase, IEntityBaseLogUser, IEntityMedicalBase
    {
        #region Relationship         
        public Medical? Medical { get; set; }
        public long MedicalId { get; set; }
        public User? CreatedUser { get; set; }
        public User? ModifyUser { get; set; }
        public long? CreatedUserId { get; set; }
        public long? ModifyUserId { get; set; }
        #endregion Relationship
    }
}
