using System.Text.Json.Serialization;
using AutoMapper.Configuration.Annotations;
using SmartDigitalPsico.Core.SDK.Domain.Hypermedia.Abstract;
using SmartDigitalPsico.Domain.DTO.Medical.GET;
using SmartDigitalPsico.Domain.DTO.Medical.MedicalCalendar.Common;
using SmartDigitalPsico.Domain.DTO.Patient.GET;

namespace SmartDigitalPsico.Domain.DTO.Medical.MedicalCalendar.GET
{
    /// <summary>
    /// Classe responsável por GetMedicalCalendarTimeSlotDto.
    /// Responsabilidade: DTO de transferência de dados entre camadas da API.
    /// Relação: usado por Controllers, Services e Validators.
    /// </summary>
    public class GetMedicalCalendarTimeSlotDto : GetMedicalCalendarDtoBase, ISupportsHyperMedia
    {
        #region Relationship
        public long? PatientId { get; set; }

        public string PatientName { get { return Patient?.Name ?? string.Empty; } }

        [JsonIgnore]
        public GetMedicalDto Medical { get; set; } = new GetMedicalDto();

        [JsonIgnore]
        public GetPatientDto? Patient { get; set; } = new GetPatientDto();

        #endregion Relationship

        [JsonIgnore]
        [Ignore]
        public List<SmartDigitalPsico.Core.SDK.Domain.Hypermedia.HyperMediaLink> Links { get; set; } = new List<SmartDigitalPsico.Core.SDK.Domain.Hypermedia.HyperMediaLink>();
    }
}
