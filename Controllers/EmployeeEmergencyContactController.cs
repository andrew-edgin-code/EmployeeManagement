using EmployeeManagement.DTOs.Employee;
using EmployeeManagement.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeManagement.Controllers
{
    [Route("api/employee/{employeeID}/emergency-contact")]
    [ApiController]
    public class EmployeeEmergencyContactController : ControllerBase
    {
        private readonly EmployeeEmergencyContactService _employeeEmergencyContactService;

        public EmployeeEmergencyContactController(EmployeeEmergencyContactService employeeEmergencyContactService)
        {
            _employeeEmergencyContactService = employeeEmergencyContactService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllEmergencyContacts(int employeeID, CancellationToken cancellationToken)
        {
            return Ok(await _employeeEmergencyContactService.GetAllEmergencyContacts(employeeID, cancellationToken));
        }

        [HttpGet("{employeeEmergencyContactID}")]
        public async Task<IActionResult> GetEmergencyContact(int employeeEmergencyContactID, CancellationToken cancellationToken)
        {
            return Ok(await _employeeEmergencyContactService.GetEmergencyContact(employeeEmergencyContactID, cancellationToken));
        }

        [HttpPost]
        public async Task CreateEmergencyContact([FromBody] UpdateEmergencyContactDTO emergencyContactData, CancellationToken cancellationToken)
        {
            await _employeeEmergencyContactService.CreateEmergencyContact(emergencyContactData, cancellationToken);
        }

        [HttpPatch("{employeeEmergencyContactID}")]
        public async Task UpdateEmergencyContact([FromBody] UpdateEmergencyContactDTO emergencyContactData, int employeeEmergencyContactID, CancellationToken cancellationToken)
        {
            await _employeeEmergencyContactService.UpdateEmergencyContact(emergencyContactData, employeeEmergencyContactID, cancellationToken);
        }

        [HttpDelete("{employeeEmergencyContactID}")]
        public async Task DeleteEmergencyContact(int employeeEmergencyContactID, CancellationToken cancellationToken)
        {
            await _employeeEmergencyContactService.DeleteEmergencyContact(employeeEmergencyContactID, cancellationToken);
        }
    }
}
