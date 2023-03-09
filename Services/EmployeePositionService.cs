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

        public async Task CreateEmployeePosition(CreateEmployeePositionDTO employeePositionData, int employeeID, CancellationToken cancellationToken)
        {
            await _employeePositionRepository.CreateEmployeePosition(employeePositionData, employeeID, cancellationToken);
        }

        public async Task UpdateEmployeePositionRate(UpdateEmployeePositionRateDTO employeePositionData, int employeeID, CancellationToken cancellationToken)
        {
            await _employeePositionRepository.UpdateEmployeePositionRate(employeePositionData, employeeID, cancellationToken);
        }
    }
}
