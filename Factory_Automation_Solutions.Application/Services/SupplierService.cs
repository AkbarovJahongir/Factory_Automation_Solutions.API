using Factory_Automation_Solutions.Application.Common.Interfaces;
using Factory_Automation_Solutions.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Automation_Solutions.Application.Services
{
    public class SupplierService : BaseService<Supplier>, ISupplierService
    {
        public override Supplier Get(ulong id)
        {
            if (id == 1)
                return new Supplier() { Name = "USA" };

            return new Supplier() { Name = "Russia" };
        }
    }
}
