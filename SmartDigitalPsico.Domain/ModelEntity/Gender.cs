using SmartDigitalPsico.Domain.Contracts;
using SmartDigitalPsico.Domain.Interfaces.Repository;

namespace SmartDigitalPsico.Domain.ModelEntity
{
    /// <summary>
    /// Classe responsável por Gender.
    /// Responsabilidade: entidade de domínio persistida via EF Core.
    /// Relação: mapeada no Data Context e usada pelos repositórios.
    /// </summary>
    public class Gender : EntityBase, IEntityBaseDomains
    {
        /// <summary>
        /// Método Gender: executa a operação Gender.
        /// </summary>
        public Gender()
        {
            Patients = new List<Patient>();
        }
        public string Description { get; set; } = string.Empty;
        public string Language { get; set; } = string.Empty;
        public ICollection<Patient> Patients { get; set; } 
    }
}
