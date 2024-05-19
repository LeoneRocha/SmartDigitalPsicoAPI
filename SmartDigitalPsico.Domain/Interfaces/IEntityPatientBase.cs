using SmartDigitalPsico.Domain.ModelEntity;

namespace SmartDigitalPsico.Domain.Interfaces
{
    public interface IEntityPatientBase  
    {
        Patient? Patient { get; set; }
        long PatientId { get; set; }
    }
}