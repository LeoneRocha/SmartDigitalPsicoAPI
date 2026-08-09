using Microsoft.EntityFrameworkCore;
using SmartDigitalPsico.Core.SDK.Data.Context.Interface;
using SmartDigitalPsico.Domain.DTO.Patient.Common;

using SmartDigitalPsico.Domain.Interfaces.Patient;
using SmartDigitalPsico.Domain.EntityModels;

namespace SmartDigitalPsico.Data.Repository.Principals
{
    /// <summary>
    /// Classe responsável por PatientRepository.
    /// Responsabilidade: repositório de persistência.
    /// Relação: implementa interfaces do Domain e usa o EF Core Context.
    /// </summary>
    public class PatientRepository : SmartDigitalPsico.Core.SDK.Data.Repository.Generic.GenericRepositoryEntityBase<Patient>, IPatientRepository
    {
        /// <summary>
        /// Método PatientRepository: executa a operação PatientRepository.
        /// </summary>
        public PatientRepository(IEntityDataContext context) : base(context) { }

        /// <summary>
        /// Find by Cpf, Rg , Email
        /// </summary>
        /// <param name="patient"></param>
        /// <returns></returns>
        /// <summary>
        /// Método FindByPatient: consulta e retorna dados.
        /// </summary>
        public async Task<Patient> FindByPatient(Patient patient)
        {
            return await _dataset
                .AsNoTracking()
                .FirstAsync(x =>
               x.Cpf.ToLower().Equals(patient.Cpf.ToLower())
            || x.Rg.ToLower().Equals(patient.Rg.ToLower())
            || x.Email.ToLower().Equals(patient.Email.ToLower())
            );
        }

        /// <summary>
        /// Método FindByID: consulta e retorna dados.
        /// </summary>
        public async override Task<Patient> FindByID(long id)
        {
#pragma warning disable CS8602
            return await _dataset
                .Include(e => e.Medical)
                .Include(e => e.Gender)
                .Include(e => e.Medical)
                .ThenInclude(e => e.User)
                .Include(e => e.CreatedUser)
                .FirstAsync(p => p.Id.Equals(id));
#pragma warning restore CS8602
        }
        /// <summary>
        /// Método FindByEmail: consulta e retorna dados.
        /// </summary>
        public async Task<Patient?> FindByEmail(string email)
        {
            Patient? entityResult = await _dataset
                .AsNoTracking()
                .FirstOrDefaultAsync(p => p.Email.ToLower().Trim().Equals(email.ToLower().Trim()));

            return entityResult;
        }

        /// <summary>
        /// Método FindAllByMedicalId: consulta e retorna dados.
        /// </summary>
        public async Task<List<Patient>> FindAllByMedicalId(long medicalId)
        {
#pragma warning disable CS8602
            return await _dataset
                .AsNoTracking()
               .Include(e => e.Gender)
               .Include(e => e.Medical)
               .ThenInclude(e => e.User)
               .Include(e => e.CreatedUser)
               .Where(p => p.MedicalId == medicalId)
               .ToListAsync();
#pragma warning restore CS8602
        }
        /// <summary>
        /// Método GetPatientDetailsByIdAsync: consulta e retorna dados.
        /// </summary>
        public async Task<Patient> GetPatientDetailsByIdAsync(long id)
        {
            Patient entityResponse = await _dataset
                .AsNoTracking()
                .AsSplitQuery()
                .Include(p => p.Medical)
                .ThenInclude(e => e!.User)
                .Include(p => p.CreatedUser)
                .Include(p => p.ModifyUser)
                .Include(p => p.Gender)
                .Include(p => p.PatientInfoTags)
                .Include(p => p.PatientAdditionalInformations)
                .Include(p => p.PatientHospitalizationInformations)
                .Include(p => p.PatientMedicationInformations)
                .Include(p => p.PatientRecords)
                .FirstAsync(p => p.Id == id);
            return entityResponse;
        }

        /// <summary>
        /// Método PatientSearch: executa a operação PatientSearch.
        /// </summary>
        public async Task<List<Patient>> PatientSearch(PatientSearchCriteriaDto patientSearchCriteriaDto)
        {
#pragma warning disable CS8602
            return await _dataset
                .AsNoTracking()
                .Where(p => p.MedicalId == patientSearchCriteriaDto.MedicalId && p.Name.StartsWith(patientSearchCriteriaDto.Name, StringComparison.OrdinalIgnoreCase))
                .Select(e => new Patient
                {
                    Id = e.Id,
                    Name = e.Name
                })
                .ToListAsync();
#pragma warning restore CS8602
        }

    }
}
