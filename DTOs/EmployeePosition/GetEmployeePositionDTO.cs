using EmployeeManagement.Models.Enums;

namespace EmployeeManagement.DTOs.EmployeePosition
{
    public class GetEmployeePositionDTO
    {
        public int EmployeeID { get; set; }
        public int PositionID { get; set; }
        public StatusEnum Status { get; set; }
        public DateTime EffectiveDate { get; set; }
        public decimal Rate { get; set; }
    }
}
