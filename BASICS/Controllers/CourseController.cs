using Microsoft.AspNetCore.Mvc;

namespace BASICS.Controllers
{
    public class CourseController : Controller
    {
        // GET: CourseController
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult List()
        {
            return  View("CourseList");
        }

    }
}
