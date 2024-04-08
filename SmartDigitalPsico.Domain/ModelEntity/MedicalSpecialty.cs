namespace SmartDigitalPsico.Domain.ModelEntity
{
    public class MedicalSpecialty 
    {    
        public Medical Medical { get; set; }         
        public long MedicalId { get; set; }

        public Specialty Specialty { get; set; }
        public long SpecialtyId { get; set; } 
    }
}