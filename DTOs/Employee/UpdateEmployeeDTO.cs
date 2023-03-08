using EmployeeManagement.Models.Enums;

namespace EmployeeManagement.DTOs.Employee
{
    public class UpdateEmployeeDTO
    {
        public int EmployeeID { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; } = string.Empty;
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string StreetAddress { get; set; }
        public string City { get; set; }
        public StateEnum State { get; set; }
        public string PostalCode { get; set; }
        public string SocialSecurityNumber { get; set; }
        public DateTime BirthDate { get; set; }
        public GenderEnum Gender { get; set; }
        public MaritalStatusEnum MaritalStatus { get; set; }
    }
}
