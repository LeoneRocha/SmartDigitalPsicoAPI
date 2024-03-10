using System.Security.Claims;

namespace SmartDigitalPsico.Domain.Security
{
    public class SecurityVO
    {
        public string Name { get;   set; }
        public string Role { get;   set; }
        public string Id { get; internal set; }

        public string? SecurityKeyConfig { get; set; }
    }
}