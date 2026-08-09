using Microsoft.EntityFrameworkCore;
using SmartDigitalPsico.Core.SDK.Data.Context.Interface;

using SmartDigitalPsico.Domain.Interfaces.Patient;
using SmartDigitalPsico.Domain.EntityModels;

namespace SmartDigitalPsico.Data.Repository
{
    /// <summary>
    /// Classe responsável por PatientMedicationInformationRepository.
    /// Responsabilidade: repositório de persistência.
    /// Relação: implementa interfaces do Domain e usa o EF Core Context.
    /// </summary>
    public class PatientMedicationInformationRepository : Core.SDK.Data.Repository.Generic.GenericRepositoryEntityBase<PatientMedicationInformation>, IPatientMedicationInformationRepository
    {
        /// <summary>
        /// Método PatientMedicationInformationRepository: executa a operação PatientMedicationInformationRepository.
        /// </summary>
        public PatientMedicationInformationRepository(IEntityDataContext context) : base(context) { }

        /// <summary>
        /// Método FindAllByPatient: consulta e retorna dados.
        /// </summary>
        public async Task<List<PatientMedicationInformation>> FindAllByPatient(long patientId)
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

        /// <summary>
        /// Método FindByID: consulta e retorna dados.
        /// </summary>
        public async override Task<PatientMedicationInformation> FindByID(long id)
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
    }
}
