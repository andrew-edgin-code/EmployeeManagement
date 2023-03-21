using EmployeeManagement.DTOs.Employee;
using EmployeeManagement.Repositories.Implementations;
using EmployeeManagement.Repositories.Interfaces;
using EmployeeManagement.Services.Interfaces;

namespace EmployeeManagement.Services.Implementations
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IEmployeeRepository _employeeRepository;

        public EmployeeService(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        public async Task<IEnumerable<GetEmployeeDTO>> GetAllEmployees(CancellationToken cancellationToken)
        {
            return await _employeeRepository.GetAllEmployees(cancellationToken);
        }

        public async Task<GetEmployeeDTO> GetEmployee(int employeeID, CancellationToken cancellationToken)
        {
            return await _employeeRepository.GetEmployee(employeeID, cancellationToken);
        }

        public async Task CreateEmployee(UpdateEmployeeDTO employeeData, CancellationToken cancellationToken)
        {
            await _employeeRepository.CreateEmployee(employeeData, cancellationToken);
        }

        public async Task UpdateEmployee(UpdateEmployeeDTO employeeData, int employeeID, CancellationToken cancellationToken)
        {
            await _employeeRepository.UpdateEmployee(employeeData, employeeID, cancellationToken);
        }

        public async Task DeleteEmployee(int employeeID, CancellationToken cancellationToken)
        {
            await _employeeRepository.DeleteEmployee(employeeID, cancellationToken);
        }
    }
}
