using SmartDigitalPsico.Domain.Contracts;
using SmartDigitalPsico.Domain.Enuns;
using SmartDigitalPsico.Domain.Interfaces;

namespace SmartDigitalPsico.Domain.ModelEntity
{
    public class Patient : EntityBaseWithNameEmail, IEntityBaseLogUser, IEntityMedicalBase
    {
        public Patient()
        {
            PatientInfoTags = new List<PatientInfoTag>();
            PatientAdditionalInformations = new List<PatientAdditionalInformation>();
            PatientHospitalizationInformations = new List<PatientHospitalizationInformation>();
            PatientMedicationInformations = new List<PatientMedicationInformation>();
            PatientRecords = new List<PatientRecord>();
        }
        #region Columns
        public DateTime DateOfBirth { get; set; }
        public string Profession { get; set; } = string.Empty;
        public string Cpf { get; set; } = string.Empty;
        public string Rg { get; set; } = string.Empty;
        public string Education { get; set; } = string.Empty;
        public EMaritalStatus MaritalStatus { get; set; }
        public string PhoneNumber { get; set; } = string.Empty;
        public string AddressStreet { get; set; } = string.Empty;
        public string AddressNeighborhood { get; set; } = string.Empty;
        public string AddressCity { get; set; } = string.Empty;
        public string AddressState { get; set; } = string.Empty;
        public string AddressCep { get; set; } = string.Empty;
        public string EmergencyContactName { get; set; } = string.Empty;
        public string EmergencyContactPhoneNumber { get; set; } = string.Empty;

        #endregion

        #region Relationship  

        public Medical? Medical { get; set; }
        public long MedicalId { get; set; }

        public User? CreatedUser { get; set; }
        public long? CreatedUserId { get; set; }
        public User? ModifyUser { get; set; }
        public long? ModifyUserId { get; set; }
        public Gender? Gender { get; set; }
        public long GenderId { get; set; }

        public ICollection<PatientInfoTag> PatientInfoTags { get; set; }
        public ICollection<PatientAdditionalInformation> PatientAdditionalInformations { get; set; }
        public ICollection<PatientHospitalizationInformation> PatientHospitalizationInformations { get; set; }
        public ICollection<PatientMedicationInformation> PatientMedicationInformations { get; set; }
        public ICollection<PatientRecord> PatientRecords { get; set; }

        #endregion Relationship
    }
}