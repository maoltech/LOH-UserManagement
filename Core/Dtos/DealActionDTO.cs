using System.ComponentModel.DataAnnotations;

namespace Core.Dtos
{
    public class DealActionDTO
    {
        [Required]
        public string DealId { get; set; }
    }
}
