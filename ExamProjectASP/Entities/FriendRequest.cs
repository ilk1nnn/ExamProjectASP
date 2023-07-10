namespace ExamProjectASP.Entities
{
	public class FriendRequest
	{
		public int Id { get; set; }
		public int SenderId { get; set; }
		public int ReceiverId { get; set; }
		public virtual CustomIdentityUser Sender { get; set; }
		public virtual CustomIdentityUser Receiver { get; set; }
	}

}
