using MaquinAPI.Models;
using Microsoft.AspNetCore.Mvc;
using System.Numerics;

namespace MaquinAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]

    // API CLIENT: UsersController
    public class Ext_UsersController : ControllerBase
    {

        private readonly HttpClient _client;
        public Ext_UsersController(IHttpClientFactory httpClientFactory)
        {
            _client = httpClientFactory.CreateClient("jsonplaceholder");
        }

        [HttpGet] // GET: All api/Users
        public async Task<IActionResult> GetAll()
        {
            try
            {
                var response = await _client.GetAsync("users");
                response.EnsureSuccessStatusCode();
                var users = await response.Content.ReadAsAsync<List<User>>();
                return Ok(users);
            }
            catch (HttpRequestException)
            {
                return StatusCode(500);
            }
        }

        [HttpGet("{id}")] // GET: Single api/User/
        public async Task<IActionResult> Get(int id)
        {
            try
            {
                var response = await _client.GetAsync($"users/{id}");
                response.EnsureSuccessStatusCode();
                var user = await response.Content.ReadAsAsync<User>();
                return Ok(user);
            }
            catch (HttpRequestException)
            {
                return NotFound();
            }
        }

        [HttpPost] // POST: in api/Users/
        public async Task<IActionResult> Create([FromBody] User user)
        {
            try
            {
                var response = await _client.PostAsJsonAsync("users", user);
                response.EnsureSuccessStatusCode();
                var createdUser = await response.Content.ReadAsAsync<User>();
                return CreatedAtAction(nameof(Get), new { id = createdUser.Id }, createdUser);
            }
            catch (HttpRequestException)
            {
                return StatusCode(500);
            }
        }

        [HttpPut("{id}")] // PUT: in api/Users/
        public async Task<IActionResult> Update(int id, [FromBody] User user)
        {
            try
            {
                var response = await _client.PutAsJsonAsync($"users/{id}", user);
                response.EnsureSuccessStatusCode();
                var updatedUser = await response.Content.ReadAsAsync<User>();
                return Ok(updatedUser);
            }
            catch (HttpRequestException)
            {
                return StatusCode(500);
            }
        }

        [HttpDelete("{id}")] // DELETE: from api/Users/
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                var response = await _client.DeleteAsync($"users/{id}");
                response.EnsureSuccessStatusCode();
                return NoContent();
            }
            catch (HttpRequestException)
            {
                return StatusCode(500);
            }
        }
    }
}