using System.ComponentModel.DataAnnotations;

namespace Core.Dtos
{
    public class ForgotPasswordDTO
    {
        [Required]
        [EmailAddress(ErrorMessage = "Email is not valid")]
        public string Email { get; set; }
    }
}
