using EmployeeManagement.DTOs.EmployeePosition;
using EmployeeManagement.Repositories;

namespace EmployeeManagement.Services
{
    public class EmployeePositionService
    {
        private readonly EmployeePositionRepository _employeePositionRepository;

        public EmployeePositionService(EmployeePositionRepository employeePositionRepository)
        {
            _employeePositionRepository = employeePositionRepository;
        }

        public async Task<GetEmployeePositionDTO> GetCurrentPosition(int employeeID, CancellationToken cancellationToken)
        {
            return await _employeePositionRepository.GetCurrentPosition(employeeID, cancellationToken);
        }

        public async Task UpdateEmployeePosition(UpdateEmployeePositionDTO employeePositionData, int employeeID, CancellationToken cancellationToken)
        {
            await _employeePositionRepository.UpdateEmployeePosition(employeePositionData, employeeID, cancellationToken);
        }
    }
}
