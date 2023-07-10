namespace ExamProjectASP.Entities
{
	public class Chat
	{
		public int Id { get; set; }
		public virtual CustomIdentityUser FirstUser { get; set; }
		public virtual CustomIdentityUser SecondUser { get; set; }
		public List<Message> Messages { get; set; }
	}

}
