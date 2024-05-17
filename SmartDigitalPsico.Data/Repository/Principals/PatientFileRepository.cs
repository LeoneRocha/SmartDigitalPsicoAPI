﻿using Microsoft.EntityFrameworkCore;
using SmartDigitalPsico.Data.Context;
using SmartDigitalPsico.Domain.Interfaces.Repository;
using SmartDigitalPsico.Domain.ModelEntity;
using SmartDigitalPsico.Data.Repository.Generic;

namespace SmartDigitalPsico.Data.Repository.Principals
{
    public class PatientFileRepository : GenericRepositoryEntityBase<PatientFile>, IPatientFileRepository
    {
        public PatientFileRepository(SmartDigitalPsicoDataContext context) : base(context) { }

        public async override Task<PatientFile> FindByID(long id)
        {
            return await dataset 
                .Include(e => e.Patient)
                .Include(e => e.Patient.Medical)
                .Include(e => e.Patient.Medical.User)
                .Include(e => e.CreatedUser)
                .FirstAsync(p => p.Id.Equals(id));
        }
        public async override Task<List<PatientFile>> FindAll()
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
