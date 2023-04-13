using MaquinAPI;
using Microsoft.AspNetCore.Mvc;
using System.Numerics;

namespace MaquinAPI.Controllers
{
    // API CONTROLLER
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        // Simulated User template
        private static List<User> users = new List<User>
        {
            new User
            {
                Id = 1,
                Name = "Alberto Marrugo",
                Username = "ajmarrugos",
                Email = "ajmarrugos@gmail.com",
                Address = new Address
                {
                    Street = "Boyaca",
                    Suite = "Apt. 007",
                    City = "Bogota",
                    Zipcode = "0101010",
                    Geo = new Geo
                    {
                        Lat = "-37.3159",
                        Lng = "81.1496"
                    }
                },
                Phone = "57-300-416-1450",
                Website = "github.com/ajmarrugos",
                Company = new Company
                {
                    Name = "Unosquare",
                    CatchPhrase = "Nearshore Software Engineers For Your Digital Transformation",
                    Bs = "Digital Engineering"
                }
            }
        };

        // GET: api/Users/
        [HttpGet]
        public async Task<ActionResult<List<User>>> Get()
        {
            return Ok(users);
        }

        // POST api/Users/
        [HttpPost]
        public async Task<ActionResult<List<User>>> AddUser()
        {
            return Ok(users);
        }


        // PUT api/Users/
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/Users/
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
