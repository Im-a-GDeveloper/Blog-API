using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Blog_API.Models
{   
    [Table("Users")]
    public class User{


        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UserID {get; set;}

        [Required]
        public string Name {get; set;} = null!;

        [MaxLength(255)]
        public string? Description {get; set;}

        [Required]
        [MaxLength(120)]
        public string Password {get; set;} = null!;

        public string? twitterUser {get; set;}

        //public IFormFile profilePicture {get; set;} = null!;

        public ICollection<Post>? Post {get; set;}
    }
}