using MaquinAPI.Services;
using Microsoft.AspNetCore.Mvc;

namespace MaquinAPI.Controllers
{
    [Route("/users/")]
    [ApiController]
    public class ExternalUsersController : ControllerBase
    {
        private readonly ExternalApiService _externalApiService;

        public ExternalUsersController(ExternalApiService externalApiService)
        {
            _externalApiService = externalApiService;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetUser(int id)
        {
            var user = await _externalApiService.GetUserAsync(id);
            return Ok(user);
        }
    }
}
