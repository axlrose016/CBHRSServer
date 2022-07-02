using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AXLSmartWebAPI.Migrations
{
    public partial class pes11_add_11132021 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PES11s",
                columns: table => new
                {
                    pes11Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    personId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    deleted_date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    is_deleted = table.Column<bool>(type: "bit", nullable: true),
                    immediateSupervisor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    immediateSupPosition = table.Column<int>(type: "int", nullable: true),
                    reviewPeriod = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    scr_diverseInfo = table.Column<int>(type: "int", nullable: true),
                    scr_researchesData = table.Column<int>(type: "int", nullable: true),
                    scr_usesIntuition = table.Column<int>(type: "int", nullable: true),
                    scr_identifiesData = table.Column<int>(type: "int", nullable: true),
                    scr_designsWorkflows = table.Column<int>(type: "int", nullable: true),
                    scr_volunteersReadily = table.Column<int>(type: "int", nullable: true),
                    scr_undertakeSelfDev = table.Column<int>(type: "int", nullable: true),
                    scr_seekIncResponsibilities = table.Column<int>(type: "int", nullable: true),
                    scr_takeIndActions = table.Column<int>(type: "int", nullable: true),
                    scr_takesAdvantage = table.Column<int>(type: "int", nullable: true),
                    scr_askForHelp = table.Column<int>(type: "int", nullable: true),
                    scr_creativity = table.Column<int>(type: "int", nullable: true),
                    scr_resourceful = table.Column<int>(type: "int", nullable: true),
                    scr_improveWork = table.Column<int>(type: "int", nullable: true),
                    scr_devInnovateIdeas = table.Column<int>(type: "int", nullable: true),
                    scr_competent = table.Column<int>(type: "int", nullable: true),
                    scr_exhibitAbility = table.Column<int>(type: "int", nullable: true),
                    scr_keepsAbreast = table.Column<int>(type: "int", nullable: true),
                    scr_minimalSupervision = table.Column<int>(type: "int", nullable: true),
                    scr_displaysUnderstanding = table.Column<int>(type: "int", nullable: true),
                    scr_usesResources = table.Column<int>(type: "int", nullable: true),
                    scr_plansWorkAct = table.Column<int>(type: "int", nullable: true),
                    scr_usesTimeEff = table.Column<int>(type: "int", nullable: true),
                    scr_plansForAddResources = table.Column<int>(type: "int", nullable: true),
                    scr_integratesChanges = table.Column<int>(type: "int", nullable: true),
                    scr_setsGoals = table.Column<int>(type: "int", nullable: true),
                    scr_worksOrganizedManner = table.Column<int>(type: "int", nullable: true),
                    scr_balancesTeam = table.Column<int>(type: "int", nullable: true),
                    scr_exhibitsObjective = table.Column<int>(type: "int", nullable: true),
                    scr_welcomesFeedback = table.Column<int>(type: "int", nullable: true),
                    scr_contribute = table.Column<int>(type: "int", nullable: true),
                    scr_putsSuccess = table.Column<int>(type: "int", nullable: true),
                    scr_expressesIdeas = table.Column<int>(type: "int", nullable: true),
                    scr_writesClearly = table.Column<int>(type: "int", nullable: true),
                    scr_exhibitsGoodListening = table.Column<int>(type: "int", nullable: true),
                    scr_keepsOtherAdequate = table.Column<int>(type: "int", nullable: true),
                    scr_usesAppCom = table.Column<int>(type: "int", nullable: true),
                    scr_presenDataEff = table.Column<int>(type: "int", nullable: true),
                    scr_courtesy = table.Column<int>(type: "int", nullable: true),
                    scr_humanRelations = table.Column<int>(type: "int", nullable: true),
                    scr_integrity = table.Column<int>(type: "int", nullable: true),
                    scr_stressTolerance = table.Column<int>(type: "int", nullable: true),
                    scr_complianceToOffice = table.Column<int>(type: "int", nullable: true),
                    scr_punctuality = table.Column<int>(type: "int", nullable: true),
                    grandTotal = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    avgPoint = table.Column<decimal>(type: "decimal(18,2)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PES11s", x => x.pes11Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PES11s");
        }
    }
}
