using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infraestrutura.Migrations
{
    /// <inheritdoc />
    public partial class PequenasALteracaoes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ReqLicensa",
                table: "Digitalizados",
                newName: "RegInicial");

            migrationBuilder.RenameColumn(
                name: "Autorizacao",
                table: "Digitalizados",
                newName: "Procuracao");

            migrationBuilder.AddColumn<string>(
                name: "SenhaGovBr",
                table: "Contatos",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SenhaGovBr",
                table: "Contatos");

            migrationBuilder.RenameColumn(
                name: "RegInicial",
                table: "Digitalizados",
                newName: "ReqLicensa");

            migrationBuilder.RenameColumn(
                name: "Procuracao",
                table: "Digitalizados",
                newName: "Autorizacao");
        }
    }
}
