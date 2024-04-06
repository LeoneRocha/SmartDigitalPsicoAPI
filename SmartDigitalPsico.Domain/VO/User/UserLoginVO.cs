using System.ComponentModel.DataAnnotations;

namespace SmartDigitalPsico.Domain.VO.User
{
    public class UserLoginVO

    {
        [MaxLength(25)]
        [Required]
        public string Login { get; set; } = string.Empty;
        [MaxLength(20)]
        [Required]
        public string Password { get; set; } = string.Empty;
    }
}