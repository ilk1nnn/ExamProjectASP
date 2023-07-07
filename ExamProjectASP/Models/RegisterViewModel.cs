using System.ComponentModel.DataAnnotations;

namespace ExamProjectASP.Models
{
    public class RegisterViewModel
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string Surname { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        public IFormFile File { get; set; }
        public string? ImageUrl { get; set; } = "~/images/profile.png";
        public string UserName { get; set; }
    }
}
