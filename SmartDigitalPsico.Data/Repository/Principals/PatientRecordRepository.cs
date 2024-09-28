using Microsoft.EntityFrameworkCore;
using SmartDigitalPsico.Data.Context.Interface;
using SmartDigitalPsico.Data.Repository.Generic;
using SmartDigitalPsico.Domain.Interfaces.Repository;
using SmartDigitalPsico.Domain.ModelEntity;

namespace SmartDigitalPsico.Data.Repository.Principals
{
    public class PatientRecordRepository : GenericRepositoryEntityBase<PatientRecord>, IPatientRecordRepository
    {
        public PatientRecordRepository(IEntityDataContext context) : base(context) { }

        public async Task<List<PatientRecord>> FindAllByPatient(long patientId)
        {
#pragma warning disable CS8602
            return await _dataset
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
            return await _dataset 
                .Include(e => e.Patient)
                .Include(e => e.CreatedUser)
                .FirstAsync(p => p.Id.Equals(id));
        } 
    }
} 