namespace SmartDigitalPsico.Domain.Interfaces.Security
{
    public interface ITokenConfigurationVO
    {
        string Audience { get; set; }
        string Issuer { get; set; }
        string Secret { get; set; }
        int Minutes { get; set; }
        int DaysToExpiry { get; set; }
    }
}
