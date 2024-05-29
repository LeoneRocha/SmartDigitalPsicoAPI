using SmartDigitalPsico.Domain.Enuns;
using SmartDigitalPsico.Domain.Hypermedia;
using SmartDigitalPsico.Domain.Hypermedia.Abstract;
using SmartDigitalPsico.Domain.VO.Contracts;
using SmartDigitalPsico.Domain.VO.Domains.GetVOs;
using SmartDigitalPsico.Domain.VO.Medical;
using System.ComponentModel.DataAnnotations;

namespace SmartDigitalPsico.Domain.VO.Patient
{
    public class GetPatientVO : EntityVOBase, ISupportsHyperMedia
    { 
        #region Relationship
        [Required]
        public GetMedicalVO Medical { get; set; } = new GetMedicalVO();

        public GetGenderVO Gender { get; set; } = new GetGenderVO();

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

        public List<HyperMediaLink> Links { get; set; } = new List<HyperMediaLink>();
    }
}