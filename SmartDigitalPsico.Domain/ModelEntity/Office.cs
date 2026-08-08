using SmartDigitalPsico.Domain.Contracts;
using SmartDigitalPsicoAPI.Core.SDK.Domain.Contracts;
using EntityBase = SmartDigitalPsicoAPI.Core.SDK.Domain.Contracts.EntityBase;
using SmartDigitalPsico.Domain.Interfaces.Repository;
using SmartDigitalPsicoAPI.Core.SDK.Domain.Interfaces.Repository;


namespace SmartDigitalPsico.Domain.ModelEntity
{
    /// <summary>
    /// Classe responsável por Office.
    /// Responsabilidade: entidade de domínio persistida via EF Core.
    /// Relação: mapeada no Data Context e usada pelos repositórios.
    /// </summary>
    public class Office : EntityBase, SmartDigitalPsicoAPI.Core.SDK.Domain.Interfaces.Repository.IEntityBaseDomains
    {
        /// <summary>
        /// Método Office: executa a operação Office.
        /// </summary>
        public Office()
        {
            Medicals = new List<Medical>();
        }
        public string Description { get; set; } = string.Empty;                 
        public string Language { get; set; } = "en";
        public ICollection<Medical> Medicals { get; set; }
    }
}
