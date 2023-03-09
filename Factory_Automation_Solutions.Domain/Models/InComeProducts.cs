using System.Text.Json.Serialization;

namespace Factory_Automation_Solutions.Domain.Models
{
    public class InComeProducts
	{
		public int Id { get; set; }
        public int  ProductId { get; set; }
        public Product? Products { get; set; }
        public DateTime? Date { get; set; }
        public decimal TotalPrice { get; set; }
        public int Count { get; set; }
        public int Status { get; set; }
    }
}
