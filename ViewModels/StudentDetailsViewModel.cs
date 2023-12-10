using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace ThomasianOrglist.ViewModels
{
    public class StudentDetailsViewModel
    {       
            public string username {  get; set; }
            public string email { get; set; }
            public string fname { get; set; }
            public string lname { get; set; }
            public string program { get; set; }
            public string year_level { get; set; }
            public string pnumber {  get; set; }
            public string? photo_path { get; set; }
            public string? photo_filename { get; set; }


            //Upload files via database
            /*
    public string? photo_data { get; set;}
             */

        }
    }
