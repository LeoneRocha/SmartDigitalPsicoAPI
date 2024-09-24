using SmartDigitalPsico.Domain.Interfaces.VO;

namespace SmartDigitalPsico.Domain.VO
{
    public class ServiceResponse<T> : IServiceResponse<T>
    { 
        public T? Data { get; set; }
        public bool Success { get; set; } = true;
        public string Message { get; set; } = string.Empty;
        public List<ErrorResponse> Errors { get; set; } = new List<ErrorResponse>();
        public bool Unauthorized { get; set; }
    }  
}
