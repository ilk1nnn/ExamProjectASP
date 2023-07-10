using System.Text.RegularExpressions;

namespace ExamProjectASP.Entities
{
	public class Post
	{
		public int Id { get; set; }
		public int GroupID { get; set; }
		public string Caption { get; set; }
		public string Url { get; set; }
		public DateTime Date { get; set; }
		public int UserId { get; set; }
		public virtual CustomIdentityUser User { get; set; }
		public virtual Group Group { get; set; }
		public List<PostLike> Likes { get; set; }
		public List<Tagged> TaggedUsers { get; set; }
		public List<Comment> Comments { get; set; }
	}

}
