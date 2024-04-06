using SmartDigitalPsico.Domain.ModelEntity;
using SmartDigitalPsico.Domain.VO.Medical.MedicalCalendar;

namespace SmartDigitalPsico.Domain.Interfaces.Service
{
    public interface IMedicalCalendarService : IEntityBaseService<MedicalCalendar, AddMedicalCalendarVO, UpdateMedicalCalendarVO, GetMedicalCalendarVO>
    { 
    }
}