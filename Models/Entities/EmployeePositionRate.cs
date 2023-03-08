using EmployeeManagement.Models.Enums;

namespace EmployeeManagement.Models.Entities
{
    public class EmployeePositionRate
    {
        public int EmployeePositionRateID { get; set; }
        public int EmployeePositionID { get; set; }

        public decimal Rate { get; set; }

        public EmployeePosition EmployeePosition { get; set; }
    }
}
