using Microsoft.EntityFrameworkCore.Migrations;

namespace AXLSmartWebAPI.Migrations
{
    public partial class _06182022 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "JobClassifications",
                columns: table => new
                {
                    jobClassificationId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    occupationalServCode = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    occupationalDesc = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    occupationalGrpCode = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    occupationalGrpDesc = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    classCode = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    classDesc = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    salary_grade = table.Column<int>(type: "int", nullable: false),
                    is_active = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobClassifications", x => x.jobClassificationId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "JobClassifications");
        }
    }
}
