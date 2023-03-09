namespace Factory_Automation_Solutions.Domain.Models
{
	public class User
	{
		public int Id { get; set; }
		public string? Name { get; set; }
		public string? Login { get; set; }
		public string? Password { get; set; }
		public int RoleID { get; set; }
		public Role? Role { get; set; }
    }
}
