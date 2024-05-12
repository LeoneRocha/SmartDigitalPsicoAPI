using Microsoft.AspNetCore.Http;
using SmartDigitalPsico.Domain.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace SmartDigitalPsico.Domain.VO.Medical.MedicalFile
{
    public class AddMedicalFileVOService : IEntityVOAdd 
    {
        #region Relationship 
        [Required]
        public long MedicalId { get; set; }
        public IFormFile FileDetails { get; set; }

        [MaxLength(255)]
        public string Description { get; set; } = string.Empty;

        #endregion Relationship 
    }
}