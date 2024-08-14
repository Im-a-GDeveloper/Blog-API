using System.ComponentModel.DataAnnotations;

namespace Blog_API.DTO
{   
    public class UserDTO{

        [Required]
        public string Name {get; set;} = null!;

        [MaxLength(255)]
        public string Description {get; set;} = null!;

        [Required]
        [MaxLength(120)]
        public string Password {get; set;} = null!;

        public string twitterUser {get; set;} = null!;

        //public IFormFile profilePicture {get; set;} = null!;

    }
}