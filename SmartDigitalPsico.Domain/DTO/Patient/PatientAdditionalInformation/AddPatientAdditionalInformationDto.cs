using SmartDigitalPsico.Domain.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace SmartDigitalPsico.Domain.DTO.Patient.PatientAdditionalInformation
{
    public class AddPatientAdditionalInformationDto : IEntityDtoAdd
    {
        #region Relationship 
        [Required]
        public long PatientId { get; set; }
        #endregion Relationship

        #region Columns 
        public string FollowUp_Psychiatric { get; set; } = string.Empty;
        public string FollowUp_Neurological { get; set; } = string.Empty;
        #endregion Columns 
    }
}