using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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
        [Required]
        public int user_id { get; set; }


        [Required(ErrorMessage = "Please input a username")]
        public string? username { get; set; }


        [Required(ErrorMessage = "Please input a valid email address")]
        [DataType(DataType.EmailAddress)]
        public string? email { get; set;}


        [Required(ErrorMessage = "Please input a valid password")]
        [DataType(DataType.Password)]
        [RegularExpression("/^(?:(?=.*\\d)(?=.*[a-z])(?=.*[A-Z]).*)$/", ErrorMessage = "Password must contain at least 1 digit, 1 lowercase character, and 1 uppercase character")]
        public string? password { get; set;}


        [Required(ErrorMessage = "Please input your first name")]
        public string? fname { get; set;}


        [Required(ErrorMessage = "Please input your last name")]
        public string? lname { get; set;}


        [Required(ErrorMessage = "Please input a valid phone number")]
        [RegularExpression("[+63][0-9]{3}-[0-9]{3}-[0-9]{4}", ErrorMessage = "You must follow the format +63000-000-0000")]
        public string? pnumber { get; set;}


        [Required(ErrorMessage = "Please choose your program")]
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
