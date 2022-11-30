using System.ComponentModel.DataAnnotations;

namespace DAL.ViewModels
{
    public class RegisterViewModel
    {
        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; }       

        [Required]
        [DataType(DataType.Password)]
        [StringLength(50, ErrorMessage = "Password should be minimum 6 and maximum 50 symbols.", MinimumLength = 6)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [Required]
        [Compare("Password", ErrorMessage = "Passwords don't match")]
        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        public string PasswordConfirm { get; set; }
    }
}
