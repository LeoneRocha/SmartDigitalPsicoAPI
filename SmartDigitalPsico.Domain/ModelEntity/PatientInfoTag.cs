namespace SmartDigitalPsico.Domain.ModelEntity
{
    public class PatientInfoTag
    {
        #region Relationship 
        public InfoTag InfoTag { get; set; } = new InfoTag();
        public long InfoTagId { get; set; }
        public Patient Patient { get; set; } = new Patient();
        public long PatientId { get; set; }
        #endregion Relationship 
    }
}