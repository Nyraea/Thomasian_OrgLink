using Microsoft.AspNetCore.Mvc;
using Microsoft.Identity.Client;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace ThomasianOrglist.Models
{
    public enum Department
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
    public class Organization
    {

        [Key]
        [Required]
        public int org_id { get; set; }



        [Required(ErrorMessage = "Please input Organization Name")]
        public string OrgName { get; set; }
        
        
        [Required(ErrorMessage = "Please input a valid email address")]
        [RegularExpression("\\S.*[@][u][s][t][.][e][d][u][.][p][h]", ErrorMessage = "You must follow the format sample@ust.edu.ph")]
        [DataType(DataType.EmailAddress)]
        public string emailAdd { get; set; }

        [Required(ErrorMessage = "Please choose what department")]
        public Department dept { get; set; }

        [Required(ErrorMessage = "Please input a valid password")]
        [DataType(DataType.Password)]
        [RegularExpression("^(?=.*[a-z])(?=.*[A-Z])(?=.*[0-9])(?=.*[^a-zA-Z0-9])(?=.{8,}).*$", ErrorMessage = "Password must be at least 8 characters long and contain 1 uppercase letter, 1 lowercase letter, 1 digit, and 1 special character")]
        public string Password { get; set; }


        public string? Vision { get; set; }
        public string? Mission { get; set; }
        public string Details { get; set; }
        // Upload files via wwwroot

        [NotMapped]
        [Required(ErrorMessage = "Please upload your Organization Icon")]
        public IFormFile? org_img { get; set; }

        public string? photo_path { get; set; }
        public string? photo_filename { get; set; }
    }
}
