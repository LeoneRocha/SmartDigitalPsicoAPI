using SmartDigitalPsico.Domain.Hypermedia;
using SmartDigitalPsico.Core.SDK.Domain.Hypermedia;
using SmartDigitalPsico.Core.SDK.Domain.Hypermedia.Abstract;
using SmartDigitalPsico.Domain.DTO.Contracts;


namespace SmartDigitalPsico.Domain.DTO.Patient.PatientNotificationMessage
{
    /// <summary>
    /// Classe responsável por GetPatientNotificationMessageVO.
    /// Responsabilidade: DTO de transferência de dados entre camadas da API.
    /// Relação: usado por Controllers, Services e Validators.
    /// </summary>
    public class GetPatientNotificationMessageVO : SmartDigitalPsico.Core.SDK.Domain.DTO.Contracts.EntityDtoBase, ISupportsHyperMedia
    {          
        #region Relationship  
        public GetPatientDto Patient { get; set; } = new GetPatientDto();
        public List<SmartDigitalPsico.Core.SDK.Domain.Hypermedia.HyperMediaLink> Links { get; set; } = new List<SmartDigitalPsico.Core.SDK.Domain.Hypermedia.HyperMediaLink>();
        #endregion Relationship

        #region Columns 
        public string Message { get; set; } = string.Empty;
        public bool IsReaded { get; set; }
        public DateTime ReadingDate { get; set; }
        public bool Notified { get; set; }
        public DateTime NotifiedDate { get; set; }
        #endregion Columns 
    }
}
