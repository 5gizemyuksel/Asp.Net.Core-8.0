using Microsoft.AspNetCore.Mvc;

namespace BASICS.Controllers
{
    public class CourseController : Controller
    {
        // GET: CourseController
        public string Index()
        {
            return "course/index";
        }

        public string List()
        {
            return "course/list";
        }

    }
}
