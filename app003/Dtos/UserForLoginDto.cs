using System.ComponentModel.DataAnnotations;

namespace app003.Dtos
{
    public class UserForLoginDto
    {
        [Required]
        public string Username { get; set; }
        
        [Required]
        [StringLength(8, MinimumLength = 4, ErrorMessage = "Your must specify password between 4 and 8 characters.")]
        public string Password { get; set; }
    }
}