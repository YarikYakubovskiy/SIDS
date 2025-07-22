using Microsoft.AspNetCore.Mvc;

namespace SIDS.Controllers;

[Route("[controller]")]
[ApiController]
public class TechnologiesController : Controller
{
    [HttpGet("")]
    public IActionResult Technologies()
    {
        return View();
    }

    [HttpGet("{id}")]
    public IActionResult GetTechnology(int id)
    {
        return View($"{id}");
    }
}
