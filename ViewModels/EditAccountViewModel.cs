using Microsoft.AspNetCore.Identity;
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

    public class EditAccountViewModel
    {
        public string? username { get; set; }



        [RegularExpression("\\S.*[@][u][s][t][.][e][d][u][.][p][h]", ErrorMessage = "You must follow the format sample@ust.edu.ph")]
        [DataType(DataType.EmailAddress)]
        public string? email { get; set; }



        public string? fname { get; set; }



        public string? lname { get; set; }



        public string? program { get; set; }


        [RegularExpression("^[1-4]$", ErrorMessage = "Year level must be a value ranging from 1 to 4.")]
        public string? year_level { get; set; }

        [Required(ErrorMessage ="Please enter your current password!")]
        [DataType(DataType.Password)]
        public string? oldPassword {  get; set; }


        [DataType(DataType.Password)]
        [RegularExpression("^(?=.*[a-z])(?=.*[A-Z])(?=.*[0-9])(?=.*[^a-zA-Z0-9])(?=.{8,}).*$", ErrorMessage = "Password must be at least 8 characters long and contain 1 uppercase letter, 1 lowercase letter, 1 digit, and 1 special character")]
        public string? newPassword { get; set; }



        [RegularExpression("[+][6][3][9][0-9]{2}[0-9]{3}[0-9]{4}", ErrorMessage = "You must follow the format +639000000000")]
        public string? pnumber { get; set; }



        public string? photo_path { get; set; }
        public string? photo_filename { get; set; }
        public IFormFile? profile_img { get; set; }

        //Upload files via database
        /*
public string? photo_data { get; set;}
         */
    }
}
