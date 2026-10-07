using Microsoft.AspNetCore.Mvc;

namespace StudentMVCApp.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.RollNo = 101;
            ViewBag.Name = "Rahul Sharma";
            ViewBag.Course = "B.Sc. Computer Applications";
            ViewBag.Marks = 85;
            return View();
        }

        public IActionResult Details()
        {
            ViewBag.RollNo = 101;
            ViewBag.Name = "Rahul Sharma";
            ViewBag.Course = "B.Sc. Computer Applications";
            ViewBag.Email = "rahul@example.com";
            ViewBag.City = "Mumbai";
            ViewBag.Marks = 85;
            return View();
        }
    }
}