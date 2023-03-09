using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Factory_Automation_Solutions.Domain.Models
{
    public class Product : EntityBase
    {
        public string? Name { get; set; }
        public int MaterialId { get; set; }
        public Material? Matelials { get; set; }
        public int WareHouseId { get; set; }
        public WareHouse? WareHouses { get; set; }
        public decimal Product_price { get; set; }
        public string? Description { get; set; }
        [JsonIgnore]
        public List<InComeProducts>? InComeProducts { get; set; }
        public List<Order>? Orders { get; set; }
    }
}
