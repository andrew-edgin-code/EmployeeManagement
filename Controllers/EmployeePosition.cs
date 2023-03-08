using EmployeeManagement.DTOs.Employee;
using EmployeeManagement.Models.Entities;
using EmployeeManagement.Services;
using Microsoft.AspNetCore.Http;
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

        [HttpGet("{employeePositionID}")]
        public async Task<IActionResult> GetEmergencyContact(int employeePositionID, CancellationToken cancellationToken)
        {
            return Ok(await _employeePositionService.GetEmergencyContact(employeePositionID, cancellationToken));
        }

        [HttpPost]
        public async Task CreateEmergencyContact([FromBody] UpdateEmergencyContactDTO emergencyContactData, CancellationToken cancellationToken)
        {
            await _employeePositionService.CreateEmergencyContact(emergencyContactData, cancellationToken);
        }

        [HttpPatch("{employeePositionID}")]
        public async Task UpdateEmergencyContact([FromBody] UpdateEmergencyContactDTO emergencyContactData, int employeePositionID, CancellationToken cancellationToken)
        {
            await _employeePositionService.UpdateEmergencyContact(emergencyContactData, employeePositionID, cancellationToken);
        }

        [HttpDelete("{employeePositionID}")]
        public async Task DeleteEmergencyContact(int employeePositionID, CancellationToken cancellationToken)
        {
            await _employeePositionService.DeleteEmergencyContact(employeePositionID, cancellationToken);
        }
    }
}
