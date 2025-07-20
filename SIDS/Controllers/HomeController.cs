using Microsoft.AspNetCore.Mvc;

namespace SIDS.Controllers;

[ApiController]
public class HomeController : Controller
{
    [HttpGet("")]
    public IActionResult Index()
    {
        return View();
    }
}
