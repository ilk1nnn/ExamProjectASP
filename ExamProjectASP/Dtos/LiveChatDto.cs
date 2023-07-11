using ExamProjectASP.Entities;

namespace ExamProjectASP.Dtos
{
    public class LiveChatDto
    {
        public CustomIdentityUser CurrentUser { get; set; }

        public List<CustomIdentityUser> Users { get; set; }
    }
}
