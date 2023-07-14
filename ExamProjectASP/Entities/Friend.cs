namespace ExamProjectASP.Entities
{
	public class Friend
	{
		public int Id { get; set; }
		public string FirstUserId { get; set; }
		public string SecondUserId { get; set; }
		public virtual CustomIdentityUser FirstUser { get; set; }
		public virtual CustomIdentityUser SecondUser { get; set; }
	}

}
