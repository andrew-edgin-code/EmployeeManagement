using EmployeeManagement.Models.Enums;

namespace EmployeeManagement.DTOs.Employee
{
    public class UpdatePositionDTO
    {
        public int PositionID { get; set; }
        public string Title { get; set; }
        public string Code { get; set; }
    }
}
