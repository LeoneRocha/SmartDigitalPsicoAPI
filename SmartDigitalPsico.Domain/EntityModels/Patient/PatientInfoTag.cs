using SmartDigitalPsico.Domain.Interfaces.Patient;

namespace SmartDigitalPsico.Domain.EntityModels
{
    /// <summary>
    /// Classe responsável por PatientInfoTag.
    /// Responsabilidade: entidade de domínio persistida via EF Core.
    /// Relação: mapeada no Data Context e usada pelos repositórios.
    /// </summary>
    public class PatientInfoTag : IEntityPatientBase
    {
        #region Relationship 
        public InfoTag? InfoTag { get; set; }
        public long InfoTagId { get; set; }
        public Patient? Patient { get; set; }
        public long PatientId { get; set; }
        #endregion Relationship 
    }
}
