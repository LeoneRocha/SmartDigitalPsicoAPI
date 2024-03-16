using Microsoft.EntityFrameworkCore;
using SmartDigitalPsico.Data.Context;
using SmartDigitalPsico.Domain.Interfaces.Repository;
using SmartDigitalPsico.Domain.ModelEntity;
using SmartDigitalPsico.Repository.Generic;
using System.Data;

namespace SmartDigitalPsico.Repository.SystemDomains
{
    public class SpecialtyRepository : GenericRepositoryEntityBaseSimple<Specialty>, ISpecialtyRepository 
    {
        public SpecialtyRepository(SmartDigitalPsicoDataContext context) : base(context) { }
          
        public async Task<List<Specialty>> FindByIDs(List<long> idsSpecialties)
        {
            return await dataset.Where(p =>  idsSpecialties.Contains(p.Id)).ToListAsync();
        } 
    }
}
