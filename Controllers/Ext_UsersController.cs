using MaquinAPI.Models;
using Microsoft.AspNetCore.Mvc;
using System.Numerics;

namespace MaquinAPI.Controllers
{
    [ApiController]
    [Route("JSONPlaceholder/users/")]

    // API CLIENT: UsersController
    public class Ext_UsersController : ControllerBase
    {

        private readonly HttpClient _client;
        public Ext_UsersController(IHttpClientFactory httpClientFactory)
        {
            _client = httpClientFactory.CreateClient("jsonplaceholder");
        }

        /// <summary>
        /// Gets all Users
        /// </summary>
        /// <returns></returns>
        [HttpGet]
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

        /// <summary>
        /// Gets a single User by ID
        /// </summary>
        /// <returns></returns>
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
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

        /// <summary>
        /// Creates a new User
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> Create([FromBody] User user)
        {
            try
            {
                var response = await _client.PostAsJsonAsync("users", user);
                response.EnsureSuccessStatusCode();
                var createdUser = await response.Content.ReadAsAsync<User>();
                return CreatedAtAction(nameof(GetById), new { id = createdUser.Id }, createdUser);
            }
            catch (HttpRequestException)
            {
                return StatusCode(500);
            }
        }

        /// <summary>
        /// Updates a User by a given ID
        /// </summary>
        /// <returns></returns>
        [HttpPut("{id}")]
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

        /// <summary>
        /// Removes a User by a given ID
        /// </summary>
        /// <returns></returns>
        [HttpDelete("{id}")]
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