using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VeiculosMVC.Migrations
{
    /// <inheritdoc />
    public partial class AdicionandoForeignKey : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Solicitacoes_Usuarios_UsuarioId",
                table: "Solicitacoes");

            migrationBuilder.DropIndex(
                name: "IX_Solicitacoes_UsuarioId",
                table: "Solicitacoes");

            migrationBuilder.AddColumn<int>(
                name: "UsarioId",
                table: "Solicitacoes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Solicitacoes_UsarioId",
                table: "Solicitacoes",
                column: "UsarioId");

            migrationBuilder.AddForeignKey(
                name: "FK_Solicitacoes_Usuarios_UsarioId",
                table: "Solicitacoes",
                column: "UsarioId",
                principalTable: "Usuarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Solicitacoes_Usuarios_UsarioId",
                table: "Solicitacoes");

            migrationBuilder.DropIndex(
                name: "IX_Solicitacoes_UsarioId",
                table: "Solicitacoes");

            migrationBuilder.DropColumn(
                name: "UsarioId",
                table: "Solicitacoes");

            migrationBuilder.CreateIndex(
                name: "IX_Solicitacoes_UsuarioId",
                table: "Solicitacoes",
                column: "UsuarioId");

            migrationBuilder.AddForeignKey(
                name: "FK_Solicitacoes_Usuarios_UsuarioId",
                table: "Solicitacoes",
                column: "UsuarioId",
                principalTable: "Usuarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
