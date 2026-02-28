using Ef_mvc.Data;
using Ef_mvc.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Text;

namespace ef_mvc.Controllers
{
    public class StudentsController : Controller
    {
        private readonly StudentManagementContext _context;

        public StudentsController(StudentManagementContext context)
        {
            _context = context;
        }


        public IActionResult Create(string name, int age, string email)
        {
            var student = new Student
            {
                Name = name,
                Age = age,
                Email = email
            };

            _context.Students.Add(student);
            _context.SaveChanges();



            return Content("Student Created Successfully");
        }
    }
}