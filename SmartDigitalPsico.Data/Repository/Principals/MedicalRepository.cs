﻿using Microsoft.EntityFrameworkCore;
using SmartDigitalPsico.Data.Context;
using SmartDigitalPsico.Domain.Interfaces.Repository;
using SmartDigitalPsico.Domain.ModelEntity;
using SmartDigitalPsico.Data.Repository.Generic;

namespace SmartDigitalPsico.Data.Repository.Principals
{
    public class MedicalRepository : GenericRepositoryEntityBase<Medical>, IMedicalRepository
    {
        public MedicalRepository(SmartDigitalPsicoDataContext context) : base(context) { }

        public async Task<bool> Exists(string accreditation)
        {
            return await dataset
                .AsNoTracking()
                .AnyAsync(x => x.Accreditation.ToLower().Equals(accreditation.ToLower()));
        }
        public async override Task<Medical?> FindByID(long id)
        {
            return await dataset
                .AsNoTracking()
                .Include(e => e.Office) 
                .FirstOrDefaultAsync(p => p.Id.Equals(id));
        }
        public async override Task<List<Medical>> FindAll()
        {
            return await dataset
                .AsNoTracking()
                .Include(e => e.Office) 
                .ToListAsync();
        }

        public async Task<Medical?> FindByEmail(string value)
        {
            Medical? entityResult = await dataset
                .AsNoTracking()
                .FirstOrDefaultAsync(p => p.Email.ToLower().Trim().Equals(value.ToLower().Trim()));

            return entityResult;
        } 
        public async Task<Medical?> FindByAccreditation(string value)
        {
            Medical? entityResult = await dataset
                .AsNoTracking()
                .FirstOrDefaultAsync(p => p.Accreditation.ToLower().Trim().Equals(value.ToLower().Trim()));

            return entityResult;
        }  
    }
}
