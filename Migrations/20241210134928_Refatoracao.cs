using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VeiculosMVC.Migrations
{
    /// <inheritdoc />
    public partial class Refatoracao : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Solicitacoes",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "Nome",
                table: "Solicitacoes",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "Telefone",
                table: "Solicitacoes",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Email",
                table: "Solicitacoes");

            migrationBuilder.DropColumn(
                name: "Nome",
                table: "Solicitacoes");

            migrationBuilder.DropColumn(
                name: "Telefone",
                table: "Solicitacoes");
        }
    }
}
