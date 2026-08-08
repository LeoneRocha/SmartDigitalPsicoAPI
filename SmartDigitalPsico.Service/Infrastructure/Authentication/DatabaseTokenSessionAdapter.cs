using SmartDigitalPsico.Domain.EntityModels.Schedule;

using SmartDigitalPsico.Domain.Interfaces.Common;
using SmartDigitalPsico.Domain.EntityModels;

namespace SmartDigitalPsico.Service.Infrastructure.Authentication
{
    using User = SmartDigitalPsico.Domain.EntityModels.User;
    using Patient = SmartDigitalPsico.Domain.EntityModels.Patient;
    using Medical = SmartDigitalPsico.Domain.EntityModels.Medical;
    using RoleGroup = SmartDigitalPsico.Domain.EntityModels.RoleGroup;
    using Gender = SmartDigitalPsico.Domain.EntityModels.Gender;
    using Leaves = SmartDigitalPsico.Domain.EntityModels.Leaves;
    using Office = SmartDigitalPsico.Domain.EntityModels.Office;
    using Specialty = SmartDigitalPsico.Domain.EntityModels.Specialty;
    /// <summary>
    /// Classe responsável por DatabaseTokenSessionAdapter.
    /// Responsabilidade: infraestrutura transversal (cache, notificação, etc.).
    /// Relação: suporta Services e jobs de background.
    /// </summary>
    public class DatabaseTokenSessionAdapter : ITokenSessionPersistenceAdapter
    {
        private readonly IUserTokenSessionRepository _userTokenSessionRepository;

        /// <summary>
        /// Método DatabaseTokenSessionAdapter: executa a operação DatabaseTokenSessionAdapter.
        /// </summary>
        public DatabaseTokenSessionAdapter(IUserTokenSessionRepository  userTokenSessionRepository)
        {
             _userTokenSessionRepository = userTokenSessionRepository;
        }

        /// <summary>
        /// Método GetSessionAsync: consulta e retorna dados.
        /// </summary>
        public async Task<UserTokenSession?> GetSessionAsync(long userId)
        {
            return await _userTokenSessionRepository.GetSessionAsync(userId);
        }

        /// <summary>
        /// Método SaveSessionAsync: cria ou persiste um novo registro/recurso.
        /// </summary>
        public async Task SaveSessionAsync(UserTokenSession userTokenSession)
        { 
            await _userTokenSessionRepository.SaveSessionAsync(userTokenSession);
        }
    }
}
