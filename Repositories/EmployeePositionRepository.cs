using EmployeeManagement.Data;
using EmployeeManagement.DTOs.EmployeePosition;
using EmployeeManagement.Models.Entities;
using EmployeeManagement.Models.Enums;
using Microsoft.EntityFrameworkCore;

namespace EmployeeManagement.Repositories
{
    public class EmployeePositionRepository
    {
        private readonly DataContext _dataContext;

        public EmployeePositionRepository(DataContext dataContext) 
        {
            _dataContext = dataContext;
        }

        public async Task<GetEmployeePositionDTO> GetCurrentPosition(int employeeID, CancellationToken cancellationToken)
        {
            var currentPosition = await _dataContext.EmployeePositions
                .Where(ep => ep.EmployeeID == employeeID && ep.Status == StatusEnum.Active)
                .Select(ep => new GetEmployeePositionDTO
                {
                    EmployeeID = employeeID,
                    PositionID = ep.PositionID,
                    Status = ep.Status,
                    EffectiveDate = ep.EffectiveDate
                })
                .FirstOrDefaultAsync(cancellationToken);

            if (currentPosition == null) { }

            return currentPosition;
        }

        //Figure out a way to inactivate the current one before creating a new one
        public async Task UpdateEmployeePosition(UpdateEmployeePositionDTO employeePositionData, int employeeID, CancellationToken cancellationToken)
        {
            var currentPosition = await _dataContext.EmployeePositions.Where(ep => ep.EmployeeID == employeeID && ep.Status == StatusEnum.Active).FirstOrDefaultAsync(cancellationToken);

            if (currentPosition != null) 
            {
                currentPosition.Status = StatusEnum.Inactive;

                await _dataContext.SaveChangesAsync(cancellationToken);
            }

            var newPosition = new EmployeePosition
            {
                EmployeeID = employeeID,
                PositionID = employeePositionData.PositionID,
                Status = StatusEnum.Active,
                EffectiveDate = DateTime.Now
            };

            _dataContext.EmployeePositions.Add(newPosition);
            await _dataContext.SaveChangesAsync(cancellationToken);
        }
    }
}
