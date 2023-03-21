using EmployeeManagement.DTOs.EmployeePosition;
using EmployeeManagement.Repositories;
using EmployeeManagement.Repositories.Interfaces;
using EmployeeManagement.Services.Interfaces;

namespace EmployeeManagement.Services.Implementations
{
    public class EmployeePositionService : IEmployeePositionService
    {
        private readonly IEmployeePositionRepository _employeePositionRepository;

        public EmployeePositionService(IEmployeePositionRepository employeePositionRepository)
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
