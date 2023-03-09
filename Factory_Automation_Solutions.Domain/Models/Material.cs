using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Factory_Automation_Solutions.Domain.Models
{
    public class Material : EntityBase
    {
        public string? Name { get; set; }
        public int SupplierId { get; set; }
        public Supplier? Suppliers { get; set; }
        [JsonIgnore]
        public List<Product>? Productst { get; set; }
    }
}
