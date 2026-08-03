using SmartDigitalPsico.Domain.ModelEntity;
using SmartDigitalPsico.Domain.DTO.Patient.PatientFile;
using SmartDigitalPsico.Domain.VO;

namespace SmartDigitalPsico.Domain.Interfaces.Service
{
    /// <summary>
    /// Interface (contrato) responsável por IPatientFileService.
    /// Responsabilidade: contrato de serviço de negócio.
    /// Relação: implementado na camada Service e consumido pelos Controllers.
    /// </summary>
    public interface IPatientFileService : IEntityBaseService<PatientFile, GetPatientFileDto>
    {
        /// <summary>
        /// Método DownloadFileById: executa a operação DownloadFileById.
        /// </summary>
        Task<GetPatientFileDto> DownloadFileById(long fileId);
        /// <summary>
        /// Método PostFileAsync: executa a operação PostFileAsync.
        /// </summary>
        Task<bool> PostFileAsync(AddPatientFileDto entity);
           
        /// <summary>
        /// Método FindAllByPatient: consulta e retorna dados.
        /// </summary>
        Task<ServiceResponse<List<GetPatientFileDto>>> FindAllByPatient(long patientId); 
    }
}
