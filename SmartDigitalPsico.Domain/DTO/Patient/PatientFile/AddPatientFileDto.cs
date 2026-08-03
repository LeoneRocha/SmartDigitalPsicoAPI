using Microsoft.AspNetCore.Http;
using SmartDigitalPsico.Domain.DTO.Medical.MedicalFile;
using SmartDigitalPsico.Domain.Interfaces;

namespace SmartDigitalPsico.Domain.DTO.Patient.PatientFile
{
    /// <summary>
    /// Classe responsável por AddPatientFileDto.
    /// Responsabilidade: DTO de transferência de dados entre camadas da API.
    /// Relação: usado por Controllers, Services e Validators.
    /// </summary>
    public class AddPatientFileDto : FileBaseDto, IEntityDtoAdd
    {
        public long PatientId { get; set; }
        public IFormFile FileDetails { get; set; } = new FormFile(Stream.Null, 0, 0, string.Empty, string.Empty);
    }
}
