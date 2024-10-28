using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PauloOlivo_ExamenP1.Migrations
{
    /// <inheritdoc />
    public partial class Inicio : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PO_Tablita",
                columns: table => new
                {
                    PO_TablitaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PO_Tabla = table.Column<float>(type: "real", nullable: false),
                    PO_Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PO_Apellido = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    PO_Precio = table.Column<bool>(type: "bit", nullable: false),
                    PO_Fecha = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PO_Tablita", x => x.PO_TablitaId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PO_Tablita");
        }
    }
}
