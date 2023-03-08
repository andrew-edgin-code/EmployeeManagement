using EmployeeManagement.Data;
using EmployeeManagement.DTOs.Employee;
using Microsoft.EntityFrameworkCore;

namespace PositionManagement.Repositories
{
    public class PositionRepository
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
            return await _dataContext.Positions.Where(p => p.PositionID == positionID).Select(p => new GetPositionDTO
            {
                PositionID = p.PositionID,
                Title = p.Title,
                Code = p.Code
            }).FirstOrDefaultAsync(cancellationToken);
        }

        public async Task CreatePosition(UpdatePositionDTO positionData, CancellationToken cancellationToken)
        {

        }
        
        public async Task UpdatePosition(UpdatePositionDTO positionData, int positionID, CancellationToken cancellationToken)
        {

        }

        public async Task DeletePosition(int positionID, CancellationToken cancellationToken)
        {

        }
    }
}
