using SmartDigitalPsico.Data.Context;
using SmartDigitalPsico.Domain.Interfaces.Repository;
using SmartDigitalPsico.Domain.ModelEntity;
using SmartDigitalPsico.Data.Repository.Generic;
using SmartDigitalPsico.Domain.Interfaces;

namespace SmartDigitalPsico.Data.Repository.Principals
{
    public class MedicalCalendarRepository : GenericRepositoryEntityBase<MedicalCalendar>, IMedicalCalendarRepository
    {
        public MedicalCalendarRepository(SmartDigitalPsicoDataContext context) : base(context) { }
         
    }
}
