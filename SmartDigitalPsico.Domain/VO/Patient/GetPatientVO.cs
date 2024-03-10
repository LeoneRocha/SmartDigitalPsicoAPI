using SmartDigitalPsico.Domain.Enuns;
using SmartDigitalPsico.Domain.Hypermedia;
using SmartDigitalPsico.Domain.Hypermedia.Abstract;
using SmartDigitalPsico.Domain.ModelEntity.Domains;
using SmartDigitalPsico.Domain.VO.Contracts;
using SmartDigitalPsico.Domain.VO.Medical;
using System.ComponentModel.DataAnnotations;

namespace SmartDigitalPsico.Domain.VO.Patient
{
    public class GetPatientVO : EntityVOBase, ISupportsHyperMedia
    {
        //MUDAR AS RELACOES PARA OBJETOS 
        #region Relationship
        [Required]
        public GetMedicalVO Medical { get; set; }

        public Gender Gender { get; set; }
        #endregion Relationship

        #region Columns

        public string Name { get; set; } = string.Empty;

        public string Email { get; set; } = string.Empty;

        public DateTime DateOfBirth { get; set; }


        public string? Profession { get; set; }


        public string? Cpf { get; set; }


        public string Rg { get; set; }


        public string? Education { get; set; }


        public string? PhoneNumber { get; set; }


        public string? AddressStreet { get; set; }


        public string? AddressNeighborhood { get; set; }


        public string? AddressCity { get; set; }


        public string? AddressState { get; set; }


        public string? AddressCep { get; set; }


        public string? EmergencyContactName { get; set; }

        public EMaritalStatus MaritalStatus { get; set; }

        public string? EmergencyContactPhoneNumber { get; set; }

        #endregion

        public List<HyperMediaLink> Links { get; set; } = new List<HyperMediaLink>();
    }
}