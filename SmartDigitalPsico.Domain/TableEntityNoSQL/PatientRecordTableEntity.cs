namespace SmartDigitalPsico.Domain.TableEntityNoSQL
{
    public class PatientRecordTableEntity : BaseEntityTable
    {
        public long PatientId { get; set; }
        public string Annotation { get; set; } = string.Empty;
    }
}
