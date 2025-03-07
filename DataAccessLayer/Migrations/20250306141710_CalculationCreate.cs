using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    public partial class CalculationCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CarbonFootprintCalculations",
                columns: table => new
                {
                    FootprintId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ElectricityConsumption = table.Column<double>(type: "float", nullable: false),
                    ElectricitySource = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NaturalGasConsumption = table.Column<double>(type: "float", nullable: false),
                    CarFuelConsumption = table.Column<double>(type: "float", nullable: false),
                    CarFuelType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OtherEmissions = table.Column<double>(type: "float", nullable: false),
                    TotalFootprint = table.Column<double>(type: "float", nullable: false),
                    CalculationDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarbonFootprintCalculations", x => x.FootprintId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CarbonFootprintCalculations");
        }
    }
}
