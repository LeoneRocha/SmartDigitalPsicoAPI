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
                .ThenInclude(e => e.Medical)
                .ThenInclude(e => e.User) 
                .Include(e => e.CreatedUser)
                .Where(x => x.Patient != null && x.Patient.Id == patientId).ToListAsync();

        }
         
        public async override Task<PatientHospitalizationInformation> FindByID(long id)
        {
            return await dataset 
                .Include(e => e.Patient)
                .ThenInclude(e => e.Medical)
                .ThenInclude(e => e.User)
                .Include(e => e.CreatedUser)
                .FirstAsync(p => p.Id.Equals(id));
        }
        public async override Task<List<PatientHospitalizationInformation>> FindAll()
        {
            return await dataset
                .AsNoTracking()
                .Include(e => e.Patient)
                .ThenInclude(e => e.Medical)
                .ThenInclude(e => e.User)
                .Include(e => e.CreatedUser)
                .ToListAsync();
        }

    }
}
