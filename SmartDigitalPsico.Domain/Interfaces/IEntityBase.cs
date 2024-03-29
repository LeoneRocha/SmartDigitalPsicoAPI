namespace SmartDigitalPsico.Domain.Interfaces
{ 
    public interface IEntityBase 
    {
        long Id { get; set; }
        bool Enable { get; set; } 
    } 
}