using Microsoft.AspNetCore.Http;
using SmartDigitalPsico.Domain.VO.Contracts;
using SmartDigitalPsico.Domain.VO.Medical.MedicalFile;
using System.ComponentModel.DataAnnotations;

namespace SmartDigitalPsico.Domain.VO.Patient.PatientFile
{
    public class AddPatientFileVO : FileBaseVO, IEntityVOAdd
    {
        #region Relationship 
        [Required]
        public long PatientId { get; set; }
        public IFormFile FileDetails { get; set; }


        #endregion Relationship
    }
}