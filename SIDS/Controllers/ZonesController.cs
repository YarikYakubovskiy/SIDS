using Microsoft.AspNetCore.Mvc;

namespace SIDS.Controllers;

[Route("[controller]")]
[ApiController]
public class ZonesController : Controller
{
    [HttpGet("")]
    public IActionResult Zones()
    {
        return View();
    }

    [HttpGet("{id}")]
    public IActionResult GetZone(int id)
    {
        return View($"{id}");
    }
}
