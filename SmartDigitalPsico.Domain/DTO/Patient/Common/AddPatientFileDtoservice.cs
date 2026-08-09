using Microsoft.AspNetCore.Http;

namespace SmartDigitalPsico.Domain.DTO.Patient.Common
{
    /// <summary>
    /// Classe responsável por AddPatientFileDtoservice.
    /// Responsabilidade: DTO de transferência de dados entre camadas da API.
    /// Relação: usado por Controllers, Services e Validators.
    /// </summary>
    public class AddPatientFileDtoservice : SmartDigitalPsico.Core.SDK.Domain.Interfaces.IEntityDtoAdd
    {
        /// <summary>
        /// Método AddPatientFileDtoservice: cria ou persiste um novo registro/recurso.
        /// </summary>
        public AddPatientFileDtoservice()
        {
            FileDetails = new FormFile(Stream.Null, 0, 0, string.Empty, string.Empty);
        }
        #region Relationship  
        public long PatientId { get; set; }
        public IFormFile FileDetails { get; set; }
        public string Description { get; set; } = string.Empty;

        #endregion Relationship 
    }
}
