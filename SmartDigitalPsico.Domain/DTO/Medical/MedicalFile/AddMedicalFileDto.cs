using Microsoft.AspNetCore.Http;
using SmartDigitalPsico.Domain.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace SmartDigitalPsico.Domain.DTO.Medical.MedicalFile
{
    public class AddMedicalFileDto : FileBaseDto, IEntityDtoAdd
    { 
        #region Relationship        
        public long MedicalId { get; set; }
        public IFormFile FileDetails { get; set; } = new FormFile(Stream.Null, 0, 0, string.Empty, string.Empty);
         
        #endregion Relationship 
    }
}