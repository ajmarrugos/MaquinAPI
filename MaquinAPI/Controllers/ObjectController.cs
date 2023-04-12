using MaquinOM.Object;
using Microsoft.AspNetCore.Mvc;

namespace MaquinAPI.Controllers;

[ApiController]
[Route("objects")]
public class ObjectController : ControllerBase
{
    [HttpPost()]
    public IActionResult CreateObject(CreateObjectRequest request) => Ok(request);

    [HttpGet("{id:guid}")]
    public IActionResult GetObject(Guid id) => Ok(id);

    [HttpPut("{id:guid}")]
    public IActionResult UpsertObject(Guid id, UpsertObjectRequest request) => Ok(request);

    [HttpDelete("{id:guid}")]
    public IActionResult DeleteObject(Guid id) => Ok(id);
}
