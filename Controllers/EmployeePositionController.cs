﻿using EmployeeManagement.DTOs.EmployeePosition;
using EmployeeManagement.Services.Implementations;
using EmployeeManagement.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeManagement.Controllers
{
    [Route("api/employee/{employeeID}/employee-position")]
    [ApiController]
    public class EmployeePositionController : ControllerBase
    {
        private readonly IEmployeePositionService _employeePositionService;

        public EmployeePositionController(IEmployeePositionService employeePositionService)
        {
            _employeePositionService = employeePositionService;
        }

        [HttpGet]
        public async Task<IActionResult> GetCurrentPosition(int employeeID, CancellationToken cancellationToken)
        {
            return Ok(await _employeePositionService.GetCurrentPosition(employeeID, cancellationToken));
        }

        [HttpPost]
        public async Task CreateEmployeePosition([FromBody] CreateEmployeePositionDTO employeePositionData, int employeeID, CancellationToken cancellationToken)
        {
            await _employeePositionService.CreateEmployeePosition(employeePositionData, employeeID, cancellationToken);
        }

        [HttpPatch("rate")]
        public async Task UpdateEmployeePositionRate([FromBody] UpdateEmployeePositionRateDTO employeePositionData, int employeeID, CancellationToken cancellationToken)
        {
            await _employeePositionService.UpdateEmployeePositionRate(employeePositionData, employeeID, cancellationToken);
        }
    }
}
