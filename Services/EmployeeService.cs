using EmployeeManagement.DTOs.Employee;
using EmployeeManagement.Models;
using EmployeeManagement.Repositories;

namespace EmployeeManagement.Services
{
    public class EmployeeService
    {
        private readonly EmployeeRepository _employeeRepository;

        public EmployeeService(EmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        public async Task<IEnumerable<GetPositionDTO>> GetAllEmployees(CancellationToken cancellationToken)
        {
            return await _employeeRepository.GetAllEmployees(cancellationToken);
        }

        public async Task<GetPositionDTO> GetEmployee(int employeeID, CancellationToken cancellationToken)
        {
            return await _employeeRepository.GetEmployee(employeeID, cancellationToken);
        }

        public async Task CreateEmployee(UpdatePositionDTO employeeData, CancellationToken cancellationToken)
        {
            await _employeeRepository.CreateEmployee(employeeData, cancellationToken);
        }
        
        public async Task UpdateEmployee(UpdatePositionDTO employeeData, int employeeID, CancellationToken cancellationToken)
        {
            await _employeeRepository.UpdateEmployee(employeeData, employeeID, cancellationToken);
        }

        public async Task DeleteEmployee(int employeeID, CancellationToken cancellationToken)
        {
            await _employeeRepository.DeleteEmployee(employeeID, cancellationToken);
        }
    }
}
