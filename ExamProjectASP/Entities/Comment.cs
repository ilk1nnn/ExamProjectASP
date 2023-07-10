namespace ExamProjectASP.Entities
{
	public class Comment
	{
		public int Id { get; set; }
		public string CommentText { get; set; }
		public DateTime Date { get; set; }
		public int OwnerId { get; set; }
		public virtual CustomIdentityUser Owner { get; set; }
		public int PostId { get; set; }
		public virtual Post Post { get; set; }
		public virtual Comment ParentComment { get; set; }
		public List<CommentLike> Likes { get; set; }
	}

}
