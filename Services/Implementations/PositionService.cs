using EmployeeManagement.DTOs.Employee;
using EmployeeManagement.Repositories.Implementations;
using EmployeeManagement.Repositories.Interfaces;
using EmployeeManagement.Services.Interfaces;

namespace EmployeeManagement.Services.Implementations
{
    public class PositionService : IPositionService
    {
        private readonly IPositionRepository _positionRepository;

        public PositionService(IPositionRepository positionRepository)
        {
            _positionRepository = positionRepository;
        }

        public async Task<IEnumerable<GetPositionDTO>> GetAllPositions(CancellationToken cancellationToken)
        {
            return await _positionRepository.GetAllPositions(cancellationToken);
        }

        public async Task<GetPositionDTO> GetPosition(int positionID, CancellationToken cancellationToken)
        {
            return await _positionRepository.GetPosition(positionID, cancellationToken);
        }

        public async Task CreatePosition(UpdatePositionDTO positionData, CancellationToken cancellationToken)
        {
            await _positionRepository.CreatePosition(positionData, cancellationToken);
        }

        public async Task UpdatePosition(UpdatePositionDTO positionData, int positionID, CancellationToken cancellationToken)
        {
            await _positionRepository.UpdatePosition(positionData, positionID, cancellationToken);
        }

        public async Task DeletePosition(int positionID, CancellationToken cancellationToken)
        {
            await _positionRepository.DeletePosition(positionID, cancellationToken);
        }
    }
}
