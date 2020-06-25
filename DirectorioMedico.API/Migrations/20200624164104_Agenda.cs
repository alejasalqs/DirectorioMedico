using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DirectorioMedico.API.Migrations
{
    public partial class Agenda : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "SobreMi",
                table: "Doctores",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<int>(
                name: "AgendaId",
                table: "Doctores",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IdAgenda",
                table: "Doctores",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Locacion",
                table: "Doctores",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Agenda",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Evento = table.Column<string>(nullable: true),
                    EsTodoElDia = table.Column<bool>(nullable: false),
                    FechaInicio = table.Column<DateTime>(nullable: false),
                    FechaFin = table.Column<DateTime>(nullable: false),
                    Color = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Agenda", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Doctores_AgendaId",
                table: "Doctores",
                column: "AgendaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Doctores_Agenda_AgendaId",
                table: "Doctores",
                column: "AgendaId",
                principalTable: "Agenda",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Doctores_Agenda_AgendaId",
                table: "Doctores");

            migrationBuilder.DropTable(
                name: "Agenda");

            migrationBuilder.DropIndex(
                name: "IX_Doctores_AgendaId",
                table: "Doctores");

            migrationBuilder.DropColumn(
                name: "AgendaId",
                table: "Doctores");

            migrationBuilder.DropColumn(
                name: "IdAgenda",
                table: "Doctores");

            migrationBuilder.DropColumn(
                name: "Locacion",
                table: "Doctores");

            migrationBuilder.AlterColumn<string>(
                name: "SobreMi",
                table: "Doctores",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
