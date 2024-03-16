using SmartDigitalPsico.Data.Context;
using SmartDigitalPsico.Domain.Interfaces.Repository;
using SmartDigitalPsico.Domain.ModelEntity;
using SmartDigitalPsico.Data.Repository.Generic;

namespace SmartDigitalPsico.Data.Repository.SystemDomains
{
    public class GenderRepository : GenericRepositoryEntityBaseSimple<Gender>, IGenderRepository
    {
        public GenderRepository(SmartDigitalPsicoDataContext context) : base(context) { }
    }
}
