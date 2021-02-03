using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjetoBlueModas.Migrations
{
    public partial class OrganizandoHistorico4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "QuantidadeMaximaProduto",
                table: "Historico");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "QuantidadeMaximaProduto",
                table: "Historico",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
