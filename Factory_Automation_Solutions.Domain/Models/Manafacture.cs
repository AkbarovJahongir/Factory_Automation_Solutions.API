using Factory_Automation_Solutions.Models;
using System.Text.Json.Serialization;

namespace Factory_Automation_Solutions.Domain.Models
{
	public class Manafacture
	{
		public int Id { get; set; }
		public string? Name { get; set; }
		public int CountryID { get; set; }
		public Country? Countries { get; set; }
		[JsonIgnore]
		public List<Product> Products { get; set; }
	}
}
