using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AXLSmartWebAPI.Migrations
{
    public partial class Modify_Clearance_10232021 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Clearances_PersonDetails_personDetailspersonId",
                table: "Clearances");

            migrationBuilder.DropIndex(
                name: "IX_Clearances_personDetailspersonId",
                table: "Clearances");

            migrationBuilder.DropColumn(
                name: "personDetailspersonId",
                table: "Clearances");

            migrationBuilder.AddColumn<Guid>(
                name: "personId",
                table: "Clearances",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "personId",
                table: "Clearances");

            migrationBuilder.AddColumn<Guid>(
                name: "personDetailspersonId",
                table: "Clearances",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Clearances_personDetailspersonId",
                table: "Clearances",
                column: "personDetailspersonId");

            migrationBuilder.AddForeignKey(
                name: "FK_Clearances_PersonDetails_personDetailspersonId",
                table: "Clearances",
                column: "personDetailspersonId",
                principalTable: "PersonDetails",
                principalColumn: "personId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
