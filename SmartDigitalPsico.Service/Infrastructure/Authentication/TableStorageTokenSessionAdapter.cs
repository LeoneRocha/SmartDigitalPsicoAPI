using AutoMapper;
using SmartDigitalPsico.Domain.Interfaces.Repository;
using SmartDigitalPsico.Domain.Interfaces.TableEntity;
using SmartDigitalPsico.Domain.ModelEntity;
using SmartDigitalPsico.Domain.TableEntityNoSQL;

namespace SmartDigitalPsico.Service.Infrastructure.Authentication
{
    public class TableStorageTokenSessionAdapter : ITokenSessionAdapter
    {
        private readonly IStorageTableContract<UserTokenSessionTableEntity> _storageService;
        private readonly IMapper _mapper;
        public TableStorageTokenSessionAdapter(IMapper mapper,
            IStorageTableContract<UserTokenSessionTableEntity> storageTableService)
        {
            _mapper = mapper;
            _storageService = storageTableService;
        }
        public async Task<UserTokenSession> GetSessionAsync(long userId)
        {
            UserTokenSessionTableEntity entityStorage =
                await _storageService.GetByIdAsync("UserTokenSession", userId.ToString());

            UserTokenSession entity = _mapper.Map<UserTokenSession>(entityStorage);

            return entity;
        }

        public async Task SaveSessionAsync(UserTokenSession userTokenSession)
        {
            UserTokenSessionTableEntity entityStorage = _mapper.Map<UserTokenSessionTableEntity>(userTokenSession);

            entityStorage.PartitionKey = "TokenSession";
            entityStorage.RowKey = entityStorage.UserId.ToString();

            await _storageService.InsertAsync(entityStorage);
        }
    }
}