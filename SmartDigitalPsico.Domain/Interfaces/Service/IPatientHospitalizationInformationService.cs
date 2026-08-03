using SmartDigitalPsico.Domain.ModelEntity;
using SmartDigitalPsico.Domain.DTO.Patient.PatientHospitalizationInformation;
using SmartDigitalPsico.Domain.VO;

namespace SmartDigitalPsico.Domain.Interfaces.Service
{
    /// <summary>
    /// Interface (contrato) responsável por IPatientHospitalizationInformationService.
    /// Responsabilidade: contrato de serviço de negócio.
    /// Relação: implementado na camada Service e consumido pelos Controllers.
    /// </summary>
    public interface IPatientHospitalizationInformationService : IEntityBaseService<PatientHospitalizationInformation, AddPatientHospitalizationInformationDto ,UpdatePatientHospitalizationInformationDto , GetPatientHospitalizationInformationDto>
    {  
        /// <summary>
        /// Método FindAllByPatient: consulta e retorna dados.
        /// </summary>
        Task<ServiceResponse<List<GetPatientHospitalizationInformationDto>>> FindAllByPatient(long patientId);
    }
}
