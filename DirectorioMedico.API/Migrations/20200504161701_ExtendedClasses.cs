using Microsoft.EntityFrameworkCore.Migrations;

namespace DirectorioMedico.API.Migrations
{
    public partial class ExtendedClasses : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Labores",
                table: "Experiencia",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Descripcion",
                table: "Estudios",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Precio",
                table: "Doctores",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "SobreMi",
                table: "Doctores",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Labores",
                table: "Experiencia");

            migrationBuilder.DropColumn(
                name: "Descripcion",
                table: "Estudios");

            migrationBuilder.DropColumn(
                name: "Precio",
                table: "Doctores");

            migrationBuilder.DropColumn(
                name: "SobreMi",
                table: "Doctores");
        }
    }
}
