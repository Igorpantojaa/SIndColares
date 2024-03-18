using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infraestrutura.Migrations
{
    /// <inheritdoc />
    public partial class AdicaoNumPublicacao : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "id",
                table: "Contatos",
                newName: "Id");

            migrationBuilder.AddColumn<string>(
                name: "UFPesca",
                table: "Profissoes",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UFPesca",
                table: "Profissoes");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Contatos",
                newName: "id");
        }
    }
}
