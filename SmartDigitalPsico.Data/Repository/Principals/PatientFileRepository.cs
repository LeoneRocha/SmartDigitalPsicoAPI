using Microsoft.EntityFrameworkCore;
using SmartDigitalPsico.Data.Context;
using SmartDigitalPsico.Domain.Interfaces.Repository;
using SmartDigitalPsico.Domain.ModelEntity;
using SmartDigitalPsico.Data.Repository.Generic;
using SmartDigitalPsico.Domain.Interfaces;

namespace SmartDigitalPsico.Data.Repository.Principals
{
    public class PatientFileRepository : GenericRepositoryEntityBase<PatientFile>, IPatientFileRepository
    {
        public PatientFileRepository(SmartDigitalPsicoDataContext context,IPolicyConfig policyConfig) : base(context, policyConfig) { }

        public async override Task<PatientFile> FindByID(long id)
        {
#pragma warning disable CS8602
            return await _dataset 
                .Include(e => e.Patient)
                .ThenInclude(e => e.Medical)
                .ThenInclude(e => e.User)
                .Include(e => e.CreatedUser)
                .FirstAsync(p => p.Id.Equals(id));
#pragma warning restore CS8602
        }

        public async Task<List<PatientFile>> FindAllByPatient(long patientId)
        {
            return await _dataset
                .AsNoTracking()
                .Where(e => e.PatientId == patientId)
                .Include(e => e.CreatedUser)//validation required
                .Include(e => e.Patient)
                .ToListAsync();
        }
    }
} 