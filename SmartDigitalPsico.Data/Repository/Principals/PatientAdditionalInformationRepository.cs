using Microsoft.EntityFrameworkCore;
using SmartDigitalPsico.Data.Context;
using SmartDigitalPsico.Domain.Interfaces.Repository;
using SmartDigitalPsico.Domain.ModelEntity;
using SmartDigitalPsico.Data.Repository.Generic;

namespace SmartDigitalPsico.Data.Repository.Principals
{
    public class PatientAdditionalInformationRepository : GenericRepositoryEntityBase<PatientAdditionalInformation>, IPatientAdditionalInformationRepository
    {
        public PatientAdditionalInformationRepository(SmartDigitalPsicoDataContext context) : base(context) { }

        public async Task<List<PatientAdditionalInformation>> FindAllByPatient(long patientId)
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

        public async override Task<PatientAdditionalInformation> FindByID(long id)
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
        public async override Task<List<PatientAdditionalInformation>> FindAll()
        {
            return await _dataset
                .Include(e => e.Patient)
                .ToListAsync();
        }

    }
}
