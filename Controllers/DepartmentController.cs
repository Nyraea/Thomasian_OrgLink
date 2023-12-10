using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ThomasianOrglist.Data;
using ThomasianOrglist.Models;

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
        public IActionResult DepartmentDetails(DepartmentName selectedDepartment)
        {
            var department = _context.Departments
                .Include(d => d.Organizations)
                .FirstOrDefault(d => d.Id == selectedDepartment);

            if (department == null)
            {
                return NotFound();
            }

            return View("DepartmentDetails", department);
        }


        [HttpGet]
        public IActionResult Details(DepartmentName departmentId, int orgId)
        {
            var organization = _context.Organizations
                .FirstOrDefault(o => o.DepartmentId == departmentId && o.org_id == orgId);

            if (organization == null)
            {
                return NotFound();
            }

            return View(organization);
        }
        public IActionResult ViewOrg()
        {
            var departments = _context.Departments.ToList();
            return View(departments);
        }

    }
}