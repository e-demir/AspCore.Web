using AspCore.Web.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;

namespace AspCore.Web.Controllers
{
    public class CourseController : Controller
    {
        //course/index
        public IActionResult Index()
        {
            var message = DateTime.Now.Hour > 12 ? "Tünaydın" : "Günaydın";
            ViewBag.Message = message;

            return View();
        }

        //course/list
        public IActionResult List()
        {
            var students =  Repository.Students.Where(c => c.WillAttend == true);
            return View(students);
        }

        [HttpGet]
        public IActionResult Apply()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Apply(Student student)
        {
            if (ModelState.IsValid)
            {
                Repository.AddStudent(student);
                return View("Thanks", student);
            }
            else
            {
                return View();
            }
        }
    }
}
