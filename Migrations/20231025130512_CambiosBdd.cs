using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AlexCaicedoRams_Examen1P.Migrations
{
    public partial class CambiosBdd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AlexCaicedo_Tabla",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AcCedula = table.Column<int>(type: "int", maxLength: 12, nullable: false),
                    AcNombre = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    AcApellido = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    AcMayordeEdad = table.Column<bool>(type: "bit", nullable: false),
                    AcIngresos = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    AcFechaNacimiento = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AlexCaicedo_Tabla", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AlexCaicedo_Tabla");
        }
    }
}
