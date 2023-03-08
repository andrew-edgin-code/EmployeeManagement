using EmployeeManagement.Data;
using EmployeeManagement.DTOs.Employee;
using EmployeeManagement.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace EmployeeManagement.Repositories
{
    public class EmployeeEmergencyContactRepository
    {
        private readonly DataContext _dataContext;

        public EmployeeEmergencyContactRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public async Task<IEnumerable<GetEmergencyContactDTO>> GetAllEmergencyContacts(int employeeID, CancellationToken cancellationToken)
        {
            return await _dataContext.EmployeeEmergencyContacts
            .Where(eec => eec.EmployeeID == employeeID)
            .Select(eec => new GetEmergencyContactDTO
            {
                Name = eec.Name,
                Relationship = eec.Relationship,
                PhoneNumber = eec.PhoneNumber,
                StreetAddress = eec.StreetAddress,
                City = eec.City,
                State = eec.State,
                ZipCode = eec.ZipCode
            }).ToListAsync(cancellationToken);
        }

        public async Task<GetEmergencyContactDTO> GetEmergencyContact(int employeeEmergencyContactID, CancellationToken cancellationToken)
        {
            return await _dataContext.EmployeeEmergencyContacts
            .Where(eec => eec.EmployeeEmergencyContactID == employeeEmergencyContactID)
            .Select(eec => new GetEmergencyContactDTO
            {
                Name = eec.Name,
                Relationship = eec.Relationship,
                PhoneNumber = eec.PhoneNumber,
                StreetAddress = eec.StreetAddress,
                City = eec.City,
                State = eec.State,
                ZipCode = eec.ZipCode
            }).FirstOrDefaultAsync(cancellationToken);
        }

        public async Task CreateEmergencyContact(UpdateEmergencyContactDTO emergencyContactData, CancellationToken cancellationToken)
        {
            var newEmergencyContact = new EmployeeEmergencyContact
            {
                Name = emergencyContactData.Name,
                Relationship = emergencyContactData.Relationship,
                PhoneNumber = emergencyContactData.PhoneNumber,
                StreetAddress= emergencyContactData.StreetAddress,
                City = emergencyContactData.City,
                State = emergencyContactData.State,
                ZipCode= emergencyContactData.ZipCode
            };

            _dataContext.EmployeeEmergencyContacts.Add(newEmergencyContact);
            await _dataContext.SaveChangesAsync(cancellationToken);
        }

        public async Task UpdateEmergencyContact(UpdateEmergencyContactDTO emergencyContactData, int employeeEmergencyContactID, CancellationToken cancellationToken)
        {
            var emergencyContact = await _dataContext.EmployeeEmergencyContacts.Where(eec => eec.EmployeeEmergencyContactID == employeeEmergencyContactID).FirstOrDefaultAsync(cancellationToken);

            emergencyContact.Name = emergencyContactData.Name;
            emergencyContact.Relationship = emergencyContactData.Relationship;
            emergencyContact.PhoneNumber = emergencyContactData.PhoneNumber;
            emergencyContact.StreetAddress = emergencyContactData.StreetAddress;
            emergencyContact.City = emergencyContactData.City;
            emergencyContact.State = emergencyContactData.State;
            emergencyContact.ZipCode = emergencyContactData.ZipCode;
        }

        public async Task DeleteEmergencyContact(int employeeEmergencyContactID, CancellationToken cancellationToken)
        {
            var emergencyContact = await _dataContext.EmployeeEmergencyContacts.Where(eec => eec.EmployeeEmergencyContactID == employeeEmergencyContactID).FirstOrDefaultAsync(cancellationToken);

            _dataContext.EmployeeEmergencyContacts.Remove(emergencyContact);
            await _dataContext.SaveChangesAsync(cancellationToken);
        }
    }
}
