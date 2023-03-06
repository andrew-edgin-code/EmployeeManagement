using EmployeeManagement.DTOs.Employee;
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

        public async Task<IEnumerable<GetAllEmployeesDTO>> GetAllEmployees(CancellationToken cancellationToken)
        {
            return await _employeeRepository.GetAllEmployees(cancellationToken);
        }

        public async Task<GetEmployeeDTO> GetEmployee(int employeeID, CancellationToken cancellationToken)
        {
            return await _employeeRepository.GetEmployee(employeeID, cancellationToken);
        }
    }
}
