namespace SmartDigitalPsico.Domain.DTO
{
    public class RefDto<T>
    {
        public T Value { get; set; }
        public RefDto(T value) => Value = value;
    } 
}
