using System.ComponentModel.DataAnnotations;

namespace user.Models
{
    public class User
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public string Email { get; set; }
    }
}