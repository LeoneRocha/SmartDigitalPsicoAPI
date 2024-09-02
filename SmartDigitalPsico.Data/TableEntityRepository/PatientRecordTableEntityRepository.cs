using SmartDigitalPsico.Domain.Interfaces.TableEntity;
using SmartDigitalPsico.Domain.TableEntityNoSQL;

namespace SmartDigitalPsico.Data.TableEntityRepository
{
    public class PatientRecordTableEntityRepository : GenericTableEntityRepository<PatientRecordTableEntity>
    {
        public PatientRecordTableEntityRepository(IStorageTableServiceFactory tableStorageServiceFactory) 
            : base(tableStorageServiceFactory, "PatientRecordTable")
        {
        }
    }
}
