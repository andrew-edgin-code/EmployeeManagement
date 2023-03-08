using EmployeeManagement.Models.Enums;

namespace EmployeeManagement.Models.Entities
{
    public class EmployeeEmergencyContact
    {
        public int EmployeeEmergencyContactID { get; set; }
        public int EmployeeID { get; set; }

        public string Name { get; set; }
        public RelationshipEnum Relationship { get; set; }
        public string StreetAddress { get; set; }
        public string City { get; set; }
        public StateEnum State { get; set; }
        public string ZipCode { get; set; }
        public string PhoneNumber { get; set; }

        public Employee Employee { get; set; }
    }
}
