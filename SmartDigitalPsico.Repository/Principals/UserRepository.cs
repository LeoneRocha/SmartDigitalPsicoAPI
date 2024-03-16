using Microsoft.EntityFrameworkCore;
using SmartDigitalPsico.Data.Context;
using SmartDigitalPsico.Domain.Interfaces.Repository;
using SmartDigitalPsico.Domain.ModelEntity;
using SmartDigitalPsico.Repository.Generic;

namespace SmartDigitalPsico.Repository.Principals
{
    public class UserRepository : GenericRepositoryEntityBase<User>, IUserRepository 
    {
        public UserRepository(SmartDigitalPsicoDataContext context) : base(context) { }

        public async Task<User> FindByLogin(string login)
        {
            User userResult = await dataset
                .Include(e => e.RoleGroups)
                .Include(e => e.Medical)
                .FirstAsync(p => p.Login.ToLower().Trim().Equals(login.ToLower().Trim()));

            return userResult;
        }
        public async Task<User> Register(User entityAdd)
        {
            dataset.Add(entityAdd);
            await _context.SaveChangesAsync();
            return entityAdd;
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
            return await dataset
                .Include(e => e.RoleGroups)
                .Include(e => e.Medical)
                .Include(e => e.Medical.Specialties)
                .Include(e => e.Medical.Office)
                .FirstAsync(p => p.Id.Equals(id));
        }

        public async override Task<List<User>> FindAll()
        {
            return await dataset
                .Include(e => e.RoleGroups)
                .ToListAsync();
        }
         
 

        public async Task<User> RefreshUserInfo(User user)
        {
            if (!dataset.Any(u => u.Id.Equals(user.Id))) return null;

            var result = await dataset.SingleOrDefaultAsync(p => p.Id.Equals(user.Id));
            if (result != null)
            {
                try
                {
                    dataset.Entry(result).CurrentValues.SetValues(user);
                    await _context.SaveChangesAsync();
                    return result;
                }
                catch (Exception)
                {
                    throw;
                }
            }
            return result;
        }

        public async Task<User> FindByEmail(string value)
        {
            User userResult = await dataset.Include(e => e.RoleGroups).FirstAsync(p => p.Email.ToLower().Trim().Equals(value.ToLower().Trim()));

            return userResult;
        } 
    }
}
