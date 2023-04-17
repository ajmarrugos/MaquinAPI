using MaquinAPI;
using MaquinAPI.Models;
using Microsoft.AspNetCore.Mvc;
using System.Numerics;

namespace MaquinAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]

    // LOCAL API: UsersController
    public class UsersController : ControllerBase
    {
        // Simulated Users template
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
            },

            new User
            {
                Id = 2,
                Name = "Leanne Graham",
                Username = "Bret",
                Email = "Sincere@april.biz",
                Address = new Address
                {
                    Street = "Kulas Light",
                    Suite = "Apt. 556",
                    City = "Gwenborough",
                    Zipcode = "92998-3874",
                    Geo = new Geo
                    {
                        Lat = "-37.3159",
                        Lng = "81.1496"
                    }
                },
                Phone = "1-770-736-8031 x56442",
                Website = "hildegard.org",
                Company = new Company
                {
                    Name = "Romaguera-Crona",
                    CatchPhrase = "Multi-layered client-server neural-net",
                    Bs = "harness real-time e-markets"
                }
            }
        };

        [HttpGet] // GET: All api/Users
        public async Task<ActionResult<List<User>>> Get()
        {
            return Ok(users);
        }

        [HttpGet("{id}")] // GET: Single api/User/
        public async Task<ActionResult<User>> Get(int id)
        {
            var user = users.Find(u => u.Id == id);
            if (user == null)
            {
                return BadRequest("User not found");
            }
            return Ok(user);
        }

        [HttpPost] // POST: in api/Users/
        public async Task<ActionResult<List<User>>> AddUser(User user)
        {
            users.Add(user);
            return Ok(users);
        }

        [HttpPut] // PUT: in api/Users/
        public async Task<ActionResult<List<User>>> UpdateUser(User request)
        {
            var user = users.Find(u => u.Id == request.Id);
            if (user == null)
            {
                return BadRequest("User not found");
            }

            // Updates definitions of the User
            user.Name = request.Name;
            user.Username = request.Username;
            user.Email = request.Email;
            user.Address = request.Address;
            user.Address.Street = request.Address.Street;
            user.Address.Suite = request.Address.Suite;
            user.Address.Zipcode = request.Address.Zipcode;
            user.Address.Geo = request.Address.Geo;
            user.Address.Geo.Lat = request.Address.Geo.Lat;
            user.Address.Geo.Lng = request.Address.Geo.Lng;
            user.Phone = request.Phone;
            user.Website = request.Website;
            user.Company = request.Company;
            user.Company.Name = request.Company.Name;
            user.Company.CatchPhrase = request.Company.CatchPhrase;
            user.Company.Bs = request.Company.Bs;

            return Ok(users);
        }

        [HttpDelete("{id}")] // DELETE: from api/Users/
        public async Task<ActionResult<List<User>>> DeleteUser(int id)
        {
            var user = users.Find(u => u.Id == id);
            if (user == null)
            {
                return BadRequest("User not found");
            }
            users.Remove(user);
            return Ok(users);
        }
    }
}
