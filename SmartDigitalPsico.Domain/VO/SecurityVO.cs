namespace SmartDigitalPsico.Domain.Security
{
    public class SecurityVO
    {
        public string Name { get;   set; } = string.Empty;
        public string Role { get;   set; } = string.Empty;
        public string Id { get; internal set; } = string.Empty;

        public string SecurityKeyConfig { get; set; } = string.Empty;
    }
}