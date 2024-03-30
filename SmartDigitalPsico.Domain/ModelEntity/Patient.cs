using SmartDigitalPsico.Domain.Contracts;
using SmartDigitalPsico.Domain.Enuns;
using SmartDigitalPsico.Domain.Interfaces;

namespace SmartDigitalPsico.Domain.ModelEntity
{
    public class Patient : EntityBaseWithNameEmail, IEntityBaseLogUser
    {
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

        public List<PatientInfoTag> PatientInfoTags { get; set; }
        public Medical Medical { get; set; } = new Medical();
        public long MedicalId { get; set; }
        public List<PatientAdditionalInformation> PatientAdditionalInformations { get; set; }
        public List<PatientHospitalizationInformation> PatientHospitalizationInformations { get; set; }
        public List<PatientMedicationInformation> PatientMedicationInformations { get; set; }
        public List<PatientRecord> PatientRecords { get; set; }
        public User? CreatedUser { get; set; }
        public long? CreatedUserId { get; set; }
        public User? ModifyUser { get; set; }
        public long? ModifyUserId { get; set; }
        public Gender Gender { get; set; } = new Gender();
        public long GenderId { get; set; }
        #endregion Relationship
    }
}