namespace EmployeeManagement.Models.Entities
{
    public class Position
    {
        public int PositionID { get; set; }
        public string Title { get; set; }
        public string Code { get; set; }

        public List<EmployeePosition>? EmployeePositions { get; set; }
    }
}
