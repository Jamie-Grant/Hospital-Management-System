using System.ComponentModel.DataAnnotations;

namespace HospitalManagementSystem.Models
{
    public class RegisterViewModel
    {
        [Required(ErrorMessage = "Email is required.")]
        [EmailAddress]
        public string Email { get; set; }

        [Required(ErrorMessage = "Password is required.")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required(ErrorMessage = "Confirm password is required.")]
        [Compare("Password", ErrorMessage = "The password and confirmation password are not the same.")]
        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; }
    }
}
