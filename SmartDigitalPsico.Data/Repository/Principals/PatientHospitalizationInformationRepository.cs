using Microsoft.EntityFrameworkCore;
using SmartDigitalPsico.Data.Context.Interface;
using SmartDigitalPsicoAPI.Core.SDK.Data.Repository.Generic;
using SmartDigitalPsico.Domain.Interfaces.Repository;
using SmartDigitalPsicoAPI.Core.SDK.Domain.Interfaces.Repository;
using SmartDigitalPsico.Domain.ModelEntity;

namespace SmartDigitalPsico.Data.Repository.Principals
{
    /// <summary>
    /// Classe responsável por PatientHospitalizationInformationRepository.
    /// Responsabilidade: repositório de persistência.
    /// Relação: implementa interfaces do Domain e usa o EF Core Context.
    /// </summary>
    public class PatientHospitalizationInformationRepository : SmartDigitalPsicoAPI.Core.SDK.Data.Repository.Generic.GenericRepositoryEntityBase<PatientHospitalizationInformation>, IPatientHospitalizationInformationRepository
    {
        /// <summary>
        /// Método PatientHospitalizationInformationRepository: executa a operação PatientHospitalizationInformationRepository.
        /// </summary>
        public PatientHospitalizationInformationRepository(IEntityDataContext context) : base((Microsoft.EntityFrameworkCore.DbContext)context) { }

        /// <summary>
        /// Método FindAllByPatient: consulta e retorna dados.
        /// </summary>
        public async Task<List<PatientHospitalizationInformation>> FindAllByPatient(long patientId)
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
        public async override Task<PatientHospitalizationInformation> FindByID(long id)
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
