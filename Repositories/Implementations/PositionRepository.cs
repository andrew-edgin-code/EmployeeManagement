using EmployeeManagement.Data;
using EmployeeManagement.DTOs.Employee;
using EmployeeManagement.Models.Entities;
using EmployeeManagement.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace EmployeeManagement.Repositories.Implementations
{
    public class PositionRepository : IPositionRepository
    {
        private readonly DataContext _dataContext;

        public PositionRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public async Task<IEnumerable<GetPositionDTO>> GetAllPositions(CancellationToken cancellationToken)
        {
            return await _dataContext.Positions.Select(p => new GetPositionDTO
            {
                PositionID = p.PositionID,
                Title = p.Title,
                Code = p.Code
            }).ToListAsync(cancellationToken);
        }

        public async Task<GetPositionDTO> GetPosition(int positionID, CancellationToken cancellationToken)
        {
            return await _dataContext.Positions
            .Where(p => p.PositionID == positionID)
            .Select(p => new GetPositionDTO
            {
                PositionID = p.PositionID,
                Title = p.Title,
                Code = p.Code
            }).FirstOrDefaultAsync(cancellationToken);
        }

        public async Task CreatePosition(UpdatePositionDTO positionData, CancellationToken cancellationToken)
        {
            var newPosition = new Position
            {
                Title = positionData.Title,
                Code = positionData.Code
            };

            _dataContext.Positions.Add(newPosition);
            await _dataContext.SaveChangesAsync(cancellationToken);
        }

        public async Task UpdatePosition(UpdatePositionDTO positionData, int positionID, CancellationToken cancellationToken)
        {
            var position = await _dataContext.Positions.Where(p => p.PositionID == positionID).FirstOrDefaultAsync(cancellationToken);

            position.Title = positionData.Title;
            position.Code = positionData.Code;

            await _dataContext.SaveChangesAsync(cancellationToken);
        }

        public async Task DeletePosition(int positionID, CancellationToken cancellationToken)
        {
            var positionToDelete = await _dataContext.Positions.Where(p => p.PositionID == positionID).FirstOrDefaultAsync(cancellationToken);

            _dataContext.Positions.Remove(positionToDelete);
            await _dataContext.SaveChangesAsync(cancellationToken);
        }
    }
}
