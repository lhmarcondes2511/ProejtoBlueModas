using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjetoBlueModas.Migrations
{
    public partial class OrganizandoHistorico2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Protocolo",
                table: "Historico",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Protocolo",
                table: "Historico");
        }
    }
}
