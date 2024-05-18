using Microsoft.AspNetCore.Http;
using SmartDigitalPsico.Domain.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace SmartDigitalPsico.Domain.VO.Patient.PatientFile
{
    public class AddPatientFileVOService : IEntityVOAdd 
    {
        public AddPatientFileVOService()
        {
            FileDetails = new FormFile(Stream.Null, 0, 0, string.Empty, string.Empty);
        }
        #region Relationship 
        [Required]
        public long PatientId { get; set; }
        public IFormFile FileDetails { get; set; }

        [MaxLength(255)]
        public string Description { get; set; } = string.Empty;

        #endregion Relationship 
    }
}