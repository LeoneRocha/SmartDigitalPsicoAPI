using Microsoft.AspNetCore.Http;
using SmartDigitalPsico.Domain.Interfaces;

namespace SmartDigitalPsico.Domain.DTO.Patient.PatientFile
{
    public class AddPatientFileDtoservice : IEntityDtoAdd 
    {
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