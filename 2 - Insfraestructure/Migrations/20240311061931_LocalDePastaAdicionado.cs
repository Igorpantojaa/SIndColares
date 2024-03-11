using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infraestrutura.Migrations
{
    /// <inheritdoc />
    public partial class LocalDePastaAdicionado : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Nacionalidade",
                table: "RG",
                newName: "EstadoEmissao");

            migrationBuilder.RenameColumn(
                name: "Cidade",
                table: "Enderecos",
                newName: "Localidade");

            migrationBuilder.AlterColumn<string>(
                name: "RGP",
                table: "Profissoes",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AlterColumn<string>(
                name: "AB",
                table: "Profissoes",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AlterColumn<string>(
                name: "Numero",
                table: "Enderecos",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AlterColumn<string>(
                name: "CEP",
                table: "Enderecos",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AddColumn<string>(
                name: "Foto",
                table: "Digitalizados",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Local",
                table: "Digitalizados",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_Digitalizados_AssociadoId",
                table: "Digitalizados",
                column: "AssociadoId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Digitalizados_Associados_AssociadoId",
                table: "Digitalizados",
                column: "AssociadoId",
                principalTable: "Associados",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Digitalizados_Associados_AssociadoId",
                table: "Digitalizados");

            migrationBuilder.DropIndex(
                name: "IX_Digitalizados_AssociadoId",
                table: "Digitalizados");

            migrationBuilder.DropColumn(
                name: "Foto",
                table: "Digitalizados");

            migrationBuilder.DropColumn(
                name: "Local",
                table: "Digitalizados");

            migrationBuilder.RenameColumn(
                name: "EstadoEmissao",
                table: "RG",
                newName: "Nacionalidade");

            migrationBuilder.RenameColumn(
                name: "Localidade",
                table: "Enderecos",
                newName: "Cidade");

            migrationBuilder.AlterColumn<int>(
                name: "RGP",
                table: "Profissoes",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AlterColumn<int>(
                name: "AB",
                table: "Profissoes",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AlterColumn<int>(
                name: "Numero",
                table: "Enderecos",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AlterColumn<int>(
                name: "CEP",
                table: "Enderecos",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "TEXT");
        }
    }
}
