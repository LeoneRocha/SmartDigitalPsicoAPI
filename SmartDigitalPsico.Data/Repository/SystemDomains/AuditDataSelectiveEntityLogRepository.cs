using SmartDigitalPsico.Data.Context;
using SmartDigitalPsico.Data.Repository.Generic;
using SmartDigitalPsico.Domain.Interfaces.Repository;
using SmartDigitalPsico.Domain.ModelEntity;

namespace SmartDigitalPsico.Data.Repository.SystemDomains
{
    public class AuditDataSelectiveEntityLogRepository : GenericRepositoryEntityBase<AuditDataSelectiveEntityLog>, IAuditDataSelectiveEntityLogRepository
    {
        public AuditDataSelectiveEntityLogRepository(SmartDigitalPsicoDataContextMysql context) : base(context) { }

    }
}
