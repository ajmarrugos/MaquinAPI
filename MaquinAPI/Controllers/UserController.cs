using MaquinOM.User;
using Microsoft.AspNetCore.Mvc;

namespace MaquinAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class UserController : ControllerBase
{
    [HttpPost()]
    public IActionResult CreateUser(CreateUserRequest request)
    {
        // Map the data get from the request to an C# User
        var user = new User(
            Guid.NewGuid(),
            request.Name,
            request.Description,
            request.StartDateTime,
            request.EndDateTime,
            DateTime.UtcNow,
            request.Tags,
            request.Labels);
        
        // Takes the data mapped from the User and converts it to an API definition
        var response = new UserResponse(
            user.Id,
            user.Name,
            user.Description,
            user.LastModifiedDateTime,
            user.Tags,
            user.Labels);

        return CreatedAtAction(
            actionName: nameof(GetUser),
            routeValues: new { id = user.Id },
            value: response);
    }


    [HttpGet("{id:guid}")]
    public IActionResult GetUser(Guid id) => Ok(id);

    [HttpPut("{id:guid}")]
    public IActionResult UpsertUser(Guid id, UpsertUserRequest request) => Ok(request);

    [HttpDelete("{id:guid}")]
    public IActionResult DeleteUser(Guid id) => Ok(id);
}
