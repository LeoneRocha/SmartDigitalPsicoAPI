using SmartDigitalPsico.Domain.ModelEntity;
using SmartDigitalPsico.Domain.DTO.Medical.MedicalCalendar;

namespace SmartDigitalPsico.Domain.Interfaces.Service
{
    public interface IMedicalCalendarService : IEntityBaseService<MedicalCalendar, AddMedicalCalendarDto, UpdateMedicalCalendarDto, GetMedicalCalendarDto>
    {    
    }
}