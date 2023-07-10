namespace ExamProjectASP.Entities
{
	public class Group
	{
		public int Id { get; set; }
		public DateTime Date { get; set; }
		public int CreatorId { get; set; }
		public virtual CustomIdentityUser Creator { get; set; }
		public List<GroupUser> GroupUsers { get; set; }
	}

}
