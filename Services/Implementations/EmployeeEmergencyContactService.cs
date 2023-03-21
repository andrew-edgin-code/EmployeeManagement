using EmployeeManagement.DTOs.Employee;
using EmployeeManagement.Repositories;
using EmployeeManagement.Repositories.Interfaces;
using EmployeeManagement.Services.Interfaces;

namespace EmployeeManagement.Services.Implementations
{
    public class EmployeeEmergencyContactService : IEmployeeEmergencyContactService
    {
        private readonly IEmployeeEmergencyContactRepository _employeeEmergencyContactRepository;

        public EmployeeEmergencyContactService(IEmployeeEmergencyContactRepository employeeEmergencyContactRepository)
        {
            _employeeEmergencyContactRepository = employeeEmergencyContactRepository;
        }

        public async Task<IEnumerable<GetEmergencyContactDTO>> GetAllEmergencyContacts(int employeeID, CancellationToken cancellationToken)
        {
            return await _employeeEmergencyContactRepository.GetAllEmergencyContacts(employeeID, cancellationToken);
        }

        public async Task<GetEmergencyContactDTO> GetEmergencyContact(int employeeEmergencyContactID, CancellationToken cancellationToken)
        {
            return await _employeeEmergencyContactRepository.GetEmergencyContact(employeeEmergencyContactID, cancellationToken);
        }

        public async Task CreateEmergencyContact(UpdateEmergencyContactDTO emergencyContactData, CancellationToken cancellationToken)
        {
            await _employeeEmergencyContactRepository.CreateEmergencyContact(emergencyContactData, cancellationToken);
        }

        public async Task UpdateEmergencyContact(UpdateEmergencyContactDTO emergencyContactData, int employeeEmergencyContactID, CancellationToken cancellationToken)
        {
            await _employeeEmergencyContactRepository.UpdateEmergencyContact(emergencyContactData, employeeEmergencyContactID, cancellationToken);
        }

        public async Task DeleteEmergencyContact(int employeeEmergencyContactID, CancellationToken cancellationToken)
        {
            await _employeeEmergencyContactRepository.DeleteEmergencyContact(employeeEmergencyContactID, cancellationToken);
        }
    }
}
