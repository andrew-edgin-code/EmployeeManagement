using EmployeeManagement.DTOs.Employee;

namespace EmployeeManagement.Services.Interfaces
{
    public interface IEmployeeService
    {
        Task CreateEmployee(UpdateEmployeeDTO employeeData, CancellationToken cancellationToken);
        Task DeleteEmployee(int employeeID, CancellationToken cancellationToken);
        Task<IEnumerable<GetEmployeeDTO>> GetAllEmployees(CancellationToken cancellationToken);
        Task<GetEmployeeDTO> GetEmployee(int employeeID, CancellationToken cancellationToken);
        Task UpdateEmployee(UpdateEmployeeDTO employeeData, int employeeID, CancellationToken cancellationToken);
    }
}
