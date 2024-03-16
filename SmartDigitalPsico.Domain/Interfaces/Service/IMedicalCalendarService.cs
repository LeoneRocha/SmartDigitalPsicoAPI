using SmartDigitalPsico.Domain.ModelEntity;
using SmartDigitalPsico.Domain.VO.Medical.MedicalCalendar;

namespace SmartDigitalPsico.Domain.Interfaces.Service
{
    public interface IMedicalCalendarService : IEntityBaseSimpleService<MedicalCalendar, AddMedicalCalendarVO, UpdateMedicalCalendarVO, GetMedicalCalendarVO>
    { 
    }
}