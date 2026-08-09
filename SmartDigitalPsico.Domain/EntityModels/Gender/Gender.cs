using EntityBase = SmartDigitalPsico.Core.SDK.Domain.Contracts.EntityBase;

namespace SmartDigitalPsico.Domain.EntityModels
{
    /// <summary>
    /// Classe responsável por Gender.
    /// Responsabilidade: entidade de domínio persistida via EF Core.
    /// Relação: mapeada no Data Context e usada pelos repositórios.
    /// </summary>
    public class Gender : EntityBase, SmartDigitalPsico.Core.SDK.Domain.Interfaces.Repository.IEntityBaseDomains
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
