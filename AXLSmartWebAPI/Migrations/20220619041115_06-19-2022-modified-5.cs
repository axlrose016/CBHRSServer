using Microsoft.EntityFrameworkCore.Migrations;

namespace AXLSmartWebAPI.Migrations
{
    public partial class _06192022modified5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_WorkplaceAppicationPlans_PersonDetails_personDetailpersonId",
                table: "WorkplaceAppicationPlans");

            migrationBuilder.RenameColumn(
                name: "personDetailpersonId",
                table: "WorkplaceAppicationPlans",
                newName: "personDetailspersonId");

            migrationBuilder.RenameIndex(
                name: "IX_WorkplaceAppicationPlans_personDetailpersonId",
                table: "WorkplaceAppicationPlans",
                newName: "IX_WorkplaceAppicationPlans_personDetailspersonId");

            migrationBuilder.AddForeignKey(
                name: "FK_WorkplaceAppicationPlans_PersonDetails_personDetailspersonId",
                table: "WorkplaceAppicationPlans",
                column: "personDetailspersonId",
                principalTable: "PersonDetails",
                principalColumn: "personId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_WorkplaceAppicationPlans_PersonDetails_personDetailspersonId",
                table: "WorkplaceAppicationPlans");

            migrationBuilder.RenameColumn(
                name: "personDetailspersonId",
                table: "WorkplaceAppicationPlans",
                newName: "personDetailpersonId");

            migrationBuilder.RenameIndex(
                name: "IX_WorkplaceAppicationPlans_personDetailspersonId",
                table: "WorkplaceAppicationPlans",
                newName: "IX_WorkplaceAppicationPlans_personDetailpersonId");

            migrationBuilder.AddForeignKey(
                name: "FK_WorkplaceAppicationPlans_PersonDetails_personDetailpersonId",
                table: "WorkplaceAppicationPlans",
                column: "personDetailpersonId",
                principalTable: "PersonDetails",
                principalColumn: "personId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
