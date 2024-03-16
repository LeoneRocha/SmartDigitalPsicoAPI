namespace SmartDigitalPsico.Domain.Interfaces
{
    public interface IEntityBaseLog
    {

        DateTime CreatedDate { get; set; }

        DateTime ModifyDate { get; set; }

        DateTime LastAccessDate { get; set; }

    }
}