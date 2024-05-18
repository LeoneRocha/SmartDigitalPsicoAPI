﻿using Microsoft.EntityFrameworkCore;
using SmartDigitalPsico.Data.Context;
using SmartDigitalPsico.Domain.Interfaces.Repository;
using SmartDigitalPsico.Domain.ModelEntity;
using SmartDigitalPsico.Data.Repository.Generic;

namespace SmartDigitalPsico.Data.Repository.Principals
{
    public class UserRepository : GenericRepositoryEntityBase<User>, IUserRepository
    {
        public UserRepository(SmartDigitalPsicoDataContext context) : base(context) { }

        public async Task<User?> FindByLogin(string login)
        {
            User? userResult = await dataset
                .AsNoTracking()
                .Include(e => e.UserRoleGroups)
                .ThenInclude(e => e.RoleGroup)
                .Include(e => e.Medical)
                .FirstOrDefaultAsync(p => p.Login.ToLower().Trim().Equals(login.ToLower().Trim()));

            return userResult;
        }
        public async Task<User> Register(User entityAdd)
        {
            return await base.Create(entityAdd);
        }

        public async Task<bool> UserExists(string login)
        {
            if (await dataset.AnyAsync(x => x.Login.ToLower().Equals(login.ToLower())))
            {
                return true;
            }
            return false;
        }

        public async override Task<User> FindByID(long id)
        {
#pragma warning disable CS8602
            return await dataset
                .Include(e => e.UserRoleGroups)
                .ThenInclude(e => e.RoleGroup)
                .Include(e => e.Medical)
                .ThenInclude(m => m.Office)  
                .FirstAsync(p => p.Id.Equals(id));
#pragma warning restore CS8602
        }

        public async override Task<List<User>> FindAll()
        {
            return await dataset
                .AsNoTracking()
                 .Include(e => e.UserRoleGroups)
                .ThenInclude(e => e.RoleGroup)
                .ToListAsync();
        }
         
        public async Task<User> RefreshUserInfo(User user)
        {
            if (!(await dataset.AnyAsync(u => u.Id.Equals(user.Id)))) return new User();

            var result = await dataset.SingleOrDefaultAsync(p => p.Id.Equals(user.Id));
            if (result != null)
            {
                dataset.Entry(result).CurrentValues.SetValues(user);
                await _context.SaveChangesAsync();
                return result;
            }
            return new User();
        }

        public async Task<User?> FindByEmail(string value)
        {
            User? userResult = await dataset
                .AsNoTracking()
                .Include(e => e.UserRoleGroups)
                .ThenInclude(e => e.RoleGroup)
                .FirstOrDefaultAsync(p => p.Email.ToLower().Trim().Equals(value.ToLower().Trim()));

            return userResult;
        }
    }
}
