using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjetoBlueModas.Migrations
{
    public partial class OrganizandoCesta : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cesta_Produtos_ProdutoId",
                table: "Cesta");

            migrationBuilder.AlterColumn<int>(
                name: "ProdutoId",
                table: "Cesta",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Cesta_Produtos_ProdutoId",
                table: "Cesta",
                column: "ProdutoId",
                principalTable: "Produtos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cesta_Produtos_ProdutoId",
                table: "Cesta");

            migrationBuilder.AlterColumn<int>(
                name: "ProdutoId",
                table: "Cesta",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Cesta_Produtos_ProdutoId",
                table: "Cesta",
                column: "ProdutoId",
                principalTable: "Produtos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
