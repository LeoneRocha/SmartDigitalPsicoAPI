﻿using Microsoft.EntityFrameworkCore;
using SmartDigitalPsico.Data.Context.Interface;
using SmartDigitalPsico.Data.Repository.Generic;
using SmartDigitalPsico.Domain.Interfaces.Repository;
using SmartDigitalPsico.Domain.ModelEntity;

namespace SmartDigitalPsico.Data.Repository.Principals
{
    public class MedicalFileRepository : GenericRepositoryEntityBase<MedicalFile>, IMedicalFileRepository
    {
        public MedicalFileRepository(IEntityDataContext context) : base(context) { }

        public async override Task<List<MedicalFile>> FindAll()
        {
            return await _dataset
                .AsNoTracking()
                .Include(e => e.CreatedUser)//validation required
                .Include(e => e.Medical).ToListAsync();
        }

        public async Task<List<MedicalFile>> FindAllByMedical(long medicalId)
        {
            return await _dataset
                .AsNoTracking()
                .Where(e => e.MedicalId == medicalId)
                .Include(e => e.Medical)
                .Include(e => e.CreatedUser)//validation required
                .ToListAsync();
        }
    }
}
