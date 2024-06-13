using System.ComponentModel.DataAnnotations;

namespace Core.Dtos
{
    public class CreateDto 
    {
        [Required]
        [EmailAddress]
        public string? Email { get; set; }
    }
}
