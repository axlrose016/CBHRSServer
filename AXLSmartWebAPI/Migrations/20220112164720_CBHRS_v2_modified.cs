using Microsoft.EntityFrameworkCore.Migrations;

namespace AXLSmartWebAPI.Migrations
{
    public partial class CBHRS_v2_modified : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ProposedNosPersonnelNextYrPlantil",
                table: "HRStaffingPlanDetails",
                newName: "proposedNosPersonnelNextYrPlantil");

            migrationBuilder.RenameColumn(
                name: "ProposedNosPersonnelNextYrJO",
                table: "HRStaffingPlanDetails",
                newName: "proposedNosPersonnelNextYrJO");

            migrationBuilder.RenameColumn(
                name: "NosUnfilledPosPlantil",
                table: "HRStaffingPlanDetails",
                newName: "nosUnfilledPosPlantil");

            migrationBuilder.RenameColumn(
                name: "NosUnfilledPosJO",
                table: "HRStaffingPlanDetails",
                newName: "nosUnfilledPosJO");

            migrationBuilder.RenameColumn(
                name: "NosProposedPosToChangePlantil",
                table: "HRStaffingPlanDetails",
                newName: "nosProposedPosToChangePlantil");

            migrationBuilder.RenameColumn(
                name: "NosProposedPosToChangeJO",
                table: "HRStaffingPlanDetails",
                newName: "nosProposedPosToChangeJO");

            migrationBuilder.RenameColumn(
                name: "NosFilledPosPlantil",
                table: "HRStaffingPlanDetails",
                newName: "nosFilledPosPlantil");

            migrationBuilder.RenameColumn(
                name: "NosFilledPosJO",
                table: "HRStaffingPlanDetails",
                newName: "nosFilledPosJO");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "proposedNosPersonnelNextYrPlantil",
                table: "HRStaffingPlanDetails",
                newName: "ProposedNosPersonnelNextYrPlantil");

            migrationBuilder.RenameColumn(
                name: "proposedNosPersonnelNextYrJO",
                table: "HRStaffingPlanDetails",
                newName: "ProposedNosPersonnelNextYrJO");

            migrationBuilder.RenameColumn(
                name: "nosUnfilledPosPlantil",
                table: "HRStaffingPlanDetails",
                newName: "NosUnfilledPosPlantil");

            migrationBuilder.RenameColumn(
                name: "nosUnfilledPosJO",
                table: "HRStaffingPlanDetails",
                newName: "NosUnfilledPosJO");

            migrationBuilder.RenameColumn(
                name: "nosProposedPosToChangePlantil",
                table: "HRStaffingPlanDetails",
                newName: "NosProposedPosToChangePlantil");

            migrationBuilder.RenameColumn(
                name: "nosProposedPosToChangeJO",
                table: "HRStaffingPlanDetails",
                newName: "NosProposedPosToChangeJO");

            migrationBuilder.RenameColumn(
                name: "nosFilledPosPlantil",
                table: "HRStaffingPlanDetails",
                newName: "NosFilledPosPlantil");

            migrationBuilder.RenameColumn(
                name: "nosFilledPosJO",
                table: "HRStaffingPlanDetails",
                newName: "NosFilledPosJO");
        }
    }
}
