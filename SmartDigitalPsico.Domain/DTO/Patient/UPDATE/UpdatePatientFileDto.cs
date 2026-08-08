namespace SmartDigitalPsico.Domain.DTO.Patient.UPDATE
{
    /// <summary>
    /// Classe responsável por UpdatePatientFileDto.
    /// Responsabilidade: DTO de transferência de dados entre camadas da API.
    /// Relação: usado por Controllers, Services e Validators.
    /// </summary>
    public class UpdatePatientFileDto : SmartDigitalPsico.Core.SDK.Domain.DTO.Contracts.EntityDtoBase
    { 
        public string Description { get; set; } = string.Empty;          
        public string FilePath { get; set; } = string.Empty;
    }
}
