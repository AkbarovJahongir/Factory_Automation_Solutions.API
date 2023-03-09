using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Factory_Automation_Solutions.Domain.Models
{
    public class Employee : EntityBase
    {
        public string? Name { get; set; }
        public string? Position { get; set; }
        public string? Phone { get; set; }
        [JsonIgnore]
        public List<Order> Orders { get; set; }
    }
}
