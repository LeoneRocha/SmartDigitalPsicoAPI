using SmartDigitalPsico.Domain.DTO.Contracts;

namespace SmartDigitalPsico.Domain.DTO.Patient.PatientFile
{
    /// <summary>
    /// Classe responsável por UpdatePatientFileDto.
    /// Responsabilidade: DTO de transferência de dados entre camadas da API.
    /// Relação: usado por Controllers, Services e Validators.
    /// </summary>
    public class UpdatePatientFileDto : EntityDtoBase
    { 
        public string Description { get; set; } = string.Empty;          
        public string FilePath { get; set; } = string.Empty;
    }
}
