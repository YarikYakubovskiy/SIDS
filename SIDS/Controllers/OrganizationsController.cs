using Microsoft.AspNetCore.Mvc;

namespace SIDS.Controllers;

[Route("[controller]")]
[ApiController]
public class OrganizationsController : Controller
{
    [HttpGet("")]
    public IActionResult Organizations()
    {
        return View();
    }

    [HttpGet("{id}")]
    public IActionResult GetOrganization(int id)
    {
        return View($"{id}");
    }
}
