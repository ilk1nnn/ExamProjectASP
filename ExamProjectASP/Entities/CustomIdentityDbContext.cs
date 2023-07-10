using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ExamProjectASP.Entities
{
    public class CustomIdentityDbContext : IdentityDbContext<CustomIdentityUser,CustomIdentityRole,string>
    {
        public CustomIdentityDbContext(DbContextOptions<CustomIdentityDbContext>options)
            :base(options)
        {

        }

        public DbSet<Chat> Chats { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<CommentLike> CommentLikes { get; set; } 
        public DbSet<Friend> Friends { get; set; } 
        public DbSet<FriendRequest> FriendRequests { get; set; } 
        public DbSet<Group> Groups { get; set; } 
        public DbSet<GroupUser> GroupUsers { get; set; } 
        public DbSet<Message> Messages { get; set; } 
        public DbSet<Notification> Notifications { get; set; } 
        public DbSet<Post> Posts { get; set; } 
        public DbSet<PostLike> PostLikes { get; set; } 
        public DbSet<Tagged> Taggeds { get; set; } 


    }
}
