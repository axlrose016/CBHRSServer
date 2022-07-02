using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AXLSmartWebAPI.Migrations
{
    public partial class _06192022modified6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_WorkplaceAppicationPlans_PersonDetails_personDetailspersonId",
                table: "WorkplaceAppicationPlans");

            migrationBuilder.DropIndex(
                name: "IX_WorkplaceAppicationPlans_personDetailspersonId",
                table: "WorkplaceAppicationPlans");

            migrationBuilder.DropColumn(
                name: "personDetailspersonId",
                table: "WorkplaceAppicationPlans");

            migrationBuilder.AddColumn<Guid>(
                name: "personId",
                table: "WorkplaceAppicationPlans",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "personId",
                table: "WorkplaceAppicationPlans");

            migrationBuilder.AddColumn<Guid>(
                name: "personDetailspersonId",
                table: "WorkplaceAppicationPlans",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_WorkplaceAppicationPlans_personDetailspersonId",
                table: "WorkplaceAppicationPlans",
                column: "personDetailspersonId");

            migrationBuilder.AddForeignKey(
                name: "FK_WorkplaceAppicationPlans_PersonDetails_personDetailspersonId",
                table: "WorkplaceAppicationPlans",
                column: "personDetailspersonId",
                principalTable: "PersonDetails",
                principalColumn: "personId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
