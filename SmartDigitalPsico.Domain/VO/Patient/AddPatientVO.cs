using SmartDigitalPsico.Domain.Enuns;
using SmartDigitalPsico.Domain.VO.Contracts;
using System.ComponentModel.DataAnnotations;

namespace SmartDigitalPsico.Domain.VO.Patient
{
    public class AddPatientVO : EntityVOBaseAdd
    {
        #region Relationship
        [Required]
        public long MedicalId { get; set; }
        [Required]
        public long GenderId { get; set; }
        #endregion Relationship

        #region Columns
        [MaxLength(255)]
        [Required]
        public string Name { get; set; } = string.Empty;

        [MaxLength(100)]
        [Required]
        public string Email { get; set; } = string.Empty;

        public DateTime DateOfBirth { get; set; }

        [MaxLength(255)]
        public string Profession { get; set; } = string.Empty;

        [MaxLength(15)]
        public string Cpf { get; set; } = string.Empty;

        [Required]
        [MaxLength(15)]
        public string Rg { get; set; } = string.Empty;

        [MaxLength(255)]
        public string Education { get; set; } = string.Empty;

        [MaxLength(20)]
        public string PhoneNumber { get; set; } = string.Empty;

        [MaxLength(255)]
        public string AddressStreet { get; set; } = string.Empty;

        [MaxLength(255)]
        public string AddressNeighborhood { get; set; } = string.Empty;

        [MaxLength(255)]
        public string AddressCity { get; set; } = string.Empty;

        [MaxLength(255)]
        public string AddressState { get; set; } = string.Empty;

        [MaxLength(20)]
        public string AddressCep { get; set; } = string.Empty;

        [MaxLength(255)]
        public string EmergencyContactName { get; set; } = string.Empty;

        [MaxLength(20)]
        public string EmergencyContactPhoneNumber { get; set; } = string.Empty;

        public EMaritalStatus MaritalStatus { get; set; }


        #endregion
    }
}