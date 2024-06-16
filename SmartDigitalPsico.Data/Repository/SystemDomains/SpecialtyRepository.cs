using Microsoft.EntityFrameworkCore;
using SmartDigitalPsico.Data.Context;
using SmartDigitalPsico.Domain.Interfaces.Repository;
using SmartDigitalPsico.Domain.ModelEntity;
using SmartDigitalPsico.Data.Repository.Generic;
using System.Data;
using SmartDigitalPsico.Domain.Interfaces;

namespace SmartDigitalPsico.Data.Repository.SystemDomains
{
    public class SpecialtyRepository : GenericRepositoryEntityBase<Specialty>, ISpecialtyRepository 
    {
        public SpecialtyRepository(SmartDigitalPsicoDataContext context) : base(context) { }
          
        public async Task<List<Specialty>> FindByIDs(List<long> idsSpecialties)
        {
            return await _dataset
                .AsNoTracking()
                .Where(p =>  idsSpecialties.Contains(p.Id)).ToListAsync();
        } 
    }
}
