using Microsoft.EntityFrameworkCore;
using SmartDigitalPsico.Data.Context;
using SmartDigitalPsico.Domain.Interfaces.Repository;
using SmartDigitalPsico.Domain.ModelEntity;
using SmartDigitalPsico.Repository.Generic;

namespace SmartDigitalPsico.Repository.Principals
{
    public class PatientMedicationInformationRepository : GenericRepositoryEntityBaseSimple<PatientMedicationInformation>, IPatientMedicationInformationRepository
    {
        public PatientMedicationInformationRepository(SmartDigitalPsicoDataContext context) : base(context) { }

        public async Task<List<PatientMedicationInformation>> FindAllByPatient(long patientId)
        {
            return await dataset
                .Include(e => e.Patient)
                .Include(e => e.Patient.Medical)
                .Include(e => e.Patient.Medical.User)
                .Include(e => e.CreatedUser)
                .Where(x => x.Patient.Id == patientId).ToListAsync();
        }

        public async override Task<PatientMedicationInformation> FindByID(long id)
        {
            return await dataset
                .Include(e => e.Patient)
                .Include(e => e.Patient.Medical)
                .Include(e => e.Patient.Medical.User)
                .Include(e => e.CreatedUser)
                .FirstAsync(p => p.Id.Equals(id));
        }
        public async override Task<List<PatientMedicationInformation>> FindAll()
        {
            return await dataset
                .Include(e => e.Patient)
                .Include(e => e.Patient.Medical)
                .Include(e => e.Patient.Medical.User)
                .Include(e => e.CreatedUser)
                .ToListAsync();
        }

    }
}
