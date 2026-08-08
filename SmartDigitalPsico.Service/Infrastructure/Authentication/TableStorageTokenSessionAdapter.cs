using SmartDigitalPsico.Core.SDK.Domain.Interfaces.Mapping;
using Azure;
using SmartDigitalPsico.Domain.EntityModels.Schedule;
using SmartDigitalPsico.Domain.TableEntityNoSQL;

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
    /// Classe responsável por TableStorageTokenSessionAdapter.
    /// Responsabilidade: infraestrutura transversal (cache, notificação, etc.).
    /// Relação: suporta Services e jobs de background.
    /// </summary>
    public class TableStorageTokenSessionAdapter : ITokenSessionPersistenceAdapter
    {
        private readonly SmartDigitalPsico.Core.SDK.Domain.Interfaces.TableEntity.IStorageTableContract<UserTokenSessionTableEntity> _storageTableService;
        private readonly IAppMapper _mapper;

        /// <summary>
        /// Método TableStorageTokenSessionAdapter: executa a operação TableStorageTokenSessionAdapter.
        /// </summary>
        public TableStorageTokenSessionAdapter(IAppMapper mapper, SmartDigitalPsico.Core.SDK.Domain.Interfaces.TableEntity.IStorageTableContract<UserTokenSessionTableEntity> storageTableService)
        {
            _storageTableService = storageTableService;
            _mapper = mapper;
        }

        /// <summary>
        /// Método GetSessionAsync: consulta e retorna dados.
        /// </summary>
        public async Task<UserTokenSession?> GetSessionAsync(long userId)
        {
            var resultTableEntity = await _storageTableService.GetByIdAsync("UserTokenSession", userId.ToString());

            var result = _mapper.Map<UserTokenSession>(resultTableEntity);

            return result;
        }

        /// <summary>
        /// Método SaveSessionAsync: cria ou persiste um novo registro/recurso.
        /// </summary>
        public async Task SaveSessionAsync(UserTokenSession userTokenSession)
        {
            var addToken = _mapper.Map<UserTokenSessionTableEntity>(userTokenSession);
            addToken.PartitionKey = "UserTokenSession";
            addToken.RowKey = userTokenSession.UserId.ToString();
            addToken.ETag = ETag.All;

            var tableFounded = await _storageTableService.GetByIdAsync(addToken.PartitionKey, addToken.RowKey);
            if (tableFounded != null && tableFounded.ExpiresAt <= SmartDigitalPsico.Core.SDK.Domain.Helpers.DateHelper.GetDateTimeNowFromUtc())
            {
                await _storageTableService.DeleteAsync(addToken.PartitionKey, addToken.RowKey);
            }
            await _storageTableService.UpdateAsync(addToken);
        }
    }
}
