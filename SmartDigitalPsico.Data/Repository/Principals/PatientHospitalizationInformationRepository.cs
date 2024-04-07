using Microsoft.EntityFrameworkCore;
using SmartDigitalPsico.Data.Context;
using SmartDigitalPsico.Domain.Interfaces.Repository;
using SmartDigitalPsico.Domain.ModelEntity;
using SmartDigitalPsico.Data.Repository.Generic;

namespace SmartDigitalPsico.Data.Repository.Principals
{
    public class PatientHospitalizationInformationRepository : GenericRepositoryEntityBase<PatientHospitalizationInformation>, IPatientHospitalizationInformationRepository
    {
        public PatientHospitalizationInformationRepository(SmartDigitalPsicoDataContext context) : base(context) { }

        public async Task<List<PatientHospitalizationInformation>> FindAllByPatient(long patientId)
        {
            return await dataset
                .AsNoTracking()
                .Include(e => e.Patient)
                .Include(e => e.Patient.Medical)
                .Include(e => e.Patient.Medical.User)
                .Include(e => e.CreatedUser)
                .Where(x => x.Patient.Id == patientId).ToListAsync();
        }
         
        public async override Task<PatientHospitalizationInformation?> FindByID(long id)
        {
            return await dataset
                .AsNoTracking()
                .Include(e => e.Patient)
                .Include(e => e.Patient.Medical)
                .Include(e => e.Patient.Medical.User)
                .Include(e => e.CreatedUser)
                .FirstOrDefaultAsync(p => p.Id.Equals(id));
        }
        public async override Task<List<PatientHospitalizationInformation>> FindAll()
        {
            return await dataset
                .AsNoTracking()
                .Include(e => e.Patient)
                .Include(e => e.Patient.Medical)
                .Include(e => e.Patient.Medical.User)
                .Include(e => e.CreatedUser)
                .ToListAsync();
        }

    }
}
