using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AXLSmartWebAPI.Migrations
{
    public partial class _06192022modified3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ApplicationPlanAndAccomplishments_WorkplaceAppicationPlans_WorkplaceAppicationPlanwapId",
                table: "ApplicationPlanAndAccomplishments");

            migrationBuilder.DropForeignKey(
                name: "FK_WorkplaceAppicationPlans_PersonDetails_PersonDetailspersonId",
                table: "WorkplaceAppicationPlans");

            migrationBuilder.DropIndex(
                name: "IX_WorkplaceAppicationPlans_PersonDetailspersonId",
                table: "WorkplaceAppicationPlans");

            migrationBuilder.DropIndex(
                name: "IX_ApplicationPlanAndAccomplishments_WorkplaceAppicationPlanwapId",
                table: "ApplicationPlanAndAccomplishments");

            migrationBuilder.DropColumn(
                name: "PersonDetailspersonId",
                table: "WorkplaceAppicationPlans");

            migrationBuilder.DropColumn(
                name: "WorkplaceAppicationPlanwapId",
                table: "ApplicationPlanAndAccomplishments");

            migrationBuilder.RenameColumn(
                name: "objective",
                table: "WorkplaceAppicationPlans",
                newName: "whatNeedsToBeDone");

            migrationBuilder.RenameColumn(
                name: "date_conduct",
                table: "WorkplaceAppicationPlans",
                newName: "deleted_date");

            migrationBuilder.RenameColumn(
                name: "alignment",
                table: "WorkplaceAppicationPlans",
                newName: "otherReason");

            migrationBuilder.AddColumn<DateTime>(
                name: "dateConduct",
                table: "WorkplaceAppicationPlans",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "deleted_by",
                table: "WorkplaceAppicationPlans",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "has_intervention_cos",
                table: "WorkplaceAppicationPlans",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "has_intervention_csp",
                table: "WorkplaceAppicationPlans",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "has_intervention_idp",
                table: "WorkplaceAppicationPlans",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "has_intervention_ipcr",
                table: "WorkplaceAppicationPlans",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "has_intervention_others",
                table: "WorkplaceAppicationPlans",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "has_intervention_wfp",
                table: "WorkplaceAppicationPlans",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "intervention_others",
                table: "WorkplaceAppicationPlans",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "is_deleted",
                table: "WorkplaceAppicationPlans",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "milestone",
                table: "WorkplaceAppicationPlans",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "mov",
                table: "WorkplaceAppicationPlans",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "objectives",
                table: "WorkplaceAppicationPlans",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "otherIntervention",
                table: "WorkplaceAppicationPlans",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "rating",
                table: "WorkplaceAppicationPlans",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "reasonForNonAccomplishment",
                table: "WorkplaceAppicationPlans",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "targetDays",
                table: "WorkplaceAppicationPlans",
                type: "int",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "dateConduct",
                table: "WorkplaceAppicationPlans");

            migrationBuilder.DropColumn(
                name: "deleted_by",
                table: "WorkplaceAppicationPlans");

            migrationBuilder.DropColumn(
                name: "has_intervention_cos",
                table: "WorkplaceAppicationPlans");

            migrationBuilder.DropColumn(
                name: "has_intervention_csp",
                table: "WorkplaceAppicationPlans");

            migrationBuilder.DropColumn(
                name: "has_intervention_idp",
                table: "WorkplaceAppicationPlans");

            migrationBuilder.DropColumn(
                name: "has_intervention_ipcr",
                table: "WorkplaceAppicationPlans");

            migrationBuilder.DropColumn(
                name: "has_intervention_others",
                table: "WorkplaceAppicationPlans");

            migrationBuilder.DropColumn(
                name: "has_intervention_wfp",
                table: "WorkplaceAppicationPlans");

            migrationBuilder.DropColumn(
                name: "intervention_others",
                table: "WorkplaceAppicationPlans");

            migrationBuilder.DropColumn(
                name: "is_deleted",
                table: "WorkplaceAppicationPlans");

            migrationBuilder.DropColumn(
                name: "milestone",
                table: "WorkplaceAppicationPlans");

            migrationBuilder.DropColumn(
                name: "mov",
                table: "WorkplaceAppicationPlans");

            migrationBuilder.DropColumn(
                name: "objectives",
                table: "WorkplaceAppicationPlans");

            migrationBuilder.DropColumn(
                name: "otherIntervention",
                table: "WorkplaceAppicationPlans");

            migrationBuilder.DropColumn(
                name: "rating",
                table: "WorkplaceAppicationPlans");

            migrationBuilder.DropColumn(
                name: "reasonForNonAccomplishment",
                table: "WorkplaceAppicationPlans");

            migrationBuilder.DropColumn(
                name: "targetDays",
                table: "WorkplaceAppicationPlans");

            migrationBuilder.RenameColumn(
                name: "whatNeedsToBeDone",
                table: "WorkplaceAppicationPlans",
                newName: "objective");

            migrationBuilder.RenameColumn(
                name: "otherReason",
                table: "WorkplaceAppicationPlans",
                newName: "alignment");

            migrationBuilder.RenameColumn(
                name: "deleted_date",
                table: "WorkplaceAppicationPlans",
                newName: "date_conduct");

            migrationBuilder.AddColumn<Guid>(
                name: "PersonDetailspersonId",
                table: "WorkplaceAppicationPlans",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "WorkplaceAppicationPlanwapId",
                table: "ApplicationPlanAndAccomplishments",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_WorkplaceAppicationPlans_PersonDetailspersonId",
                table: "WorkplaceAppicationPlans",
                column: "PersonDetailspersonId");

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationPlanAndAccomplishments_WorkplaceAppicationPlanwapId",
                table: "ApplicationPlanAndAccomplishments",
                column: "WorkplaceAppicationPlanwapId");

            migrationBuilder.AddForeignKey(
                name: "FK_ApplicationPlanAndAccomplishments_WorkplaceAppicationPlans_WorkplaceAppicationPlanwapId",
                table: "ApplicationPlanAndAccomplishments",
                column: "WorkplaceAppicationPlanwapId",
                principalTable: "WorkplaceAppicationPlans",
                principalColumn: "wapId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_WorkplaceAppicationPlans_PersonDetails_PersonDetailspersonId",
                table: "WorkplaceAppicationPlans",
                column: "PersonDetailspersonId",
                principalTable: "PersonDetails",
                principalColumn: "personId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
