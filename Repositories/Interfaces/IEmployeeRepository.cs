using EmployeeManagement.DTOs.Employee;

namespace EmployeeManagement.Repositories.Interfaces
{
    public interface IEmployeeRepository
    {
        Task CreateEmployee(UpdateEmployeeDTO employeeData, CancellationToken cancellationToken);
        Task DeleteEmployee(int employeeID, CancellationToken cancellationToken);
        Task<IEnumerable<GetEmployeeDTO>> GetAllEmployees(CancellationToken cancellationToken);
        Task<GetEmployeeDTO> GetEmployee(int employeeID, CancellationToken cancellationToken);
        Task UpdateEmployee(UpdateEmployeeDTO employeeData, int employeeID, CancellationToken cancellationToken);
    }
}