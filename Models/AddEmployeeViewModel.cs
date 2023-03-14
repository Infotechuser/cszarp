namespace WebApplication1.Models
{
    public class AddEmployeeViewModel
    {
		public Guid Id { get; set; }

		public string Name { get; set; }

		public string Email { get; set; }

		public string Salary { get; set; }

		public DateTime BirthDate { get; set; }

		public int Position { get; set; }
	}
}