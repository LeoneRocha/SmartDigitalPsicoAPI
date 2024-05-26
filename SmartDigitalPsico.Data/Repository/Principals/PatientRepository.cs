using Microsoft.EntityFrameworkCore;
using SmartDigitalPsico.Data.Context;
using SmartDigitalPsico.Data.Repository.Generic;
using SmartDigitalPsico.Domain.Interfaces.Repository;
using SmartDigitalPsico.Domain.ModelEntity;

namespace SmartDigitalPsico.Data.Repository.Principals
{
    public class PatientRepository : GenericRepositoryEntityBase<Patient>, IPatientRepository
    {
        public PatientRepository(SmartDigitalPsicoDataContext context) : base(context) { }

        /// <summary>
        /// Find by Cpf, Rg , Email
        /// </summary>
        /// <param name="patient"></param>
        /// <returns></returns>
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
        public async override Task<List<Patient>> FindAll()
        {
            await Task.Yield();
            throw new NotImplementedException();
        }
        public async Task<Patient?> FindByEmail(string email)
        {
            Patient? entityResult = await _dataset
                .AsNoTracking()
                .FirstOrDefaultAsync(p => p.Email.ToLower().Trim().Equals(email.ToLower().Trim()));

            return entityResult;
        }

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
    }
}
