using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Blog_API.Models{

    [Table("Posts")]
    public class Post{

        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PostID {get; set;}

        [Required]
        [ForeignKey("UserID")]
        public int UserID {get; set;}

        [Required]
        [MaxLength(120)]
        public string Title {get; set;} = null!;

        [Required]
        public string Content {get; set;} = null!;

        [Required]
        public DateTime CreatedDate = DateTime.Now;

        public DateTime LastModifiedDate {get; set;}

        [Required]
        public bool IsPublicated {get; set;}


        public User? User {get; set;}
    }
}