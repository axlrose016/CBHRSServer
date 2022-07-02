using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AXLSmartWebAPI.Migrations
{
    public partial class _05032022Add_AppointmentDetails : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AppointmentDetails",
                columns: table => new
                {
                    appointmentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    personId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    finalRating = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    is_renew_contract = table.Column<bool>(type: "bit", nullable: false),
                    changePersonStatus = table.Column<int>(type: "int", nullable: false),
                    existingSalaryGrade = table.Column<int>(type: "int", nullable: false),
                    proposedSalaryGrade = table.Column<int>(type: "int", nullable: false),
                    employeeEmailAdrs = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    wapRating = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    performanceEval = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    has_case_offense = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppointmentDetails", x => x.appointmentId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AppointmentDetails");
        }
    }
}
