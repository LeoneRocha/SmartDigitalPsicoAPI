using Microsoft.EntityFrameworkCore;
using SmartDigitalPsico.Core.SDK.Data.Context.Interface;

using SmartDigitalPsico.Domain.Interfaces.User;
using SmartDigitalPsico.Domain.EntityModels;

namespace SmartDigitalPsico.Data.Repository
{
    /// <summary>
    /// Classe responsável por UserRepository.
    /// Responsabilidade: repositório de persistência.
    /// Relação: implementa interfaces do Domain e usa o EF Core Context.
    /// </summary>
    public class UserRepository : Core.SDK.Data.Repository.Generic.GenericRepositoryEntityBase<User>, IUserRepository
    {
        /// <summary>
        /// Método UserRepository: executa a operação UserRepository.
        /// </summary>
        public UserRepository(IEntityDataContext context) : base(context) { }

        /// <summary>
        /// Método FindAll: consulta e retorna dados.
        /// </summary>
        public async override Task<List<User>> FindAll()
        {
            return await _dataset
                .AsNoTracking()
                 .Include(e => e.UserRoleGroups)
                .ThenInclude(e => e.RoleGroup)
                .ToListAsync();
        }

        /// <summary>
        /// Método FindByLogin: consulta e retorna dados.
        /// </summary>
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

        /// <summary>
        /// Método UserExists: executa a operação UserExists.
        /// </summary>
        public async Task<bool> UserExists(string login)
        {
            if (await _dataset.AnyAsync(x => x.Login.ToLower().Equals(login.ToLower())))
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Método FindByID: consulta e retorna dados.
        /// </summary>
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

        /// <summary>
        /// Método FindByEmail: consulta e retorna dados.
        /// </summary>
        public async Task<User?> FindByEmail(string value)
        {
            User? userResult = await _dataset
                .AsNoTracking()
                .Include(e => e.UserRoleGroups)
                .ThenInclude(e => e.RoleGroup)
                .FirstOrDefaultAsync(p => p.Email.ToLower().Trim().Equals(value.ToLower().Trim()));

            return userResult;
        }
        /// <summary>
        /// Método RefreshUserInfo: executa a operação RefreshUserInfo.
        /// </summary>
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
        /// <summary>
        /// Método Delete: remove ou cancela um registro/recurso.
        /// </summary>
        public override async Task<bool> Delete(long id)
        {
            var result = await _dataset.Include(x => x.UserRoleGroups).SingleOrDefaultAsync(p => p.Id.Equals(id));
            if (result != null)
            {
                result.UserRoleGroups.Clear();
                _dataset.Remove(result);
                await _context.SaveChangesAsync();
            }
            return true;
        }

    }
}
