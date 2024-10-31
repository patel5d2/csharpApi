using Microsoft.AspNetCore.Mvc;

[Route("api/[controller]")]
[ApiController]
public class NameController : ControllerBase
{
    [HttpGet]
    public IActionResult GetName()
    {
        return Ok(new { Name = "Dharmin Patel", Age = 21 });
    }
}
