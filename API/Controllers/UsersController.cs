using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    [Route("api/[controller]")] //Specifies the route for this controller(/api/Users)
    [ApiController]
    public class UsersController(DataContext context) : ControllerBase
    {
        [HttpGet] // Specifies that this method handles HTTP GET requests.
        public async Task<ActionResult<IEnumerable<AppUser>>> GetUsers()
        {
            var users = await context.Users.ToListAsync(); // Retrieves all users from the database.
            return Ok(users);                   // Returns the users with an HTTP 200 OK status.
        }

        [HttpGet("{id:int}")] // Specifies that this method handles HTTP GET requests with an integer parameter.
        public async Task<ActionResult<AppUser>> GetUser(int id)
        {
            var user = await context.Users.FindAsync(id);      // Finds a user by their ID.
            if (user == null) return NotFound();    // Returns HTTP 404 Not Found if the user doesn't exist.
            return Ok(user);                        // Returns the users with an HTTP 200 OK status.
        }
    }
}