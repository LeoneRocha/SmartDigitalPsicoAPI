using SmartDigitalPsico.Domain.VO.Contracts;
using System.ComponentModel.DataAnnotations;

namespace SmartDigitalPsico.Domain.VO.Patient.PatientAdditionalInformation
{
    public class AddPatientAdditionalInformationVO : IEntityVOAdd
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