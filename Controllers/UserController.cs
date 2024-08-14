using Blog_API.DTO;
using Blog_API.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Blog_API.Controllers{

    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase{

        private readonly ApplicationDbContext _context;
        private readonly ILogger<UserController> _logger;

        public UserController(
            ApplicationDbContext context,
            ILogger<UserController> logger
        ){

            _logger = logger;
            _context = context;
        }


        [HttpPost("AddNewUser")]
        public async Task<ActionResult> Post(UserDTO user ){

            var new_user = new User(){
                Name = user.Name,
                Password = user.Password
            };

            _context.Users.Add(new_user);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(Post), 
                new { 
                    name = new_user.Name,   
                    password = new_user.Password
                });
        }

        [HttpGet("GetAllUsers/{id}")]
        public async Task<ActionResult<User>> Get(int id)
        {
            var query = await _context.Users.FindAsync(id);

            return  query;
        }

    }
}