using Microsoft.AspNetCore.Http;
using SmartDigitalPsico.Domain.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace SmartDigitalPsico.Domain.DTO.Medical.MedicalFile
{
    /// <summary>
    /// Classe responsável por AddMedicalFileDtoService.
    /// Responsabilidade: DTO de transferência de dados entre camadas da API.
    /// Relação: usado por Controllers, Services e Validators.
    /// </summary>
    public class AddMedicalFileDtoService : IEntityDtoAdd
    {
        #region Relationship 
        public long MedicalId { get; set; }
        public IFormFile FileDetails { get; set; } = new FormFile(Stream.Null, 0, 0, string.Empty, string.Empty);
        public string Description { get; set; } = string.Empty;
        #endregion Relationship 
    }
}
