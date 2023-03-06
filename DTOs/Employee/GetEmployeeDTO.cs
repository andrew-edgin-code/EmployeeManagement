using EmployeeManagement.Models.Enums;

namespace EmployeeManagement.DTOs.Employee
{   
    public class GetEmployeeDTO
    {
        public int EmployeeID { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string StreetAddress { get; set; }
        public string City { get; set; }
        public StateEnum State { get; set; }
        public string PostalCode { get; set; }
        public string SocialSecurityNumber { get; set; }
        public DateTime BirthDate { get; set; }
        public MaritalStatus MaritalStatus { get; set; }
    }
}
