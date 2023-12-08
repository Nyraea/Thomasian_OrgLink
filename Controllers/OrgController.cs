using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using ThomasianOrglist.Data;
using ThomasianOrglist.Models;

namespace ThomasianOrglist.Controllers
{
    public class OrgController : Controller
    {
        private readonly ILogger<OrgController> _logger;
        private readonly AppDbContext _appDbContext;
        private readonly IWebHostEnvironment _webHostEnvironment;
        const string Session_UserID = "_OrgId";
        const string Session_Username = "_OrgName";

       

        public OrgController(ILogger<OrgController> logger, IWebHostEnvironment hostEnvironment, AppDbContext dbContext)
        {
            _logger = logger;
            _webHostEnvironment = hostEnvironment;
            _appDbContext = dbContext;
        }
       

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public IActionResult OrgAdd(Organization newOrganization)
        {
            Organization? emailExists = _appDbContext.Organizations.FirstOrDefault(st => st.emailAdd == newOrganization.emailAdd);
            Organization? usernameExists = _appDbContext.Organizations.FirstOrDefault(st => st.OrgName == newOrganization.OrgName);

            if (newOrganization.org_img != null && ModelState.IsValid && emailExists == null && usernameExists == null)
            {
                string fileName = null;
                byte[] bytes = null;
                // Upload files via wwwroot 

                string UploadsFolder = Path.Combine(_webHostEnvironment.WebRootPath, "uploads");
                fileName = Guid.NewGuid().ToString() + "_" + newOrganization.org_img.FileName;
                string filePath = Path.Combine(UploadsFolder, fileName);

                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    newOrganization.org_img.CopyTo(fileStream);
                }

                newOrganization.photo_path = "~/uploads/";
                newOrganization.photo_filename = fileName;

                // Set the DepartmentId for the new organization
                // Replace with the actual department ID

                _appDbContext.Organizations.Add(newOrganization);
                _appDbContext.SaveChanges();
                return RedirectToAction("ViewOrg", "Department");
            }

            else if (emailExists != null)
            {
                ModelState.AddModelError("Organization.emailAdd", "Email already exists.");
                return View("Register");
            }
            else if (usernameExists != null)
            {
                ModelState.AddModelError("Organization.OrgName", "Org name already exists.");
                return View("Register");
            }
            else
            {
                return View("Register");
            }
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }


    }
}
