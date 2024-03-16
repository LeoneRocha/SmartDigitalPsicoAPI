using SmartDigitalPsico.Data.Context;
using SmartDigitalPsico.Domain.Interfaces.Repository;
using SmartDigitalPsico.Domain.ModelEntity;
using SmartDigitalPsico.Repository.Generic;

namespace SmartDigitalPsico.Repository.Principals
{
    public class MedicalCalendarRepository : GenericRepositoryEntityBaseSimple<MedicalCalendar>, IMedicalCalendarRepository
    {
        public MedicalCalendarRepository(SmartDigitalPsicoDataContext context) : base(context) { }
         
    }
}
