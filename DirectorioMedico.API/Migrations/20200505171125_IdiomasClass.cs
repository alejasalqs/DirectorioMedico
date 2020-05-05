using Microsoft.EntityFrameworkCore.Migrations;

namespace DirectorioMedico.API.Migrations
{
    public partial class IdiomasClass : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Genero",
                table: "Doctores",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Idioma",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    estado = table.Column<bool>(nullable: false),
                    Descripcion = table.Column<string>(nullable: false),
                    DoctorID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Idioma", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Idioma_Doctores_DoctorID",
                        column: x => x.DoctorID,
                        principalTable: "Doctores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Idioma_DoctorID",
                table: "Idioma",
                column: "DoctorID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Idioma");

            migrationBuilder.DropColumn(
                name: "Genero",
                table: "Doctores");
        }
    }
}
