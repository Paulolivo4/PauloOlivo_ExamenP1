using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PauloOlivo_ExamenP1.Migrations
{
    /// <inheritdoc />
    public partial class Prueba2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PO_Nombre",
                table: "PO_Tablita");

            migrationBuilder.AlterColumn<string>(
                name: "PO_Apellido",
                table: "PO_Tablita",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PO_Apellido2",
                table: "PO_Tablita",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PO_Apellido2",
                table: "PO_Tablita");

            migrationBuilder.AlterColumn<string>(
                name: "PO_Apellido",
                table: "PO_Tablita",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PO_Nombre",
                table: "PO_Tablita",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
