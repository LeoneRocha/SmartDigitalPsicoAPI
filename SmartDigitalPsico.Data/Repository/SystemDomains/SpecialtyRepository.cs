using Microsoft.EntityFrameworkCore;
using SmartDigitalPsico.Data.Context.Interface;
using SmartDigitalPsico.Data.Repository.Generic;
using SmartDigitalPsico.Domain.Interfaces.Repository;
using SmartDigitalPsico.Domain.ModelEntity;
using System.Data;

namespace SmartDigitalPsico.Data.Repository.SystemDomains
{
    public class SpecialtyRepository : GenericRepositoryEntityBase<Specialty>, ISpecialtyRepository 
    {
        public SpecialtyRepository(IEntityDataContext context) : base(context) { }
          
        public async Task<List<Specialty>> FindByIDs(List<long> idsSpecialties)
        {
            return await _dataset
                .AsNoTracking()
                .Where(p =>  idsSpecialties.Contains(p.Id)).ToListAsync();
        } 
    }
}
