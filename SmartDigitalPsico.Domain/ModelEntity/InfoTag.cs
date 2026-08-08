using EntityBase = SmartDigitalPsico.Core.SDK.Domain.Contracts.EntityBase;

using SmartDigitalPsico.Domain.Interfaces.Common;
namespace SmartDigitalPsico.Domain.ModelEntity
{
    /// <summary>
    /// Classe responsável por InfoTag.
    /// Responsabilidade: entidade de domínio persistida via EF Core.
    /// Relação: mapeada no Data Context e usada pelos repositórios.
    /// </summary>
    public class InfoTag : EntityBase, IEntityBaseLogUser
    {
        /// <summary>
        /// Método InfoTag: executa a operação InfoTag.
        /// </summary>
        public InfoTag()
        { 
            PatientInfoTags = new List<PatientInfoTag>();
        }
        public string Tag { get; set; } = string.Empty;
        public Medical? Medical { get; set; }        
        public long MedicalId { get; set; }
        public User? CreatedUser { get; set; }
        public User? ModifyUser { get; set; }         
        public long? CreatedUserId { get; set; }                
        public long? ModifyUserId { get; set; }                 
        public ICollection<PatientInfoTag> PatientInfoTags { get; set; }          
    }
}
