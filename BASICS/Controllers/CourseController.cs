using Microsoft.AspNetCore.Mvc;
using BASICS.Models;
namespace BASICS.Controllers
{
    public class CourseController : Controller
    {
         
        public IActionResult Index()
        {
            var kurs = new Course();
            kurs.Id= 1;
            kurs.Title= "ASp.Net Core Kursu";
            kurs.Image="1.jpg";
            return View(kurs);
        }

        public IActionResult List()
        {
            var kurslar= new List<Course>(){
                new Course() {Id=1, Title="Aspnet Kursu", Description="Güzel bir kurs",Image="1.jpg"},
                 new Course() {Id=2, Title="PHP Kursu", Description="Güzel bir kurs",Image="2.jpg"},
                  new Course() {Id=3, Title="Django Kursu", Description="Güzel bir kurs",Image="3.jpg"},
                  new Course() {Id=3, Title="JavaScript Kursu", Description="Güzel bir kurs"}
            };
            return  View("CourseList", kurslar);
        }

    }
}
