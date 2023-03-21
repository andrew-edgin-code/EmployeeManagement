using EmployeeManagement.DTOs.Employee;

namespace EmployeeManagement.Services.Interfaces
{
    public interface IPositionService
    {
        Task CreatePosition(UpdatePositionDTO positionData, CancellationToken cancellationToken);
        Task DeletePosition(int positionID, CancellationToken cancellationToken);
        Task<IEnumerable<GetPositionDTO>> GetAllPositions(CancellationToken cancellationToken);
        Task<GetPositionDTO> GetPosition(int positionID, CancellationToken cancellationToken);
        Task UpdatePosition(UpdatePositionDTO positionData, int positionID, CancellationToken cancellationToken);
    }
}