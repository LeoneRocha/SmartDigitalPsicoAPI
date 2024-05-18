using Microsoft.EntityFrameworkCore;
using SmartDigitalPsico.Data.Context;
using SmartDigitalPsico.Domain.Interfaces.Repository;
using SmartDigitalPsico.Domain.ModelEntity;
using SmartDigitalPsico.Data.Repository.Generic;

namespace SmartDigitalPsico.Data.Repository.Principals
{
    public class PatientRecordRepository : GenericRepositoryEntityBase<PatientRecord>, IPatientRecordRepository
    {
        public PatientRecordRepository(SmartDigitalPsicoDataContext context) : base(context) { }

        public async Task<List<PatientRecord>> FindAllByPatient(long patientId)
        {
#pragma warning disable CS8602
            return await dataset
                .AsNoTracking()
                .Include(e => e.Patient)
                .ThenInclude(e => e.Medical)
                .ThenInclude(e => e.User)
                .Include(e => e.CreatedUser)
                .Where(x => x.Patient != null && x.Patient.Id == patientId).ToListAsync(); 
#pragma warning restore CS8602
        }

        public async override Task<PatientRecord> FindByID(long id)
        {
            return await dataset 
                .Include(e => e.Patient)
                .FirstAsync(p => p.Id.Equals(id));
        }
        public async override Task<List<PatientRecord>> FindAll()
        {
            return await dataset 
                .Include(e => e.Patient)
                .ToListAsync();
        }
    }
}
