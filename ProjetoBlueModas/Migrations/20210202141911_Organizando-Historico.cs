using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjetoBlueModas.Migrations
{
    public partial class OrganizandoHistorico : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Historico_Cesta_CestaId",
                table: "Historico");

            migrationBuilder.DropForeignKey(
                name: "FK_Historico_Clientes_ClienteId",
                table: "Historico");

            migrationBuilder.AlterColumn<int>(
                name: "ClienteId",
                table: "Historico",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CestaId",
                table: "Historico",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Historico_Cesta_CestaId",
                table: "Historico",
                column: "CestaId",
                principalTable: "Cesta",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Historico_Clientes_ClienteId",
                table: "Historico",
                column: "ClienteId",
                principalTable: "Clientes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Historico_Cesta_CestaId",
                table: "Historico");

            migrationBuilder.DropForeignKey(
                name: "FK_Historico_Clientes_ClienteId",
                table: "Historico");

            migrationBuilder.AlterColumn<int>(
                name: "ClienteId",
                table: "Historico",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "CestaId",
                table: "Historico",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Historico_Cesta_CestaId",
                table: "Historico",
                column: "CestaId",
                principalTable: "Cesta",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Historico_Clientes_ClienteId",
                table: "Historico",
                column: "ClienteId",
                principalTable: "Clientes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
