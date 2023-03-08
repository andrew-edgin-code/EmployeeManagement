using EmployeeManagement.Models.Enums;

namespace EmployeeManagement.Models.Entities
{
    public class Employee
    {
        public int EmployeeID { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string MiddleName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string PhoneNumber { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string StreetAddress { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;
        public StateEnum State { get; set; }
        public string PostalCode { get; set; } = string.Empty;
        public DateTime BirthDate { get; set; }
        public string SocialSecurityNumber { get; set; } = string.Empty;
        public GenderEnum Gender { get; set; }
        public MaritalStatusEnum MaritalStatus { get; set; }

        public List<EmployeePosition>? EmployeePositions { get; set; }
        public List<EmployeeEmergencyContact>? EmployeeEmergencyContacts { get; set; }
    }
}
