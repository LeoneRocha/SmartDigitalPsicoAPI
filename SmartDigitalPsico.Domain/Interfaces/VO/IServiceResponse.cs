namespace SmartDigitalPsico.Domain.Interfaces.VO
{
    public interface IServiceResponse<T>
    {
        T? Data { get; set; }
        bool Success { get; set; }
        string Message { get; set; }
    }
}
