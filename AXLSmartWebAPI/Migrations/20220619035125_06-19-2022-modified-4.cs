using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AXLSmartWebAPI.Migrations
{
    public partial class _06192022modified4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "personDetailpersonId",
                table: "WorkplaceAppicationPlans",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_WorkplaceAppicationPlans_personDetailpersonId",
                table: "WorkplaceAppicationPlans",
                column: "personDetailpersonId");

            migrationBuilder.AddForeignKey(
                name: "FK_WorkplaceAppicationPlans_PersonDetails_personDetailpersonId",
                table: "WorkplaceAppicationPlans",
                column: "personDetailpersonId",
                principalTable: "PersonDetails",
                principalColumn: "personId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_WorkplaceAppicationPlans_PersonDetails_personDetailpersonId",
                table: "WorkplaceAppicationPlans");

            migrationBuilder.DropIndex(
                name: "IX_WorkplaceAppicationPlans_personDetailpersonId",
                table: "WorkplaceAppicationPlans");

            migrationBuilder.DropColumn(
                name: "personDetailpersonId",
                table: "WorkplaceAppicationPlans");
        }
    }
}
