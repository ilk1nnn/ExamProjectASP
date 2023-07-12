namespace ExamProjectASP.Entities
{
	public class Notification
	{
		public int Id { get; set; }
		public string Caption { get; set; }
		public DateTime Date { get; set; }

		public string SenderId { get; set; }
		public string OwnerId { get; set; }

		public virtual CustomIdentityUser Sender { get; set; }
		public virtual CustomIdentityUser Owner { get; set; }
	}

}
