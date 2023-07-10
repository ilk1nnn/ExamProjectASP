﻿namespace ExamProjectASP.Entities
{
	public class CommentLike
	{
		public int Id { get; set; }
		public int CommentId { get; set; }
		public int UserId { get; set; }
		public virtual Comment Comment { get; set; }
		public virtual CustomIdentityUser User { get; set; }
	}

}
