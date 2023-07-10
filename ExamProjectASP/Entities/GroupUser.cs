namespace ExamProjectASP.Entities
{
	public class GroupUser
	{
		public int Id { get; set; }
		public int UserId { get; set; }
		public int GroupId { get; set; }
		public CustomIdentityUser User { get; set; }
		public Group Group { get; set; }
	}

}
