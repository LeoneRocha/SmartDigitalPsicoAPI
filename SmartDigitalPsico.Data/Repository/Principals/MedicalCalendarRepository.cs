using SmartDigitalPsico.Data.Context.Interface;
using SmartDigitalPsico.Data.Repository.Generic;
using SmartDigitalPsico.Domain.Interfaces.Repository;
using SmartDigitalPsico.Domain.ModelEntity;

namespace SmartDigitalPsico.Data.Repository.Principals
{
    public class MedicalCalendarRepository : GenericRepositoryEntityBase<MedicalCalendar>, IMedicalCalendarRepository
    {
        public MedicalCalendarRepository(IEntityDataContext context) : base(context) { }
         
    }
}
