namespace SmartDigitalPsico.Domain.ModelEntity
{
    public class PatientInfoTag
    { 
        #region Relationship 
        public InfoTag? InfoTag { get; set; }
        public long InfoTagId { get; set; }
        public Patient? Patient { get; set; }
        public long PatientId { get; set; }
        #endregion Relationship 
    }
}