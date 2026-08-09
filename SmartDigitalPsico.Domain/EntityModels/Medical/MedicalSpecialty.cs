namespace SmartDigitalPsico.Domain.EntityModels
{
    /// <summary>
    /// Classe responsável por MedicalSpecialty.
    /// Responsabilidade: entidade de domínio persistida via EF Core.
    /// Relação: mapeada no Data Context e usada pelos repositórios.
    /// </summary>
    public class MedicalSpecialty
    {
        public Medical? Medical { get; set; }
        public long MedicalId { get; set; }

        public Specialty? Specialty { get; set; }
        public long SpecialtyId { get; set; }
    }
}
