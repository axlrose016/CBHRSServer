using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AXLSmartWebAPI.Migrations
{
    public partial class CBHRS_v2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BudgetUtilizationDetails",
                columns: table => new
                {
                    budgetUtilId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    totalBudgetJO = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    totalBudgetPlantil = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    amountSpentQ1JO = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    amountSpentQ1Plantil = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    amountSpentQ2JO = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    amountSpentQ2Plantil = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    amountSpentQ3JO = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    amountSpentQ3Plantil = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    amountSpentQ4JO = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    amountSpentQ4Plantil = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    is_funding_set_aside = table.Column<bool>(type: "bit", nullable: false),
                    with_last_year_proposed_budget = table.Column<int>(type: "int", nullable: false),
                    with_additional_proposed_budget = table.Column<int>(type: "int", nullable: false),
                    deleted_by = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    deleted_date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    is_deleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BudgetUtilizationDetails", x => x.budgetUtilId);
                });

            migrationBuilder.CreateTable(
                name: "ComplaintDetails",
                columns: table => new
                {
                    complaintId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    officeId = table.Column<int>(type: "int", nullable: false),
                    personDetailspersonId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    typeOfComplaint = table.Column<int>(type: "int", nullable: false),
                    grievanceDetails = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    complaineeDetailspersonId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    emailAddressComplainant = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    emailAddressSupervisor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    deleted_by = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    deleted_date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    is_deleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ComplaintDetails", x => x.complaintId);
                    table.ForeignKey(
                        name: "FK_ComplaintDetails_PersonDetails_complaineeDetailspersonId",
                        column: x => x.complaineeDetailspersonId,
                        principalTable: "PersonDetails",
                        principalColumn: "personId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ComplaintDetails_PersonDetails_personDetailspersonId",
                        column: x => x.personDetailspersonId,
                        principalTable: "PersonDetails",
                        principalColumn: "personId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "HRStaffingPlanDetails",
                columns: table => new
                {
                    hrStaffingId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    existingNosPersonnelJO = table.Column<int>(type: "int", nullable: false),
                    existingNosPersonnelPlantil = table.Column<int>(type: "int", nullable: false),
                    NosFilledPosJO = table.Column<int>(type: "int", nullable: false),
                    NosFilledPosPlantil = table.Column<int>(type: "int", nullable: false),
                    NosUnfilledPosJO = table.Column<int>(type: "int", nullable: false),
                    NosUnfilledPosPlantil = table.Column<int>(type: "int", nullable: false),
                    NosProposedPosToChangeJO = table.Column<int>(type: "int", nullable: false),
                    NosProposedPosToChangePlantil = table.Column<int>(type: "int", nullable: false),
                    ProposedNosPersonnelNextYrJO = table.Column<int>(type: "int", nullable: false),
                    ProposedNosPersonnelNextYrPlantil = table.Column<int>(type: "int", nullable: false),
                    deleted_by = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    deleted_date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    is_deleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HRStaffingPlanDetails", x => x.hrStaffingId);
                });

            migrationBuilder.CreateTable(
                name: "OrganizationalGoalDetails",
                columns: table => new
                {
                    orgGoalId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    mandateOfOffice = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    visionOfOffice = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    missionOfOffice = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    stratigicGoalsOfOffice = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    deleted_by = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    deleted_date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    is_deleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrganizationalGoalDetails", x => x.orgGoalId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ComplaintDetails_complaineeDetailspersonId",
                table: "ComplaintDetails",
                column: "complaineeDetailspersonId");

            migrationBuilder.CreateIndex(
                name: "IX_ComplaintDetails_personDetailspersonId",
                table: "ComplaintDetails",
                column: "personDetailspersonId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BudgetUtilizationDetails");

            migrationBuilder.DropTable(
                name: "ComplaintDetails");

            migrationBuilder.DropTable(
                name: "HRStaffingPlanDetails");

            migrationBuilder.DropTable(
                name: "OrganizationalGoalDetails");
        }
    }
}
