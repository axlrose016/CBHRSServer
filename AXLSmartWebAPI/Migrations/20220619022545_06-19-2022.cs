using Microsoft.EntityFrameworkCore.Migrations;

namespace AXLSmartWebAPI.Migrations
{
    public partial class _06192022 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "classCode",
                table: "JobClassifications");

            migrationBuilder.DropColumn(
                name: "classDesc",
                table: "JobClassifications");

            migrationBuilder.DropColumn(
                name: "occupationalDesc",
                table: "JobClassifications");

            migrationBuilder.DropColumn(
                name: "occupationalGrpCode",
                table: "JobClassifications");

            migrationBuilder.DropColumn(
                name: "occupationalGrpDesc",
                table: "JobClassifications");

            migrationBuilder.AddColumn<int>(
                name: "numerical_suffix",
                table: "JobClassifications",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "numerical_suffix",
                table: "JobClassifications");

            migrationBuilder.AddColumn<string>(
                name: "classCode",
                table: "JobClassifications",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "classDesc",
                table: "JobClassifications",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "occupationalDesc",
                table: "JobClassifications",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "occupationalGrpCode",
                table: "JobClassifications",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "occupationalGrpDesc",
                table: "JobClassifications",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: true);
        }
    }
}
