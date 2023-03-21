using EmployeeManagement.DTOs.Employee;

namespace EmployeeManagement.Services.Interfaces
{
    public interface IEmployeeEmergencyContactService
    {
        Task CreateEmergencyContact(UpdateEmergencyContactDTO emergencyContactData, CancellationToken cancellationToken);
        Task DeleteEmergencyContact(int employeeEmergencyContactID, CancellationToken cancellationToken);
        Task<IEnumerable<GetEmergencyContactDTO>> GetAllEmergencyContacts(int employeeID, CancellationToken cancellationToken);
        Task<GetEmergencyContactDTO> GetEmergencyContact(int employeeEmergencyContactID, CancellationToken cancellationToken);
        Task UpdateEmergencyContact(UpdateEmergencyContactDTO emergencyContactData, int employeeEmergencyContactID, CancellationToken cancellationToken);
    }
}