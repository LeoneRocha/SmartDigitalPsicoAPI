using Microsoft.EntityFrameworkCore;
using SmartDigitalPsico.Data.Context;
using SmartDigitalPsico.Domain.Interfaces.Repository;
using SmartDigitalPsico.Domain.ModelEntity;
using SmartDigitalPsico.Data.Repository.Generic;

namespace SmartDigitalPsico.Data.Repository.Principals
{
    public class MedicalRepository : GenericRepositoryEntityBase<Medical>, IMedicalRepository
    {
        public MedicalRepository(SmartDigitalPsicoDataContext context) : base(context) { }

        public async Task<bool> Exists(string accreditation)
        {
            return await _dataset
                .AsNoTracking()
                .AnyAsync(x => x.Accreditation.ToLower().Equals(accreditation.ToLower()));
        }
        public async override Task<Medical> FindByID(long id)
        {
            return await _dataset 
                .Include(e => e.User)
                .Include(e => e.Office)
                .Include(e => e.MedicalSpecialties)
                .ThenInclude(ms => ms.Specialty)
                .Include(e => e.CreatedUser)
                .FirstAsync(p => p.Id.Equals(id));
        }
        public async override Task<List<Medical>> FindAll()
        {
            return await _dataset
                .AsNoTracking()
                .Include(e => e.User)
                .Include(e => e.Office)
                .Include(e => e.MedicalSpecialties)
                .ThenInclude(ms => ms.Specialty)
                .Include(e => e.CreatedUser)
                .ToListAsync();
        }

        public async Task<Medical?> FindByEmail(string email)
        {
            Medical? entityResult = await _dataset
                .AsNoTracking()
                .FirstOrDefaultAsync(p => p.Email.Equals(email, StringComparison.OrdinalIgnoreCase));

            return entityResult;
        } 
        public async Task<Medical?> FindByAccreditation(string accreditation)
        {
            Medical? entityResult = await _dataset
                .AsNoTracking()
                .Include(e => e.User)
                .Include(e => e.Office)
                .Include(e => e.MedicalSpecialties)
                .ThenInclude(ms => ms.Specialty)
                .Include(e => e.CreatedUser)
                .FirstOrDefaultAsync(p => p.Accreditation.Equals(accreditation, StringComparison.OrdinalIgnoreCase));

            return entityResult;
        }  
    }
}
