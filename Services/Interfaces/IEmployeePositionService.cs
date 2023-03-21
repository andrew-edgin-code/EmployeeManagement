using EmployeeManagement.DTOs.EmployeePosition;

namespace EmployeeManagement.Services.Interfaces
{
    public interface IEmployeePositionService
    {
        Task CreateEmployeePosition(CreateEmployeePositionDTO employeePositionData, int employeeID, CancellationToken cancellationToken);
        Task<GetEmployeePositionDTO> GetCurrentPosition(int employeeID, CancellationToken cancellationToken);
        Task UpdateEmployeePositionRate(UpdateEmployeePositionRateDTO employeePositionData, int employeeID, CancellationToken cancellationToken);
    }
}