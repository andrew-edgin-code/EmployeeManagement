using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EmployeeManagement.Migrations
{
    /// <inheritdoc />
    public partial class DropEmployeePositionAndRateEntity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EmployeePositionRates");

            migrationBuilder.DropTable(
                name: "EmployeePositions");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EmployeePositions",
                columns: table => new
                {
                    EmployeePositionID = table.Column<int>(type: "int", nullable: false),
                    EmployeeID = table.Column<int>(type: "int", nullable: false),
                    PositionID = table.Column<int>(type: "int", nullable: false),
                    EffectiveDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeePositions", x => new { x.EmployeePositionID, x.EmployeeID, x.PositionID });
                    table.UniqueConstraint("AK_EmployeePositions_EmployeePositionID", x => x.EmployeePositionID);
                    table.ForeignKey(
                        name: "FK_EmployeePositions_Employees_EmployeeID",
                        column: x => x.EmployeeID,
                        principalTable: "Employees",
                        principalColumn: "EmployeeID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_EmployeePositions_Positions_PositionID",
                        column: x => x.PositionID,
                        principalTable: "Positions",
                        principalColumn: "PositionID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "EmployeePositionRates",
                columns: table => new
                {
                    EmployeePositionRateID = table.Column<int>(type: "int", nullable: false),
                    EmployeePositionID = table.Column<int>(type: "int", nullable: false),
                    Rate = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeePositionRates", x => new { x.EmployeePositionRateID, x.EmployeePositionID });
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

            migrationBuilder.CreateIndex(
                name: "IX_EmployeePositions_EmployeeID",
                table: "EmployeePositions",
                column: "EmployeeID");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeePositions_PositionID",
                table: "EmployeePositions",
                column: "PositionID");
        }
    }
}
