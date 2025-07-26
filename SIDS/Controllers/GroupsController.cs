using Microsoft.AspNetCore.Mvc;

namespace SIDS.Controllers;

[Route("[controller]")]
[ApiController]
public class GroupsController : Controller
{
    [HttpGet("")]
    public IActionResult Groups()
    {
        return View();
    }

    [HttpGet("{id}")]
    public IActionResult GetGroup(string id)
    {
        return View(id);
    }
}
