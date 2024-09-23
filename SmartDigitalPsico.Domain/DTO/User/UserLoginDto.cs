using System.ComponentModel.DataAnnotations;

namespace SmartDigitalPsico.Domain.DTO.User
{
    public class UserLoginDto

    {
        [MaxLength(25)]
        [Required]
        public string Login { get; set; } = string.Empty;
        [MaxLength(20)]
        [Required]
        public string Password { get; set; } = string.Empty;
    }
}