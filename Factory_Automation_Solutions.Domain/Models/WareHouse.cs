using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Automation_Solutions.Domain.Models
{
    public class WareHouse : EntityBase
    {
        public string? Name { get; set; }
        public string? Location { get; set; }
        public string? Phone { get; set; }
    }
}
