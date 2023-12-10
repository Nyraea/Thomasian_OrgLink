using Microsoft.AspNetCore.Mvc;
using System;
using ThomasianOrglist.Models;
using ThomasianOrglist.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using ThomasianOrglist.ViewModels;

namespace ThomasianOrglist.Controllers
{
    public class StudentController : Controller
    {
      

        private readonly ILogger<StudentController> _logger;
        private readonly AppDbContext _dbContext;
        private readonly IWebHostEnvironment _webHostEnvironment;
        private readonly SignInManager<Student> _signInManager;
        private readonly UserManager<Student> _userManager;

        // Binding database and other components to variables
        public StudentController(ILogger<StudentController> logger, IWebHostEnvironment hostEnvironment , AppDbContext dbContext, SignInManager<Student> signInManager, UserManager<Student> userManager)
        {
            _dbContext = dbContext;
            _logger = logger;
            _webHostEnvironment = hostEnvironment;
            _signInManager = signInManager;
            _userManager = userManager;
        }
        public IActionResult Index()
        {

            return View(_dbContext.Students);
        }

        [HttpGet]

        public IActionResult AddStudent()
        {
            return View();
        }


        // REGISTER STUDENTS VIA IDENTITY 
        [HttpPost]
        public async Task<IActionResult> StudentAdd(RegisterViewModel userData)
        {
            /*
            Student? emailExists = _dbContext.Students.FirstOrDefault(st => st.email == newStudent.email);
            Student? usernameExists = _dbContext.Students.FirstOrDefault(st => st.username == newStudent.username);

            if (newStudent.profile_img != null && ModelState.IsValid && emailExists == null && usernameExists == null)
            {
                string fileName = null;
                byte[] bytes = null;

                // Upload files via wwwroot 

                string UploadsFolder = Path.Combine(_webHostEnvironment.WebRootPath, "uploads");
                fileName = Guid.NewGuid().ToString() + "_" + newStudent.profile_img.FileName;
                string filePath = Path.Combine(UploadsFolder, fileName);

                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    newStudent.profile_img.CopyTo(fileStream);
                }
                newStudent.photo_path = "~/uploads/";
                newStudent.photo_filename = fileName;

                _dbContext.Students.Add(newStudent);
                _dbContext.SaveChanges();
            */
            if (ModelState.IsValid && userData.profile_img != null)
            {
                Student newUser = new Student();
                newUser.fname = userData.fname;
                newUser.lname = userData.lname;
                newUser.PhoneNumber = userData.pnumber;
                newUser.program = userData.program;
                newUser.year_level = userData.year_level;
                newUser.Email = userData.email;
                newUser.UserName = userData.username;
                newUser.PasswordHash = userData.password;
                newUser.LockoutEnabled = false;

                string fileName = null;
                byte[] bytes = null;

                // Upload files via wwwroot 

                string UploadsFolder = Path.Combine(_webHostEnvironment.WebRootPath, "uploads");
                fileName = Guid.NewGuid().ToString() + "_" + userData.profile_img.FileName;
                string filePath = Path.Combine(UploadsFolder, fileName);

                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    userData.profile_img.CopyTo(fileStream);
                }

                newUser.photo_path = "/uploads/";
                newUser.photo_filename = fileName;

                var result = await _userManager.CreateAsync(newUser, userData.password);

                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    foreach (var error in result.Errors)
                    {
                        ModelState.AddModelError("", error.Description);
                    }
                }
                return View(userData);
            }
            else
            {
                return View("AddStudent");
            }
        }


        /*[HttpPost]

        public IActionResult StudentAdd(Student newStudent)
        {
            Student? emailExists = _dbContext.Students.FirstOrDefault(st => st.email == newStudent.email);
            Student? usernameExists = _dbContext.Students.FirstOrDefault(st => st.username == newStudent.username);

            if (newStudent.profile_img != null && ModelState.IsValid && emailExists == null && usernameExists == null)
            {
                string fileName = null;
                byte[] bytes = null;
                // Upload files via wwwroot 

                string UploadsFolder = Path.Combine(_webHostEnvironment.WebRootPath, "uploads");
                fileName = Guid.NewGuid().ToString() + "_" + newStudent.profile_img.FileName;
                string filePath = Path.Combine(UploadsFolder, fileName);

                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    newStudent.profile_img.CopyTo(fileStream);
                }
                newStudent.photo_path = "~/uploads/";
                newStudent.photo_filename = fileName;

                _dbContext.Students.Add(newStudent);
                _dbContext.SaveChanges();
                return RedirectToAction("LoginStudent");
            }
            
            else if (emailExists != null)
            {
                ModelState.AddModelError("Student.email", "Email already exists.");
                return View("AddStudent");
            }
            else if (usernameExists != null)
            {
                ModelState.AddModelError("Student.username", "Username already exists.");
                return View("AddStudent");
            }
            else
            {
                return View("AddStudent");
            }
        }
            */

        [HttpGet]
        public IActionResult LoginStudent()
        {
            return View();
        }


        // LOG IN STUDENT VIA IDENTITY
        [HttpPost]
        public async Task<IActionResult> StudentLogin(LoginViewModel loginInfo)
        {
             if (ModelState.IsValid)
            {
                var result = await _signInManager.PasswordSignInAsync(loginInfo.userName,
                loginInfo.password, loginInfo.rememberMe, false);

                if (result.Succeeded)
                {
                    var currentUser = await _userManager.FindByNameAsync(loginInfo.userName);
                    if (currentUser != null)
                    {
                        return RedirectToAction("Index", "Home");
                    }
                    else
                    {
                        ModelState.AddModelError("", "User not found!");
                        return View("LoginStudent");
                    }

                }
                else

                {
                    ModelState.AddModelError("", "Account email or phone number has not been confirmed!");
                    return View("LoginStudent");
                }
            }
            else
            {
                return View("LoginStudent");
            }
         

        }
        
        
        // LOG OUT STUDENT VIA IDENTITY
        public async Task<IActionResult> LogoutStudent()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }


        [HttpGet]
        public IActionResult StudentDetails()
        {
            var currentUser = _userManager.FindByNameAsync(User.Identity.Name).Result;
            var profileViewModel = new StudentDetailsViewModel
            {
                fname = currentUser.fname,
                lname = currentUser.lname,
                program = currentUser.program,
                year_level = currentUser.year_level,
                photo_path = currentUser.photo_path,
                photo_filename = currentUser.photo_filename,
                username = currentUser.UserName,
                email = currentUser.Email,
                pnumber = currentUser.PhoneNumber
            };
            return View(profileViewModel);
        }

        [HttpGet]
        public IActionResult EditAccount()
        {
            return View();
        }


        [HttpPost]
        public async Task<IActionResult> AccountEdit(EditAccountViewModel userData)
        {
            if (ModelState.IsValid)
            {
                var currentUser = _userManager.FindByNameAsync(User.Identity.Name).Result;
                var passwordValid = await _userManager.CheckPasswordAsync(currentUser, userData.oldPassword);
                if (passwordValid == true)
                {
                    currentUser.fname = userData.fname != null ? userData.fname : currentUser.fname;
                    currentUser.lname = userData.lname != null ? userData.lname : currentUser.lname;
                    currentUser.PhoneNumber = userData.pnumber != null ? userData.pnumber : currentUser.PhoneNumber;
                    currentUser.PasswordHash = userData.newPassword != null ? userData.newPassword : currentUser.PasswordHash;
                    currentUser.program = userData.program != null ? userData.program : currentUser.program;
                    currentUser.year_level = userData.year_level != null ? userData.year_level : currentUser.year_level;
                    currentUser.UserName = userData.username != null ? userData.username : currentUser.UserName;
                    currentUser.Email = userData.email != null ? userData.email : currentUser.Email;


                    if (userData.profile_img != null)
                    {
                        string fileName = null;
                        byte[] bytes = null;

                        // Upload files via wwwroot 

                        string UploadsFolder = Path.Combine(_webHostEnvironment.WebRootPath, "uploads");
                        fileName = Guid.NewGuid().ToString() + "_" + userData.profile_img.FileName;
                        string filePath = Path.Combine(UploadsFolder, fileName);

                        using (var fileStream = new FileStream(filePath, FileMode.Create))
                        {
                            userData.profile_img.CopyTo(fileStream);
                        }

                        currentUser.photo_path = userData.photo_path;
                        currentUser.photo_filename = userData.photo_filename;
                    }
                    else
                    {
                        currentUser.photo_path = currentUser.photo_path;
                        currentUser.photo_filename = currentUser.photo_filename;
                    }

                    var result = await _userManager.UpdateAsync(currentUser);
                    var updatedUser = await _userManager.FindByIdAsync(currentUser.Id);
                    await _signInManager.SignOutAsync();
                    await _signInManager.SignInAsync(updatedUser, isPersistent: false);
                    if (result.Succeeded)
                    {
                        return RedirectToAction("StudentDetails", "Student");
                    }
                    else
                    {
                        foreach (var error in result.Errors)
                        {
                            ModelState.AddModelError("", error.Description);
                        }
                        return View("EditAccount");
                    }
                }
                else
                {
                    return View("EditAccount");
                }
            }
            else
            {
                return View("EditAccount");
            }
            

        }




        [HttpGet]
        public IActionResult Aform()
        {

            return View();

        }



        [HttpGet]
        public IActionResult AddNewInfo()
        {
            return View();
        }

    }

   
}
