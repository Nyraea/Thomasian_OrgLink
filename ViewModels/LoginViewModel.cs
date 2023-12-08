using System.ComponentModel.DataAnnotations;

namespace ThomasianOrglist.ViewModels
{
    public class LoginViewModel
    {
        
        [Required(ErrorMessage = "Please input a valid username")]
        public string? userName { get; set; }

        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Please input a valid password")]
        public string? password { get; set; }

        [Display(Name = "Remember Me?")]
        public bool rememberMe { get; set; }

    }
}
