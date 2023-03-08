using EmployeeManagement.DTOs.Employee;
using Microsoft.AspNetCore.Mvc;
using PositionManagement.Services;

namespace PositionManagement.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PositionController : ControllerBase
    {
        private readonly PositionService _positionService;

        public PositionController(PositionService positionService)
        {
            _positionService = positionService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllPositions(CancellationToken cancellationToken)
        {
            return Ok(await _positionService.GetAllPositions(cancellationToken));
        }

        [HttpGet("{positionID}")]
        public async Task<IActionResult> GetPosition(int positionID, CancellationToken cancellationToken)
        {
            return Ok(await _positionService.GetPosition(positionID, cancellationToken));
        }

        [HttpPost]
        public async Task CreatePosition([FromBody] UpdatePositionDTO positionData, CancellationToken cancellationToken)
        {
            await _positionService.CreatePosition(positionData, cancellationToken);
        }

        [HttpPatch("{positionID}")]
        public async Task UpdatePosition([FromBody] UpdatePositionDTO positionData, int positionID, CancellationToken cancellationToken)
        {
            await _positionService.UpdatePosition(positionData, positionID, cancellationToken);
        }

        [HttpDelete("{positionID}")]
        public async Task DeletePosition(int positionID, CancellationToken cancellationToken)
        {
            await _positionService.DeletePosition(positionID, cancellationToken);
        }
    }
}
