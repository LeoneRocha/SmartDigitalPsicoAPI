using EntityBase = SmartDigitalPsico.Core.SDK.Domain.Contracts.EntityBase;


namespace SmartDigitalPsico.Domain.ModelEntity
{
    /// <summary>
    /// Classe responsável por Specialty.
    /// Responsabilidade: entidade de domínio persistida via EF Core.
    /// Relação: mapeada no Data Context e usada pelos repositórios.
    /// </summary>
    public class Specialty : EntityBase, SmartDigitalPsico.Core.SDK.Domain.Interfaces.Repository.IEntityBaseDomains
    {
        /// <summary>
        /// Método Specialty: executa a operação Specialty.
        /// </summary>
        public Specialty()
        { 
            MedicalSpecialties = new List<MedicalSpecialty>();
        }
        public string Description { get; set; } = string.Empty;
        public string Language { get; set; } = string.Empty; 
        public ICollection<MedicalSpecialty> MedicalSpecialties { get; set; }
    }
}
