using SmartDigitalPsico.Domain.ModelEntity;
using SmartDigitalPsico.Domain.DTO.Medical.MedicalFile;
using SmartDigitalPsico.Domain.VO;

namespace SmartDigitalPsico.Domain.Interfaces.Service
{
    /// <summary>
    /// Interface (contrato) responsável por IMedicalFileService.
    /// Responsabilidade: contrato de serviço de negócio.
    /// Relação: implementado na camada Service e consumido pelos Controllers.
    /// </summary>
    public interface IMedicalFileService : IEntityBaseService<MedicalFile, AddMedicalFileDto, UpdateMedicalFileDto, GetMedicalFileDto>
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
