using System.ComponentModel.DataAnnotations;

namespace Core.Dtos
{
    public class ConfirmEmailDTO
    {
        [Required]
        [EmailAddress(ErrorMessage = "Invalid Email")]
        public string Email { get; set; }

        [Required]
        public string Token { get; set; }
    }
}
