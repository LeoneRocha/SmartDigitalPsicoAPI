using SmartDigitalPsico.Domain.ModelEntity;
using SmartDigitalPsico.Domain.DTO.Medical.MedicalFile.ADD;
using SmartDigitalPsico.Domain.DTO.Medical.MedicalFile.GET;
using SmartDigitalPsico.Domain.DTO.Medical.MedicalFile.UPDATE;
using SmartDigitalPsico.Domain.DTO.Medical.MedicalFile.Common;
using SmartDigitalPsico.Domain.DTO.Common;
using SmartDigitalPsico.Core.SDK.Domain.VO;

using MedicalEntity = SmartDigitalPsico.Domain.ModelEntity.Medical;

namespace SmartDigitalPsico.Domain.Interfaces.Medical
{
    /// <summary>
    /// Interface (contrato) responsável por IMedicalFileService.
    /// Responsabilidade: contrato de serviço de negócio.
    /// Relação: implementado na camada Service e consumido pelos Controllers.
    /// </summary>
    public interface IMedicalFileService : SmartDigitalPsico.Core.SDK.Domain.Interfaces.Service.IEntityBaseService<MedicalFile, GetMedicalFileDto>
    {
        /// <summary>
        /// Método DownloadFileById: executa a operação DownloadFileById.
        /// </summary>
        Task<GetMedicalFileDto> DownloadFileById(long fileId);
        /// <summary>
        /// Método PostFileAsync: executa a operação PostFileAsync.
        /// </summary>
        Task<ServiceResponse<GetMedicalFileDto>> PostFileAsync(AddMedicalFileDto entity);

        /// <summary>
        /// Método FindAllByMedical: consulta e retorna dados.
        /// </summary>
        Task<ServiceResponse<List<GetMedicalFileDto>>> FindAllByMedical(long medicalId);
    }
}
