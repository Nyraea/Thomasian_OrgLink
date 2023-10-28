using Microsoft.Identity.Client;
using System.ComponentModel.DataAnnotations;
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
        public string profile_img {  get; set;}

    }
}
