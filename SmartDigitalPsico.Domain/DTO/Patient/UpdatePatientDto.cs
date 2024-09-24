using SmartDigitalPsico.Domain.DTO.Contracts;
using SmartDigitalPsico.Domain.Enuns;

namespace SmartDigitalPsico.Domain.DTO.Patient
{
    public class UpdatePatientDto : EntityDtoBase
    {
        #region Columns
        public string Name { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public DateTime DateOfBirth { get; set; }
        public string Profession { get; set; } = string.Empty;
        public string Cpf { get; set; } = string.Empty;
        public string Rg { get; set; } = string.Empty;
        public string Education { get; set; } = string.Empty;
        public string PhoneNumber { get; set; } = string.Empty;      
        public string AddressStreet { get; set; } = string.Empty;      
        public string AddressNeighborhood { get; set; } = string.Empty;      
        public string AddressCity { get; set; } = string.Empty;      
        public string AddressState { get; set; } = string.Empty;      
        public string AddressCep { get; set; } = string.Empty;       
        public string EmergencyContactName { get; set; } = string.Empty;     
        public string EmergencyContactPhoneNumber { get; set; } = string.Empty;
        public long GenderId { get; set; }
        public EMaritalStatus MaritalStatus { get; set; }
        #endregion
    }
}