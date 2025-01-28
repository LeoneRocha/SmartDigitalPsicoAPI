using AutoMapper;
using Azure;
using SmartDigitalPsico.Domain.Helpers;
using SmartDigitalPsico.Domain.Interfaces.Repository;
using SmartDigitalPsico.Domain.Interfaces.TableEntity;
using SmartDigitalPsico.Domain.ModelEntity;
using SmartDigitalPsico.Domain.TableEntityNoSQL;

namespace SmartDigitalPsico.Service.Infrastructure.Authentication
{
    public class TableStorageTokenSessionAdapter : ITokenSessionPersistenceAdapter
    {
        private readonly IStorageTableContract<UserTokenSessionTableEntity> _storageTableService;
        private readonly IMapper _mapper;

        public TableStorageTokenSessionAdapter(IMapper mapper, IStorageTableContract<UserTokenSessionTableEntity> storageTableService)
        {
            _storageTableService = storageTableService;
            _mapper = mapper;
        }

        public async Task<UserTokenSession?> GetSessionAsync(long userId)
        {
            var resultTableEntity = await _storageTableService.GetByIdAsync("UserTokenSession", userId.ToString());

            var result = _mapper.Map<UserTokenSession>(resultTableEntity);

            return result;
        }

        public async Task SaveSessionAsync(UserTokenSession userTokenSession)
        {
            var addToken = _mapper.Map<UserTokenSessionTableEntity>(userTokenSession);
            addToken.PartitionKey = "UserTokenSession";
            addToken.RowKey = userTokenSession.UserId.ToString();
            addToken.ETag = ETag.All;

            var tableFounded = await _storageTableService.GetByIdAsync(addToken.PartitionKey, addToken.RowKey);
            if (tableFounded != null && tableFounded.ExpiresAt <= DateHelper.GetDateTimeNowFromUtc())
            {
                await _storageTableService.DeleteAsync(addToken.PartitionKey, addToken.RowKey);
            }
            await _storageTableService.UpdateAsync(addToken);
        }
    }
}