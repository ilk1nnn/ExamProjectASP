﻿namespace ExamProjectASP.Entities
{
	public class FriendRequest
	{
		public int Id { get; set; }
		public string SenderId { get; set; }
		public string ReceiverId { get; set; }
		public virtual CustomIdentityUser Sender { get; set; }
		public virtual CustomIdentityUser Receiver { get; set; }
	}

}
