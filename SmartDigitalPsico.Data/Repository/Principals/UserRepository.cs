using Microsoft.EntityFrameworkCore;
using SmartDigitalPsico.Data.Context;
using SmartDigitalPsico.Domain.Interfaces.Repository;
using SmartDigitalPsico.Domain.ModelEntity;
using SmartDigitalPsico.Data.Repository.Generic;
using SmartDigitalPsico.Domain.Interfaces;

namespace SmartDigitalPsico.Data.Repository.Principals
{
    public class UserRepository : GenericRepositoryEntityBase<User>, IUserRepository
    {
        public UserRepository(SmartDigitalPsicoDataContextMysql context) : base(context) { }

        public async override Task<List<User>> FindAll()
        {
            return await _dataset
                .AsNoTracking()
                 .Include(e => e.UserRoleGroups)
                .ThenInclude(e => e.RoleGroup)
                .ToListAsync();
        }

        public async Task<User?> FindByLogin(string login)
        {
            User? userResult = await _dataset
                .AsNoTracking()
                .Include(e => e.UserRoleGroups)
                .ThenInclude(e => e.RoleGroup)
                .Include(e => e.Medical)
                .FirstOrDefaultAsync(p => p.Login.ToLower().Trim().Equals(login.ToLower().Trim()));

            return userResult;
        } 

        public async Task<bool> UserExists(string login)
        {
            if (await _dataset.AnyAsync(x => x.Login.ToLower().Equals(login.ToLower())))
            {
                return true;
            }
            return false;
        }

        public async override Task<User> FindByID(long id)
        {
#pragma warning disable CS8602
            return await _dataset
                .Include(e => e.UserRoleGroups)
                .ThenInclude(e => e.RoleGroup)
                .Include(e => e.Medical)
                .ThenInclude(m => m.Office)  
                .FirstAsync(p => p.Id.Equals(id));
#pragma warning restore CS8602
        } 
      
        public async Task<User?> FindByEmail(string value)
        {
            User? userResult = await _dataset
                .AsNoTracking()
                .Include(e => e.UserRoleGroups)
                .ThenInclude(e => e.RoleGroup)
                .FirstOrDefaultAsync(p => p.Email.ToLower().Trim().Equals(value.ToLower().Trim()));

            return userResult;
        } 
        public async Task<User> RefreshUserInfo(User user)
        {
            if (!(await _dataset.AnyAsync(u => u.Id.Equals(user.Id)))) return new User();

            var result = await _dataset.SingleOrDefaultAsync(p => p.Id.Equals(user.Id));
            if (result != null)
            {
                _dataset.Entry(result).CurrentValues.SetValues(user);
                await _context.SaveChangesAsync();
                return result;
            }
            return new User();
        } 
    }
}
