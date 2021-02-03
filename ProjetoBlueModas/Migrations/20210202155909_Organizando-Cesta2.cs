using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjetoBlueModas.Migrations
{
    public partial class OrganizandoCesta2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Quantidade",
                table: "Produtos");

            migrationBuilder.AddColumn<int>(
                name: "Quantidade",
                table: "Cesta",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Quantidade",
                table: "Cesta");

            migrationBuilder.AddColumn<int>(
                name: "Quantidade",
                table: "Produtos",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
