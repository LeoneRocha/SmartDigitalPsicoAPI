using Microsoft.AspNetCore.Http;
using SmartDigitalPsico.Domain.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace SmartDigitalPsico.Domain.DTO.Medical.MedicalFile
{
    /// <summary>
    /// Classe responsável por AddMedicalFileDto.
    /// Responsabilidade: DTO de transferência de dados entre camadas da API.
    /// Relação: usado por Controllers, Services e Validators.
    /// </summary>
    public class AddMedicalFileDto : FileBaseDto, IEntityDtoAdd
    { 
        #region Relationship        
        public long MedicalId { get; set; }
        public IFormFile FileDetails { get; set; } = new FormFile(Stream.Null, 0, 0, string.Empty, string.Empty);
         
        #endregion Relationship 
    }
}
