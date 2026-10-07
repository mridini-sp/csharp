using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace SecurityDemo.Controllers;

public class SecurityController : Controller
{
    public IActionResult PublicPage() => View();

    [Authorize]
    public IActionResult Dashboard() => View();

    [Authorize(Roles = "Admin")]
    public IActionResult Admin() => View();
}