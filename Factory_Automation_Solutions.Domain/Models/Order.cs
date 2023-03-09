using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Automation_Solutions.Domain.Models
{
    public class Order : EntityBase
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public Product? Products { get; set; }
        public int EmployeeId { get; set; }
        public Employee? Employees { get; set; }
        public int Quantity { get; set; }
        public DateTime? Order_Date { get; set; }
        public decimal Order_total { get; set; }
        public int Status { get; set; }
    }
}
