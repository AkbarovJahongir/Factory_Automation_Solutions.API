using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Factory_Automation_Solutions.Domain.Models
{
    public class Supplier : EntityBase
    {
        public string? Name { get; set; }
        public string? Address { get; set; }
        public string? Phone { get; set; }
        [JsonIgnore]
        public List<Material> Materials { get; set; }
    }
}
