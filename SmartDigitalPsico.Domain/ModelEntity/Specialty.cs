using SmartDigitalPsico.Domain.Contracts;
using SmartDigitalPsicoAPI.Core.SDK.Domain.Contracts;
using EntityBase = SmartDigitalPsicoAPI.Core.SDK.Domain.Contracts.EntityBase;
using SmartDigitalPsico.Domain.Interfaces.Repository;
using SmartDigitalPsicoAPI.Core.SDK.Domain.Interfaces.Repository;


namespace SmartDigitalPsico.Domain.ModelEntity
{
    /// <summary>
    /// Classe responsável por Specialty.
    /// Responsabilidade: entidade de domínio persistida via EF Core.
    /// Relação: mapeada no Data Context e usada pelos repositórios.
    /// </summary>
    public class Specialty : EntityBase, SmartDigitalPsicoAPI.Core.SDK.Domain.Interfaces.Repository.IEntityBaseDomains
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
