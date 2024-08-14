using Blog_API.DTO;
using Blog_API.Models;
using Microsoft.AspNetCore.Mvc;

namespace Blog_API.Controllers{


    [ApiController]
    [Route("[controller]")]
    public class PostController : ControllerBase{

        private readonly ApplicationDbContext _context;
        private readonly ILogger<PostController> _logger;


        public PostController(ApplicationDbContext context, ILogger<PostController> logger){
            _context = context;
            _logger  = logger;
        }


        // [HttpPost("CreateNewPost")]
        // public async Task<RestDTO<Post>> Create(PostDTO post){



                
        // }
    }
}