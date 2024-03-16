using SmartDigitalPsico.Data.Context;
using SmartDigitalPsico.Domain.Interfaces.Repository;
using SmartDigitalPsico.Domain.ModelEntity;
using SmartDigitalPsico.Repository.Generic;

namespace SmartDigitalPsico.Repository.SystemDomains
{
    public class GenderRepository : GenericRepositoryEntityBaseSimple<Gender>, IGenderRepository
    {
        public GenderRepository(SmartDigitalPsicoDataContext context) : base(context) { }
    }
}
