using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjetoBlueModas.Migrations
{
    public partial class OrganizandoHistorico3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CodigoProduto",
                table: "Historico",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "EmailCliente",
                table: "Historico",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImagemProduto",
                table: "Historico",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NomeCategoria",
                table: "Historico",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NomeCliente",
                table: "Historico",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NomeProduto",
                table: "Historico",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "PrecoProduto",
                table: "Historico",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<int>(
                name: "QuantidadeCesta",
                table: "Historico",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "QuantidadeMaximaProduto",
                table: "Historico",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TelefoneCliente",
                table: "Historico",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CodigoProduto",
                table: "Historico");

            migrationBuilder.DropColumn(
                name: "EmailCliente",
                table: "Historico");

            migrationBuilder.DropColumn(
                name: "ImagemProduto",
                table: "Historico");

            migrationBuilder.DropColumn(
                name: "NomeCategoria",
                table: "Historico");

            migrationBuilder.DropColumn(
                name: "NomeCliente",
                table: "Historico");

            migrationBuilder.DropColumn(
                name: "NomeProduto",
                table: "Historico");

            migrationBuilder.DropColumn(
                name: "PrecoProduto",
                table: "Historico");

            migrationBuilder.DropColumn(
                name: "QuantidadeCesta",
                table: "Historico");

            migrationBuilder.DropColumn(
                name: "QuantidadeMaximaProduto",
                table: "Historico");

            migrationBuilder.DropColumn(
                name: "TelefoneCliente",
                table: "Historico");
        }
    }
}
