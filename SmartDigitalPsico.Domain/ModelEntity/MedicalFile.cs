using SmartDigitalPsico.Domain.Interfaces;
using SmartDigitalPsico.Core.SDK.Domain.ModelEntity.Contracts;

namespace SmartDigitalPsico.Domain.ModelEntity
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
