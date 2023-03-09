using Factory_Automation_Solutions.Application.Common.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Factory_Automation_Solutions.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SupplierController : ControllerBase
    {
        private readonly ISupplierService supplierService;
        public SupplierController(ISupplierService supplierService)
        {
            this.supplierService = supplierService;
        }
        [HttpGet("{id}")]
        public IActionResult Get(ulong id)
        {
            return Ok(supplierService.Get(id));
        }
    }
}
