using AutoMapper.Configuration.Annotations;
using Swashbuckle.AspNetCore.Annotations;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using System.Xml.Serialization;

namespace SmartDigitalPsico.Domain.VO
{ 

    /// <summary>
    /// Classe responsável por ErrorResponse.
    /// Responsabilidade: value object / objeto de valor de resposta.
    /// Relação: retornado pelos Services para Controllers.
    /// </summary>
        // Movido para SmartDigitalPsicoAPI.Core.SDK.
    [Obsolete("Movido para SmartDigitalPsicoAPI.Core.SDK. Use o tipo correspondente no pacote SmartDigitalPsicoAPI.Core.SDK.", error: false, DiagnosticId = "SDP_CORE_SDK_HELPER")]
    public class ErrorResponse
    {

        [Ignore]
        [XmlIgnore]
        [JsonIgnore]
        [SwaggerIgnore]
        [IgnoreDataMember]
        public string Name { get; set; } = string.Empty;

        public string Message { get; set; } = string.Empty;
        public string ErrorCode { get; set; } = string.Empty;

        [Ignore]
        [XmlIgnore]
        [JsonIgnore]
        [SwaggerIgnore]
        [IgnoreDataMember]
        public string DefaultMessage { get; set; } = string.Empty;

        [Ignore]
        [XmlIgnore]
        [JsonIgnore]
        [SwaggerIgnore]
        [IgnoreDataMember]     
        public string FullMessage { get; set; } = string.Empty;
    } 

}
