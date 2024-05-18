using Microsoft.AspNetCore.Http;
using SmartDigitalPsico.Domain.Interfaces;
using SmartDigitalPsico.Domain.VO.Medical.MedicalFile;
using System.ComponentModel.DataAnnotations;

namespace SmartDigitalPsico.Domain.VO.Patient.PatientFile
{
    public class AddPatientFileVO : FileBaseVO, IEntityVOAdd
    {
        public AddPatientFileVO()
        {
            FileDetails = new FormFile(Stream.Null, 0, 0, string.Empty, string.Empty);
        }
        [Required]
        public long PatientId { get; set; }
        public IFormFile FileDetails { get; set; }
         
    }
}