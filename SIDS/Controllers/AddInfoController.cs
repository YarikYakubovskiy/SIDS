using Microsoft.AspNetCore.Mvc;

namespace SIDS.Controllers;

[Route("[controller]")]
[ApiController]
public class AddInfoController : Controller
{
    [HttpGet("")]
    public IActionResult AddInfo()
    {
        return View();
    }

    [HttpGet("{id}")]
    public IActionResult GetInfo(string id)
    {
        return View($"{id}");
    }
}
