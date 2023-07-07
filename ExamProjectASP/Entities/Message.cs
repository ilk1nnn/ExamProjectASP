namespace ExamProjectASP.Entities
{
	public class Message
	{
		public int Id { get; set; }
		public int ChatId { get; set; }
		public int SenderId { get; set; }
		public int ReceiverId { get; set; }

		public virtual Chat Chat { get; set; }
		public virtual User Sender { get; set; }
		public virtual User Receiver { get; set; }
	}

}
