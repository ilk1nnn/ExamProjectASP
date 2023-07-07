using System.ComponentModel.DataAnnotations;

namespace ExamProjectASP.Models
{
    public class LoginViewModel
    {
        [Required]
        public string Email { get; set; }
        public string UserName { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        public bool RememberMe { get; set; } = false;
    }
}
