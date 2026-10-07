using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;

public class MovieController : Controller
{
    private readonly IMemoryCache _cache;

    public MovieController(IMemoryCache cache)
    {
        _cache = cache;
    }

    public IActionResult Index()
    {
        return View();
    }

    [HttpPost]
    public IActionResult SelectTheatre(string theatre)
    {
        HttpContext.Session.SetString("Theatre", theatre);
        return RedirectToAction("Showtimes");
    }

    public IActionResult Showtimes()
    {
        string theatre = HttpContext.Session.GetString("Theatre") ?? "";
        string message;

        if (!_cache.TryGetValue(theatre, out object? data))
        {
            var movieData = new
            {
                Timings = new[] { "9:00 AM", "12:00 PM", "5:00 PM" },
                Movies = new[] { "ABC", "PQR", "XYZ" }
            };

            _cache.Set(theatre, movieData, TimeSpan.FromSeconds(30));

            message = "Loaded fresh (not from cache)";
            ViewBag.Data = movieData;
        }
        else
        {
            message = "Reading From Cache";
            ViewBag.Data = data;
        }

        ViewBag.Message = message;
        return View();
    }
}