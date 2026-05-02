using System.ComponentModel.DataAnnotations;
namespace WebApplication1.Models
{
    public class Userss
    {
        [Key]
        [StringLength(10)]
        public string Username { get; set; }

        [Required]
        [StringLength(100)]
        public string Password { get; set; }
    }
}
