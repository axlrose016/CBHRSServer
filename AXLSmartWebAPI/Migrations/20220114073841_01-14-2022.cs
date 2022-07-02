using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AXLSmartWebAPI.Migrations
{
    public partial class _01142022 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ComplaintDetails_PersonDetails_complaineeDetailspersonId",
                table: "ComplaintDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_ComplaintDetails_PersonDetails_personDetailspersonId",
                table: "ComplaintDetails");

            migrationBuilder.DropIndex(
                name: "IX_ComplaintDetails_complaineeDetailspersonId",
                table: "ComplaintDetails");

            migrationBuilder.DropIndex(
                name: "IX_ComplaintDetails_personDetailspersonId",
                table: "ComplaintDetails");

            migrationBuilder.DropColumn(
                name: "complaineeDetailspersonId",
                table: "ComplaintDetails");

            migrationBuilder.DropColumn(
                name: "personDetailspersonId",
                table: "ComplaintDetails");

            migrationBuilder.AddColumn<Guid>(
                name: "complaineeId",
                table: "ComplaintDetails",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<string>(
                name: "complaineeName",
                table: "ComplaintDetails",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "complaintName",
                table: "ComplaintDetails",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "personId",
                table: "ComplaintDetails",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "complaineeId",
                table: "ComplaintDetails");

            migrationBuilder.DropColumn(
                name: "complaineeName",
                table: "ComplaintDetails");

            migrationBuilder.DropColumn(
                name: "complaintName",
                table: "ComplaintDetails");

            migrationBuilder.DropColumn(
                name: "personId",
                table: "ComplaintDetails");

            migrationBuilder.AddColumn<Guid>(
                name: "complaineeDetailspersonId",
                table: "ComplaintDetails",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "personDetailspersonId",
                table: "ComplaintDetails",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_ComplaintDetails_complaineeDetailspersonId",
                table: "ComplaintDetails",
                column: "complaineeDetailspersonId");

            migrationBuilder.CreateIndex(
                name: "IX_ComplaintDetails_personDetailspersonId",
                table: "ComplaintDetails",
                column: "personDetailspersonId");

            migrationBuilder.AddForeignKey(
                name: "FK_ComplaintDetails_PersonDetails_complaineeDetailspersonId",
                table: "ComplaintDetails",
                column: "complaineeDetailspersonId",
                principalTable: "PersonDetails",
                principalColumn: "personId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ComplaintDetails_PersonDetails_personDetailspersonId",
                table: "ComplaintDetails",
                column: "personDetailspersonId",
                principalTable: "PersonDetails",
                principalColumn: "personId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
