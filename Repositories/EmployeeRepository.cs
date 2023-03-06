using EmployeeManagement.Data;
using EmployeeManagement.DTOs.Employee;
using Microsoft.EntityFrameworkCore;

namespace EmployeeManagement.Repositories
{
    public class EmployeeRepository
    {
        private readonly DataContext _dataContext;

        public EmployeeRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public async Task<IEnumerable<GetAllEmployeesDTO>> GetAllEmployees(CancellationToken cancellationToken)
        {
            return await _dataContext.Employees.Select(e => new GetAllEmployeesDTO
            {
                EmployeeID = e.EmployeeID,
                Name = $"{e.FirstName} {e.LastName}",
                Email = e.Email,
                PhoneNumber = e.PhoneNumber
            }).ToListAsync(cancellationToken);
        }

        public async Task<GetEmployeeDTO> GetEmployee(int employeeID, CancellationToken cancellationToken)
        {
            try
            {
                return await _dataContext.Employees
                .Where(e => e.EmployeeID == employeeID)
                .Select(e => new GetEmployeeDTO
                {
                    EmployeeID = e.EmployeeID,
                    Name = $"{e.FirstName} {e.LastName}",
                    Email = e.Email,
                    PhoneNumber = e.PhoneNumber,
                    StreetAddress = e.StreetAddress,
                    City = e.City,
                    State = e.State,
                    PostalCode = e.PostalCode,
                    SocialSecurityNumber = e.SocialSecurityNumber,
                    BirthDate = e.BirthDate,
                    MaritalStatus = e.MaritalStatus
                }).FirstOrDefaultAsync(cancellationToken);
            }
            catch (Exception ex)
            {
                throw new Exception("FUCK");
            }
        }
    }
}
