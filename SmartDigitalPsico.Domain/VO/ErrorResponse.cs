using Swashbuckle.AspNetCore.Annotations;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using System.Xml.Serialization;

namespace SmartDigitalPsico.Domain.VO
{ 

    public class ErrorResponse
    {
        public string Name { get; set; } = string.Empty;

        public string Message { get; set; } = string.Empty;
        public string ErrorCode { get; set; } = string.Empty;

        [XmlIgnore]
        [JsonIgnore]
        [SwaggerIgnore]
        [IgnoreDataMember]
        public string DefaultMessage { get; set; } = string.Empty;

        [XmlIgnore]
        [JsonIgnore]
        [SwaggerIgnore]
        [IgnoreDataMember]     
        public string FullMessage { get; set; } = string.Empty;
    } 

}
