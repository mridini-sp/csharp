using Microsoft.AspNetCore.Mvc;
using PersonalDetailsApp.Models;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View(new PersonalDetails());
    }

    [HttpPost]
    public IActionResult Index(PersonalDetails model)
    {
        ViewBag.Submitted = true;
        return View(model);
    }
}