using Microsoft.AspNetCore.Identity;

namespace ExamProjectASP.Entities
{
    public class CustomIdentityUser : IdentityUser
    {
        public string ImageUrl { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public bool IsOnline { get; set; }
        public bool IsFriend { get; set; }
        public bool HasRequestPending { get; set; } = false;
        public DateTime DisconnectTime { get; set; } = DateTime.Now;
        public DateTime ConnectTime { get; set; }

    }
}
