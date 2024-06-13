using System.ComponentModel.DataAnnotations;

namespace Core.Dtos
{
    public class RegisterDto
    {
        [StringLength(maximumLength: 50, ErrorMessage = "The property should not have more than {1} characters")]
        public string Fullname { get; set; }

        [Required(ErrorMessage = "Email is Required")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required(ErrorMessage = "Phone Number is Required")]
        public string PhoneNumber { get; set; }


        [Required(ErrorMessage = "Gender is Required")]
        public string Gender { get; set; }



        [Required]
        [StringLength(255, ErrorMessage = "Must be between 5 and 255 characters", MinimumLength = 5)]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required]
        [StringLength(255, ErrorMessage = "Must be between 5 and 255 characters", MinimumLength = 5)]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Confirm password doesn't match, Type again !")]
        public string ConfirmPassword { get; set; }
    }
}
