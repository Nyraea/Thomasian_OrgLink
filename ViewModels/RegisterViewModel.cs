using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ThomasianOrglist.ViewModels
{
    public enum Program
    {
        [Display(Name = "AMV College of Accountancy")] AMVCOA,
        [Display(Name = "Faculty of Arts & Letters")] FAL,
        [Display(Name = "Faculty of Engineering")] FOE,
        [Display(Name = "Faculty of Medicine & Surgery")] FOMS,
        [Display(Name = "Faculty of Pharmacy")] FOP,
        [Display(Name = "College of Architecture")] COA,
        [Display(Name = "College of Commerce & Business Administration")] CCBA,
        [Display(Name = "College of Education")] COE,
        [Display(Name = "College of Fine Arts & Design")] CFAD,
        [Display(Name = "College of Computing Sciences")] CICS,
        [Display(Name = "College of Nursing")] CON,
        [Display(Name = "College of Tourism & Hospitality Management")] CTHM,
    }

    public class RegisterViewModel
    {
        [Key]
        [Required]
        public int user_id { get; set; }



        [Required(ErrorMessage = "Please input your first name")]
        public string fname { get; set; }



        [Required(ErrorMessage = "Please input your last name")]
        public string lname { get; set; }



        [Required(ErrorMessage = "Please input a valid phone number")]
        [RegularExpression("[+][6][3][9][0-9]{2}[0-9]{3}[0-9]{4}", ErrorMessage = "You must follow the format +639000000000")]
        public string pnumber { get; set; }



        [Required(ErrorMessage = "Please choose your program")]
        public string program { get; set; }


        [Required(ErrorMessage = "Please input a year level")]
        public string year_level { get; set; }



        [Required(ErrorMessage = "Please input a valid email address")]
        [RegularExpression("\\S.*[@][u][s][t][.][e][d][u][.][p][h]", ErrorMessage = "You must follow the format sample@ust.edu.ph")]
        [DataType(DataType.EmailAddress)]
        public string email { get; set; }



        [Required(ErrorMessage = "Please input a username")]
        [RegularExpression(".{6}.*", ErrorMessage = "Username must be at least 6 characters long")]
        public string username { get; set; }



        [Required(ErrorMessage = "Please input a valid password")]
        [DataType(DataType.Password)]
        [RegularExpression("^(?=.*[a-z])(?=.*[A-Z])(?=.*[0-9])(?=.*[^a-zA-Z0-9])(?=.{8,}).*$", ErrorMessage = "Password must be at least 8 characters long and contain 1 uppercase letter, 1 lowercase letter, 1 digit, and 1 special character")]
        public string password { get; set; }



        // Upload files via wwwroot

        [NotMapped]
        [Required(ErrorMessage = "Please upload a valid profile picture")]
        public IFormFile? profile_img { get; set; }

        public string? photo_path { get; set; }
        public string? photo_filename { get; set; }


        //Upload files via database
        /*
        public string? photo_data { get; set;}
         */

    }
}
