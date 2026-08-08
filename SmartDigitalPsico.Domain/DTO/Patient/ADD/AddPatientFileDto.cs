using Microsoft.AspNetCore.Http;
using SmartDigitalPsico.Domain.DTO.Common;

namespace SmartDigitalPsico.Domain.DTO.Patient.ADD
{
    /// <summary>
    /// Classe responsável por AddPatientFileDto.
    /// Responsabilidade: DTO de transferência de dados entre camadas da API.
    /// Relação: usado por Controllers, Services e Validators.
    /// </summary>
    public class AddPatientFileDto : FileBaseDto, SmartDigitalPsico.Core.SDK.Domain.Interfaces.IEntityDtoAdd
    {
        public long PatientId { get; set; }
        public IFormFile FileDetails { get; set; } = new FormFile(Stream.Null, 0, 0, string.Empty, string.Empty);
    }
}
