using SmartDigitalPsico.Domain.DTO.Gender.GET;
using SmartDigitalPsico.Domain.DTO.Office.GET;
using SmartDigitalPsico.Domain.DTO.RoleGroup.GET;
using SmartDigitalPsico.Domain.DTO.Leaves.GET;
using SmartDigitalPsico.Domain.DTO.Specialty.GET;
using SmartDigitalPsico.Domain.DTO.Notification.GET;
using SmartDigitalPsico.Domain.DTO.Application.GET;
using SmartDigitalPsico.Domain.DTO.Audit.GET;
using SmartDigitalPsico.Domain.DTO.Medical.ADD;
using SmartDigitalPsico.Domain.DTO.Medical.GET;
using SmartDigitalPsico.Domain.DTO.Medical.UPDATE;
using SmartDigitalPsico.Domain.DTO.Medical.Common;
using SmartDigitalPsico.Domain.Enuns;
using SmartDigitalPsico.Core.SDK.Domain.Hypermedia.Abstract;


namespace SmartDigitalPsico.Domain.DTO.Patient.GET
{
    /// <summary>
    /// Classe responsável por GetPatientDto.
    /// Responsabilidade: DTO de transferência de dados entre camadas da API.
    /// Relação: usado por Controllers, Services e Validators.
    /// </summary>
    public class GetPatientDto : SmartDigitalPsico.Core.SDK.Domain.DTO.Contracts.EntityDtoBase, ISupportsHyperMedia
    { 
        #region Relationship     
        public GetMedicalDto Medical { get; set; } = new GetMedicalDto();
        public GetGenderDto Gender { get; set; } = new GetGenderDto();
        #endregion Relationship

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
        public EMaritalStatus MaritalStatus { get; set; }
        public string EmergencyContactPhoneNumber { get; set; } = string.Empty;
        #endregion

        public List<SmartDigitalPsico.Core.SDK.Domain.Hypermedia.HyperMediaLink> Links { get; set; } = new List<SmartDigitalPsico.Core.SDK.Domain.Hypermedia.HyperMediaLink>();
    }
}
