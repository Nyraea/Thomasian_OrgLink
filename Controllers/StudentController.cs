using Microsoft.AspNetCore.Mvc;
using System;
using ThomasianOrglist.Models;
using ThomasianOrglist.Data;
using Microsoft.EntityFrameworkCore;

namespace ThomasianOrglist.Controllers
{
    public class StudentController : Controller
    {

        private readonly AppDbContext _dbContext;

        public StudentController(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet]

        public IActionResult AddStudent()
        {
            return View();
        }

        [HttpPost]

        public IActionResult AddStudent(Student newStudent)
        {
            _dbContext.Students.Add(newStudent);
            _dbContext.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]

        public IActionResult LoginStudent()
        {
            return View();
        }

    }

   
}
