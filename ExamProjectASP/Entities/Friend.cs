namespace ExamProjectASP.Entities
{
	public class Friend
	{
		public int Id { get; set; }
		public int FirstUserId { get; set; }
		public int SecondUserId { get; set; }
		public virtual CustomIdentityUser FirstUser { get; set; }
		public virtual CustomIdentityUser SecondUser { get; set; }
	}

}
