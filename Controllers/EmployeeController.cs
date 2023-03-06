using EmployeeManagement.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeManagement.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmployeeController : ControllerBase
    {
        private readonly EmployeeService _employeeService;

        public EmployeeController(EmployeeService employeeService)
        {
            _employeeService = employeeService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllEmployees(CancellationToken cancellationToken)
        {
            return Ok(await _employeeService.GetAllEmployees(cancellationToken));
        }

        [HttpGet("{employeeID}")]
        public async Task<IActionResult> GetEmployee(int employeeID, CancellationToken cancellationToken)
        {
            return Ok(await _employeeService.GetEmployee(employeeID, cancellationToken));
        }
    }
}
