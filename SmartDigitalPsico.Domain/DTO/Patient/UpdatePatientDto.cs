using SmartDigitalPsico.Domain.Enuns;

namespace SmartDigitalPsico.Domain.DTO.Patient
{
    /// <summary>
    /// Classe responsável por UpdatePatientDto.
    /// Responsabilidade: DTO de transferência de dados entre camadas da API.
    /// Relação: usado por Controllers, Services e Validators.
    /// </summary>
    public class UpdatePatientDto : SmartDigitalPsico.Core.SDK.Domain.DTO.Contracts.EntityDtoBase
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
