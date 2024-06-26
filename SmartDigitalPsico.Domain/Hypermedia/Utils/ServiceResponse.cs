﻿namespace SmartDigitalPsico.Domain.Hypermedia.Utils
{
    public class ServiceResponse<T> : IServiceResponse<T> 
    {
        public ServiceResponse()
        { 
            Errors = new List<ErrorResponse>();
        }
        public T? Data { get; set; }
        public bool Success { get; set; } = true;
        public string Message { get; set; } = string.Empty;
        public List<ErrorResponse> Errors { get; set; }
        public bool Unauthorized { get; set; }
    }

    public class ErrorResponse
    {
        public string Name { get; set; } = string.Empty;

        public string Message { get; set; } = string.Empty;
        public string ErrorCode { get; set; } = string.Empty;
    }

    public interface IServiceResponse<T>
    {
        T? Data { get; set; }
        bool Success { get; set; }
        string Message { get; set; }
    }

}
