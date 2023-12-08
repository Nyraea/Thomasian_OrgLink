using Microsoft.AspNetCore.Mvc;
using Microsoft.Identity.Client;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace ThomasianOrglist.Models
{
    public enum DepartmentName
    {
        FacultyOfArtsAndLetters = 1,
        CollegeOfCommerceAndBusinessAdministration = 2,
        CollegeOfEducation = 3,
        AMVCollegeOfAccountancy = 4,
        CollegeOfTourismAndHospitalityManagement = 5,
        CollegeOfArchitecture = 6,
        CollegeOfInformationAndComputingScience = 7,
        CollegeOfFineArtsAndDesign = 8,
        FacultyOfEngineering = 9,
        CollegeOfNursing = 10,
        FacultyOfPharmacy = 11,
        FacultyOfMedicineAndSurgery = 12,
        UniversityWideOrganizations = 13
    }
    public class Organization
    {

        //public string UrlLink { get; set; }

        [Key]
        [Required]
        public int org_id { get; set; }

        [Required(ErrorMessage = "Please input your Facebook Page Link")]
        public string UrlLink { get; set; }



        [Required(ErrorMessage = "Please input Organization Name")]
        public string OrgName { get; set; }
        
        
        [Required(ErrorMessage = "Please input a valid email address")]
        [RegularExpression("\\S.*[@][u][s][t][.][e][d][u][.][p][h]", ErrorMessage = "You must follow the format sample@ust.edu.ph")]
        [DataType(DataType.EmailAddress)]
        public string emailAdd { get; set; }


        [Required(ErrorMessage = "Please choose what department")]
        [ForeignKey("DepartmentId")]
        public DepartmentName DepartmentId { get; set; }

        // Navigation property for the one-to-many relationsh
       

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
