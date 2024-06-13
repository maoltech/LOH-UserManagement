using System.ComponentModel.DataAnnotations;

namespace Core.Dtos
{
    public class CreateCategoryDto
    {
        public string Name { get; set; } = String.Empty;
        public string? Description { get; set; }
        public ICollection<CreateSubCategoryDto>? SubCategories { get; set; }

        [Required(ErrorMessage = "Filename is required.")]
        public string Filename { get; set; }

        [Required(ErrorMessage = "MimeType is required.")]
        [RegularExpression(@"^image/(jpeg|png)$|^application/pdf$", ErrorMessage = "Invalid MimeType. Supported types are image/jpeg and image/png and application/pdf.")]
        public string MimeType { get; set; }

        [Required(ErrorMessage = "Base64Content is required.")]
        public string Base64Content { get; set; }
    }

}
