using Microsoft.EntityFrameworkCore;
using SmartDigitalPsico.Core.SDK.Data.Context.Interface;
using SmartDigitalPsico.Domain.EntityModels;
using SmartDigitalPsico.Domain.Interfaces.Common;

namespace SmartDigitalPsico.Data.Repository
{
    /// <summary>
    /// Classe responsável por UserTokenSessionRepository.
    /// Responsabilidade: repositório de persistência.
    /// Relação: implementa interfaces do Domain e usa o EF Core Context.
    /// </summary>
    public class UserTokenSessionRepository : Core.SDK.Data.Repository.Generic.GenericRepositoryEntityBase<UserTokenSession>, IUserTokenSessionRepository
    {
        /// <summary>
        /// Método UserTokenSessionRepository: executa a operação UserTokenSessionRepository.
        /// </summary>
        public UserTokenSessionRepository(IEntityDataContext context) : base(context) { }

        /// <summary>
        /// Método GetSessionAsync: consulta e retorna dados.
        /// </summary>
        public async Task<UserTokenSession?> GetSessionAsync(long userId)
        {
            return await ((Context.EntityDataSmartDigitalPsicoContext)_context).UserTokenSessions.FirstOrDefaultAsync(ts => ts.UserId == userId);
        }

        /// <summary>
        /// Método SaveSessionAsync: cria ou persiste um novo registro/recurso.
        /// </summary>
        public async Task SaveSessionAsync(UserTokenSession session)
        {
            var existingSession = await ((Context.EntityDataSmartDigitalPsicoContext)_context).UserTokenSessions.SingleOrDefaultAsync(ts => ts.UserId == session.UserId);
            if (existingSession == null)
            {
                await ((Context.EntityDataSmartDigitalPsicoContext)_context).UserTokenSessions.AddAsync(session);
            }
            else
            {
                ((Context.EntityDataSmartDigitalPsicoContext)_context).UserTokenSessions.Update(session);
            }
            await _context.SaveChangesAsync();
        }
    }
}
