using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AXLSmartWebAPI.Migrations
{
    public partial class Clearance_10232021 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clearances",
                columns: table => new
                {
                    clearanceId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    dateOfApplication = table.Column<DateTime>(type: "datetime2", nullable: true),
                    isTransfer = table.Column<bool>(type: "bit", nullable: true),
                    isRetirement = table.Column<bool>(type: "bit", nullable: true),
                    isResignation = table.Column<bool>(type: "bit", nullable: true),
                    isLeave = table.Column<bool>(type: "bit", nullable: true),
                    isOther = table.Column<bool>(type: "bit", nullable: true),
                    specifyOther = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    effectivityInclusivePeriod = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    immediateSupervisor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    divisionHead = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    withPendingAdminCase = table.Column<bool>(type: "bit", nullable: true),
                    withOnGoingInvestigation = table.Column<bool>(type: "bit", nullable: true),
                    personDetailspersonId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    deleted_by = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    deleted_date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    is_deleted = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clearances", x => x.clearanceId);
                    table.ForeignKey(
                        name: "FK_Clearances_PersonDetails_personDetailspersonId",
                        column: x => x.personDetailspersonId,
                        principalTable: "PersonDetails",
                        principalColumn: "personId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Clearances_personDetailspersonId",
                table: "Clearances",
                column: "personDetailspersonId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Clearances");
        }
    }
}
