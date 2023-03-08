using EmployeeManagement.Models.Enums;

namespace EmployeeManagement.Models.Entities
{
    public class EmployeePosition
    {
        public int EmployeePositionID { get; set; }
        public int EmployeeID { get; set; }
        public int PositionID { get; set; }

        public StatusEnum Status { get; set; }
        public DateTime EffectiveDate { get; set; }


        public Employee Employee { get; set; }
        public Position Position { get; set; }
        public List<EmployeePositionRate> EmployeePositionRates { get; set; }
    }
}
