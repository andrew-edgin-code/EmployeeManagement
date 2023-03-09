using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EmployeeManagement.Migrations
{
    /// <inheritdoc />
    public partial class ReaddRatesEntityWithNewKey : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EmployeePositionRates",
                columns: table => new
                {
                    EmployeePositionRateID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeePositionID = table.Column<int>(type: "int", nullable: false),
                    Rate = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeePositionRates", x => x.EmployeePositionRateID);
                    table.ForeignKey(
                        name: "FK_EmployeePositionRates_EmployeePositions_EmployeePositionID",
                        column: x => x.EmployeePositionID,
                        principalTable: "EmployeePositions",
                        principalColumn: "EmployeePositionID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_EmployeePositionRates_EmployeePositionID",
                table: "EmployeePositionRates",
                column: "EmployeePositionID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EmployeePositionRates");
        }
    }
}
