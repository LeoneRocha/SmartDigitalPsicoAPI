using Microsoft.AspNetCore.Http;
using SmartDigitalPsico.Domain.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace SmartDigitalPsico.Domain.VO.Medical.MedicalFile
{
    public class AddMedicalFileVO : FileBaseVO, IEntityVOAdd
    {
        public AddMedicalFileVO()
        {
            FileDetails = new FormFile(Stream.Null, 0, 0, string.Empty, string.Empty);
        }
        #region Relationship 
        [Required]
        public long MedicalId { get; set; }
        public IFormFile FileDetails { get; set; }


        #endregion Relationship 
    }
}