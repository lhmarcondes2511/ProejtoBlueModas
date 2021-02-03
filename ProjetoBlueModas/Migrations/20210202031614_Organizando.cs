using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjetoBlueModas.Migrations
{
    public partial class Organizando : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cesta_Historico_HistoricoId",
                table: "Cesta");

            migrationBuilder.DropForeignKey(
                name: "FK_Clientes_Historico_HistoricoId",
                table: "Clientes");

            migrationBuilder.DropForeignKey(
                name: "FK_Produtos_Cesta_CestaId",
                table: "Produtos");

            migrationBuilder.DropIndex(
                name: "IX_Produtos_CestaId",
                table: "Produtos");

            migrationBuilder.DropIndex(
                name: "IX_Clientes_HistoricoId",
                table: "Clientes");

            migrationBuilder.DropIndex(
                name: "IX_Cesta_HistoricoId",
                table: "Cesta");

            migrationBuilder.DropColumn(
                name: "CestaId",
                table: "Produtos");

            migrationBuilder.DropColumn(
                name: "HistoricoId",
                table: "Clientes");

            migrationBuilder.DropColumn(
                name: "HistoricoId",
                table: "Cesta");

            migrationBuilder.AddColumn<DateTime>(
                name: "Data",
                table: "Historico",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

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
                name: "Data",
                table: "Historico");

            migrationBuilder.DropColumn(
                name: "Protocolo",
                table: "Historico");

            migrationBuilder.AddColumn<int>(
                name: "CestaId",
                table: "Produtos",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "HistoricoId",
                table: "Clientes",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "HistoricoId",
                table: "Cesta",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Produtos_CestaId",
                table: "Produtos",
                column: "CestaId");

            migrationBuilder.CreateIndex(
                name: "IX_Clientes_HistoricoId",
                table: "Clientes",
                column: "HistoricoId");

            migrationBuilder.CreateIndex(
                name: "IX_Cesta_HistoricoId",
                table: "Cesta",
                column: "HistoricoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Cesta_Historico_HistoricoId",
                table: "Cesta",
                column: "HistoricoId",
                principalTable: "Historico",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Clientes_Historico_HistoricoId",
                table: "Clientes",
                column: "HistoricoId",
                principalTable: "Historico",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Produtos_Cesta_CestaId",
                table: "Produtos",
                column: "CestaId",
                principalTable: "Cesta",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
