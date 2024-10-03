using Microsoft.EntityFrameworkCore;
using SmartDigitalPsico.Data.Context.Interface;
using SmartDigitalPsico.Data.Repository.Generic;
using SmartDigitalPsico.Domain.Interfaces.Repository;
using SmartDigitalPsico.Domain.ModelEntity;

namespace SmartDigitalPsico.Data.Repository.SystemDomains
{
    public class UserTokenSessionRepository : GenericRepositoryEntityBase<UserTokenSession>,  IUserTokenSessionRepository 
    {
        public UserTokenSessionRepository(IEntityDataContext context) : base(context) { }

        public async Task<UserTokenSession?> GetSessionAsync(long userId)
        {
            return await _context.UserTokenSessions.FirstOrDefaultAsync(ts => ts.UserId == userId);
        }

        public async Task SaveSessionAsync(UserTokenSession session)
        {
            var existingSession = await _context.UserTokenSessions.SingleOrDefaultAsync(ts => ts.UserId == session.UserId);
            if (existingSession == null)
            {
                await _context.UserTokenSessions.AddAsync(session);
            }
            else
            {
                _context.UserTokenSessions.Update(session);
            }
            await _context.SaveChangesAsync();
        }
    }
}