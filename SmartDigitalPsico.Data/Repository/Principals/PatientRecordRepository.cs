﻿using Microsoft.EntityFrameworkCore;
using SmartDigitalPsico.Data.Context;
using SmartDigitalPsico.Domain.Interfaces.Repository;
using SmartDigitalPsico.Domain.ModelEntity;
using SmartDigitalPsico.Data.Repository.Generic;

namespace SmartDigitalPsico.Data.Repository.Principals
{
    public class PatientRecordRepository : GenericRepositoryEntityBaseSimple<PatientRecord>, IPatientRecordRepository
    {
        public PatientRecordRepository(SmartDigitalPsicoDataContext context) : base(context) { }

        public async Task<List<PatientRecord>> FindAllByPatient(long patientId)
        {
            return await dataset
                .Include(e => e.Patient)
                .Include(e => e.Patient.Medical)
                .Include(e => e.Patient.Medical.User)
                .Include(e => e.CreatedUser)
                .Where(x => x.Patient.Id == patientId).ToListAsync();
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
