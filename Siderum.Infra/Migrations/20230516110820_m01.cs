using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Siderum.Infra.Migrations
{
    public partial class m01 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CredoresSituacaoCredito");

            migrationBuilder.AddColumn<Guid>(
                name: "SituacaoCreditoId",
                table: "Credores",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_SituacaoCredito_CredorId",
                table: "SituacaoCredito",
                column: "CredorId");

            migrationBuilder.CreateIndex(
                name: "IX_Credores_SituacaoCreditoId",
                table: "Credores",
                column: "SituacaoCreditoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Credores_SituacaoCredito_SituacaoCreditoId",
                table: "Credores",
                column: "SituacaoCreditoId",
                principalTable: "SituacaoCredito",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_SituacaoCredito_Credores_CredorId",
                table: "SituacaoCredito",
                column: "CredorId",
                principalTable: "Credores",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Credores_SituacaoCredito_SituacaoCreditoId",
                table: "Credores");

            migrationBuilder.DropForeignKey(
                name: "FK_SituacaoCredito_Credores_CredorId",
                table: "SituacaoCredito");

            migrationBuilder.DropIndex(
                name: "IX_SituacaoCredito_CredorId",
                table: "SituacaoCredito");

            migrationBuilder.DropIndex(
                name: "IX_Credores_SituacaoCreditoId",
                table: "Credores");

            migrationBuilder.DropColumn(
                name: "SituacaoCreditoId",
                table: "Credores");

            migrationBuilder.CreateTable(
                name: "CredoresSituacaoCredito",
                columns: table => new
                {
                    CredoresId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SituacaoCreditoId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CredoresSituacaoCredito", x => new { x.CredoresId, x.SituacaoCreditoId });
                    table.ForeignKey(
                        name: "FK_CredoresSituacaoCredito_Credores_CredoresId",
                        column: x => x.CredoresId,
                        principalTable: "Credores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CredoresSituacaoCredito_SituacaoCredito_SituacaoCreditoId",
                        column: x => x.SituacaoCreditoId,
                        principalTable: "SituacaoCredito",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CredoresSituacaoCredito_SituacaoCreditoId",
                table: "CredoresSituacaoCredito",
                column: "SituacaoCreditoId");
        }
    }
}
