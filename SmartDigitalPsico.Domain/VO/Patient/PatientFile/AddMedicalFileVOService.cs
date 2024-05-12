using Microsoft.AspNetCore.Http;
using SmartDigitalPsico.Domain.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace SmartDigitalPsico.Domain.VO.Patient.PatientFile
{
    public class AddPatientFileVOService : IEntityVOAdd 
    {
        #region Relationship 
        [Required]
        public long PatientId { get; set; }
        public IFormFile FileDetails { get; set; }

        [MaxLength(255)]
        public string Description { get; set; } = string.Empty;

        #endregion Relationship 
    }
}