using System.ComponentModel.DataAnnotations;

namespace YourPlatform.Models
{
    public class Login
    {
        [Required]
        [StringLength(20, MinimumLength = 3, ErrorMessage = "Username should be between 5 and 20 characters long")]
        public string? Username { get; set; }


        [Required]
        [StringLength(20, MinimumLength = 3, ErrorMessage = "Password should be between 5 and 20 characters long")]

        public string? Password { get; set; }
    }
}
