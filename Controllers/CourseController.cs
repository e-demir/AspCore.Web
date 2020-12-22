using Microsoft.AspNetCore.Mvc;

namespace AspCore.Web.Controllers
{
    public class CourseController : Controller
    {
        //course/index
        public IActionResult Index()
        {
            return View();
        }

        //course/list
        public IActionResult List()
        {
            return View();
        }
    }
}
