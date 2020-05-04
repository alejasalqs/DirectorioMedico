using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DirectorioMedico.API.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Doctores",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(nullable: false),
                    Primer_apellido = table.Column<string>(nullable: false),
                    Segundo_apellido = table.Column<string>(nullable: true),
                    Correo = table.Column<string>(nullable: false),
                    Password = table.Column<string>(nullable: false),
                    Sitio_web = table.Column<string>(nullable: true),
                    Celular = table.Column<string>(nullable: true),
                    Telefono_oficina = table.Column<string>(nullable: true),
                    Estado = table.Column<bool>(nullable: false),
                    FechaCreacion = table.Column<DateTime>(nullable: false),
                    FechaUltimaActividad = table.Column<DateTime>(nullable: false),
                    FechaNacimiento = table.Column<DateTime>(nullable: false),
                    Foto = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Doctores", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Especialidades",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    descripcion = table.Column<string>(nullable: false),
                    estado = table.Column<bool>(nullable: false),
                    DoctorID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Especialidades", x => x.id);
                    table.ForeignKey(
                        name: "FK_Especialidades_Doctores_DoctorID",
                        column: x => x.DoctorID,
                        principalTable: "Doctores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Estudios",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    grado = table.Column<string>(nullable: false),
                    centro_estudios = table.Column<string>(nullable: false),
                    fecha_inicial = table.Column<DateTime>(nullable: false),
                    fecha_final = table.Column<DateTime>(nullable: false),
                    estado = table.Column<bool>(nullable: false),
                    DoctorID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Estudios", x => x.id);
                    table.ForeignKey(
                        name: "FK_Estudios_Doctores_DoctorID",
                        column: x => x.DoctorID,
                        principalTable: "Doctores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Experiencia",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    puesto = table.Column<string>(nullable: false),
                    lugar_trabajo = table.Column<string>(nullable: false),
                    fecha_inicial = table.Column<DateTime>(nullable: false),
                    fecha_final = table.Column<DateTime>(nullable: false),
                    estado = table.Column<bool>(nullable: false),
                    DoctorID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Experiencia", x => x.id);
                    table.ForeignKey(
                        name: "FK_Experiencia_Doctores_DoctorID",
                        column: x => x.DoctorID,
                        principalTable: "Doctores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RedesSociales",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descripcion = table.Column<string>(nullable: false),
                    Url = table.Column<string>(nullable: true),
                    DoctorID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RedesSociales", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RedesSociales_Doctores_DoctorID",
                        column: x => x.DoctorID,
                        principalTable: "Doctores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Especialidades_DoctorID",
                table: "Especialidades",
                column: "DoctorID");

            migrationBuilder.CreateIndex(
                name: "IX_Estudios_DoctorID",
                table: "Estudios",
                column: "DoctorID");

            migrationBuilder.CreateIndex(
                name: "IX_Experiencia_DoctorID",
                table: "Experiencia",
                column: "DoctorID");

            migrationBuilder.CreateIndex(
                name: "IX_RedesSociales_DoctorID",
                table: "RedesSociales",
                column: "DoctorID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Especialidades");

            migrationBuilder.DropTable(
                name: "Estudios");

            migrationBuilder.DropTable(
                name: "Experiencia");

            migrationBuilder.DropTable(
                name: "RedesSociales");

            migrationBuilder.DropTable(
                name: "Doctores");
        }
    }
}
