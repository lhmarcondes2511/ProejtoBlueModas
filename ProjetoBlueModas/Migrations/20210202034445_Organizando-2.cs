using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjetoBlueModas.Migrations
{
    public partial class Organizando2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Protocolo",
                table: "Historico");

            migrationBuilder.AddColumn<int>(
                name: "Protocolo",
                table: "Clientes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Protocolo",
                table: "Cesta",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Protocolo",
                table: "Clientes");

            migrationBuilder.DropColumn(
                name: "Protocolo",
                table: "Cesta");

            migrationBuilder.AddColumn<int>(
                name: "Protocolo",
                table: "Historico",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
