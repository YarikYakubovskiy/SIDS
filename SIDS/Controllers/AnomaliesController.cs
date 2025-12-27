using Microsoft.AspNetCore.Mvc;

namespace SIDS.Controllers;

[Route("[controller]")]
[ApiController]
public class AnomaliesController : Controller
{
    [HttpGet("")]
    public IActionResult Anomalies()
    {
        return View();
    }

    [HttpGet("{id}")]
    public IActionResult GetAnomaly(string id)
    {
        return View(id);
    }

