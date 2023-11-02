using Microsoft.Identity.Client;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace ThomasianOrglist.Models

{
    public enum Program 
    {
      [Display(Name = "AMV College of Accountancy")]AMVCOA, 
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

    public class Student
    {
        [Key]
        public int user_id { get; set; }
        public string username { get; set; }
        public string email { get; set;}
        public string password { get; set;}
        public string fname { get; set;}
        public string lname { get; set;}
        public string pnumber { get; set;}
        public Program program {  get; set;}


        // Upload files via wwwroot
        /*
        public string? photo_path {  get; set;}
        public string? photo_filename {  get; set;}
        */

        //Upload files via database
        public string? photo_data { get; set;}

        [NotMapped]
        public IFormFile? profile_img {  get; set;}

    }
}
