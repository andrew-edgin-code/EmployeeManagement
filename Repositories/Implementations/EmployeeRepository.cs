using EmployeeManagement.Data;
using EmployeeManagement.DTOs.Employee;
using EmployeeManagement.Models.Entities;
using EmployeeManagement.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace EmployeeManagement.Repositories.Implementations
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly DataContext _dataContext;

        public EmployeeRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public async Task<IEnumerable<GetEmployeeDTO>> GetAllEmployees(CancellationToken cancellationToken)
        {
            return await _dataContext.Employees.Select(e => new GetEmployeeDTO
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
                Gender = e.Gender,
                MaritalStatus = e.MaritalStatus
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
                    Gender = e.Gender,
                    MaritalStatus = e.MaritalStatus
                }).FirstOrDefaultAsync(cancellationToken);
            }
            catch (Exception ex)
            {
                throw new Exception("FUCK");
            }
        }

        public async Task CreateEmployee(UpdateEmployeeDTO employeeData, CancellationToken cancellationToken)
        {
            var newEmployee = new Employee
            {
                FirstName = employeeData.FirstName,
                MiddleName = employeeData.MiddleName,
                LastName = employeeData.LastName,
                PhoneNumber = employeeData.PhoneNumber,
                Email = employeeData.Email,
                StreetAddress = employeeData.StreetAddress,
                City = employeeData.City,
                State = employeeData.State,
                PostalCode = employeeData.PostalCode,
                SocialSecurityNumber = employeeData.SocialSecurityNumber,
                BirthDate = employeeData.BirthDate,
                Gender = employeeData.Gender,
                MaritalStatus = employeeData.MaritalStatus
            };

            _dataContext.Employees.Add(newEmployee);
            await _dataContext.SaveChangesAsync(cancellationToken);
        }

        public async Task UpdateEmployee(UpdateEmployeeDTO employeeData, int employeeID, CancellationToken cancellationToken)
        {
            var employee = await _dataContext.Employees.Where(e => e.EmployeeID == employeeID).FirstOrDefaultAsync(cancellationToken);

            employee.FirstName = employeeData.FirstName;
            employee.MiddleName = employeeData.MiddleName;
            employee.LastName = employeeData.LastName;
            employee.PhoneNumber = employeeData.PhoneNumber;
            employee.Email = employeeData.Email;
            employee.StreetAddress = employeeData.StreetAddress;
            employee.City = employeeData.City;
            employee.State = employeeData.State;
            employee.PostalCode = employeeData.PostalCode;
            employee.SocialSecurityNumber = employeeData.SocialSecurityNumber;
            employee.BirthDate = employeeData.BirthDate;
            employee.Gender = employeeData.Gender;
            employee.MaritalStatus = employeeData.MaritalStatus;

            await _dataContext.SaveChangesAsync(cancellationToken);
        }

        public async Task DeleteEmployee(int employeeID, CancellationToken cancellationToken)
        {
            var employeeToDelete = await _dataContext.Employees.Where(e => e.EmployeeID == employeeID).FirstOrDefaultAsync(cancellationToken);

            _dataContext.Employees.Remove(employeeToDelete);
            await _dataContext.SaveChangesAsync(cancellationToken);
        }
    }
}
