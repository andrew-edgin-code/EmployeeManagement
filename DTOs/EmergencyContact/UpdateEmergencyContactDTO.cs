using EmployeeManagement.Models.Enums;

namespace EmployeeManagement.DTOs.Employee
{
    public class UpdateEmergencyContactDTO
    {
        public string Name { get; set; }
        public RelationshipEnum Relationship { get; set; }
        public string StreetAddress { get; set; }
        public string City { get; set; }
        public StateEnum State { get; set; }
        public string ZipCode { get; set; }
        public string PhoneNumber { get; set; }
    }
}
