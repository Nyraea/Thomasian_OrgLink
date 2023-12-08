using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace ThomasianOrglist.Data
{
    public enum Program
    {
        AMVCOA,
        FAL,
        FOE,
        FOMS,
        FOP,
        COA,
        CCBA,
        COE,
        CFAD,
        CICS,
        CON,
        CTHM,
    }

    public class Student : IdentityUser
    {
        [Required(ErrorMessage = "Please input your first name")]
        public string fname { get; set; }



        [Required(ErrorMessage = "Please input your last name")]
        public string lname { get; set; }



        [Required(ErrorMessage = "Please choose your program")]
        public string program { get; set; }



        [Required(ErrorMessage = "Please input a year level")]
        public string year_level { get; set; }


        public string? photo_path { get; set; }
        public string? photo_filename { get; set; }


        //Upload files via database
        /*
public string? photo_data { get; set;}
         */

    }
}
