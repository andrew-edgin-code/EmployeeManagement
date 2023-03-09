using EmployeeManagement.DTOs.EmployeePosition;
using EmployeeManagement.Services;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeManagement.Controllers
{
    [Route("api/employee/{employeeID}/employee-position")]
    [ApiController]
    public class EmployeePositionController : ControllerBase
    {
        private readonly EmployeePositionService _employeePositionService;

        public EmployeePositionController(EmployeePositionService employeePositionService)
        {
            _employeePositionService = employeePositionService;
        }

        [HttpGet]
        public async Task<IActionResult> GetCurrentPosition(int employeeID, CancellationToken cancellationToken)
        {
            return Ok(await _employeePositionService.GetCurrentPosition(employeeID, cancellationToken));
        }

        [HttpPost]
        public async Task UpdateEmployeePosition([FromBody] UpdateEmployeePositionDTO employeePositionData, int employeeID, CancellationToken cancellationToken)
        {
            await _employeePositionService.UpdateEmployeePosition(employeePositionData, employeeID, cancellationToken);
        }
    }
}
