using Microsoft.AspNetCore.Mvc;
using ThomasianOrglist.Models;
using ThomasianOrglist.Data;
using Microsoft.EntityFrameworkCore;

namespace ThomasianOrglist.Controllers
{
    public class StudentController : Controller
    {
        private readonly AppDbContext _dbContext;
        const string Session_UserID = "_UserId";
        const string Session_Username = "_UserName";

        // Binding database and other components to variables
        public StudentController(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]

        public IActionResult AddStudent()
        {
            return View();
        }
        

        [HttpPost]

        public IActionResult StudentAdd(Student newStudent)
        {
            byte[]? bytes = null;

            if(newStudent.profile_img != null)
            {
                // Upload files via wwwroot 

                /* string UploadsFolder = Path.Combine(_webHostEnvironment.WebRootPath, "uploads");
                fileName = Guid.NewGuid().ToString() + "_" + newStudent.profile_img.FileName;
                string filePath = Path.Combine(UploadsFolder, fileName);

                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    newStudent.profile_img.CopyTo(fileStream);
                }
                newStudent.photo_path = "~/wwwroot/uploads";
                newStudent.photo_filename = fileName; */

                // Upload files via database

                using (Stream fileStream = newStudent.profile_img.OpenReadStream())
                {
                    using (BinaryReader br = new BinaryReader(fileStream))
                    {
                        bytes = br.ReadBytes((Int32)fileStream.Length);
                    }
                }

                // Converts bytes to base 64 string
                newStudent.photo_data = Convert.ToBase64String(bytes,0,bytes.Length);
            }
            _dbContext.Students.Add(newStudent);
            _dbContext.SaveChanges();
            return RedirectToAction("LoginStudent");
        }

        [HttpGet]
        public IActionResult LoginStudent()
        {
            return View();
        }

        [HttpPost]
        public IActionResult StudentSession()
        {
            //Storing Data into Session using SetString and SetInt32 method
            HttpContext.Session.SetString(Session_Username, "magraviador123");
            HttpContext.Session.SetInt32(Session_UserID, 1);
            return RedirectToAction("StudentDetails");
        }
        
        public string About()
        {
            //Accessing the Session Data inside a Method
            string? UserName = HttpContext.Session.GetString(Session_Username);
            int? UserId = HttpContext.Session.GetInt32(Session_UserID);
            string Message = $"UserName: {UserName}, UserId: {UserId}";
            return Message;
        }

        [HttpGet]
        public IActionResult StudentDetails()
        {
            return View();
        }
       

    }

   
}
