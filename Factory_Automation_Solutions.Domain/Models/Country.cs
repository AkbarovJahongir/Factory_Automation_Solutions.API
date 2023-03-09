using System.Text.Json.Serialization;
using Factory_Automation_Solutions.Domain.Models;
using Factory_Automation_Solutions.Models;

namespace Factory_Automation_Solutions.Models
{
	public class Country : EntityBase
	{
		public string? Name { get; set; }
		[JsonIgnore]
		public List<Manafacture>? Manafactures { get; set; }
	}
}
