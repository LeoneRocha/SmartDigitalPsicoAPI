using SmartDigitalPsico.Domain.VO.Contracts;

namespace SmartDigitalPsico.Domain.VO.Patient.PatientMedicationInformation
{
    public class UpdatePatientMedicationInformationVO : EntityVOBase
    {

        #region Columns 

        public string Description { get; set; } = string.Empty;

        public DateTime StartDate { get; set; }

        public DateTime? EndDate { get; set; }

        public string Dosage { get; set; } = string.Empty;  

        public string Posology { get; set; } = string.Empty;

        public string MainDrug { get; set; } = string.Empty;

        #endregion Columns 


    }
}