namespace ExamProjectASP.Entities
{
	public class Tagged
	{
		public int Id { get; set; }
		public int PostId { get; set; }
		public int UserId { get; set; }
		public virtual Post Post { get; set; }
		public virtual CustomIdentityUser User { get; set; }
	}


}
