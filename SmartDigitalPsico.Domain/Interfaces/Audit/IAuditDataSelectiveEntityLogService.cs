using SmartDigitalPsico.Domain.DTO.Audit.GET;

using SmartDigitalPsico.Domain.EntityModels;

namespace SmartDigitalPsico.Domain.Interfaces.Audit
{
    /// <summary>
    /// Interface (contrato) responsável por IAuditDataSelectiveEntityLogService.
    /// Responsabilidade: contrato de serviço de negócio.
    /// Relação: implementado na camada Service e consumido pelos Controllers.
    /// </summary>
    public interface IAuditDataSelectiveEntityLogService : SmartDigitalPsico.Core.SDK.Domain.Interfaces.Service.IEntityBaseService<AuditDataSelectiveEntityLog
, GetAuditDataSelectiveEntityLogDto>
    {

        /// <summary>
        /// Método Save: cria ou persiste um novo registro/recurso.
        /// </summary>
        Task Save(object entryOld, object entryNew, string operation, string[] propertiesToIgnore);
    }
}
