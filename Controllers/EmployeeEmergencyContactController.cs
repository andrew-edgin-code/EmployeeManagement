using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeManagement.Controllers
{
    [Route("api/employee/{employeeID}/emergency-contact")]
    [ApiController]
    public class EmployeeEmergencyContactController : ControllerBase
    {
        public EmployeeEmergencyContactController()
        {
            
        }
    }
}
