using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ThomasianOrglist.Data;

namespace ThomasianOrglist.Controllers
{
    public class DepartmentController : Controller

    {
        private readonly AppDbContext _context;
        public DepartmentController(AppDbContext context)
        {
            _context = context;
        }
       
        public IActionResult Index()
        {
            var departments = _context.Departments.ToList();
            return View(departments);
        }
        
        [HttpGet]
        public IActionResult DepartmentDetails(int departmentId)
        {
            var department = _context.Departments.Include(d => d.Organizations).FirstOrDefault(d => d.Id == departmentId);

            if (department == null)
            {
                return NotFound();
            }

            return PartialView("_DepartmentDetails", department);
        }
        public IActionResult ViewOrg()
        {
            var departments = _context.Departments.ToList();
            return View(departments);
        }
        
    }
}
