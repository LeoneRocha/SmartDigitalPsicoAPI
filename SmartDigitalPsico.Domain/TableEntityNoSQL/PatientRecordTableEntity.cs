namespace SmartDigitalPsico.Domain.TableEntityNoSQL
{
    /// <summary>
    /// Classe responsável por PatientRecordTableEntity.
    /// Responsabilidade: componente do backend SmartDigitalPsico.
    /// Relação: integra as camadas Domain/Data/Service/WebAPI do SmartDigitalPsico.
    /// </summary>
    public class PatientRecordTableEntity : SmartDigitalPsico.Core.SDK.Domain.TableEntityNoSQL.BaseEntityTable
    {
        public long PatientId { get; set; }
        public string Annotation { get; set; } = string.Empty;
        public long PatientRecordId { get; set; }
    }
}
