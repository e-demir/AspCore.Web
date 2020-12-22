using AspCore.Web.Models;
using Microsoft.AspNetCore.Mvc;

namespace AspCore.Web.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            Course course = new Course();
            course.Name = "Asp.Net Core Web";
            course.Id = 1;
            return View(course);
        }
    }
}
