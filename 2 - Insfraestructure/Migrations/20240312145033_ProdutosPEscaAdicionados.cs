using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infraestrutura.Migrations
{
    /// <inheritdoc />
    public partial class ProdutosPEscaAdicionados : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Documentos_RG_RGid",
                table: "Documentos");

            migrationBuilder.DropColumn(
                name: "ProdutoPesca",
                table: "Profissoes");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "RG",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Profissoes",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Filiacoes",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Escolaridades",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Enderecos",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "RGid",
                table: "Documentos",
                newName: "RGId");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Documentos",
                newName: "Id");

            migrationBuilder.RenameIndex(
                name: "IX_Documentos_RGid",
                table: "Documentos",
                newName: "IX_Documentos_RGId");

            migrationBuilder.AddColumn<int>(
                name: "ProdutoPescaId",
                table: "Profissoes",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "ProdutosPesca",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    AssociadoId = table.Column<int>(type: "INTEGER", nullable: false),
                    Peixes = table.Column<bool>(type: "INTEGER", nullable: false),
                    Crustaceos = table.Column<bool>(type: "INTEGER", nullable: false),
                    Mariscos = table.Column<bool>(type: "INTEGER", nullable: false),
                    Algas = table.Column<bool>(type: "INTEGER", nullable: false),
                    Outros = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProdutosPesca", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Profissoes_ProdutoPescaId",
                table: "Profissoes",
                column: "ProdutoPescaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Documentos_RG_RGId",
                table: "Documentos",
                column: "RGId",
                principalTable: "RG",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Profissoes_ProdutosPesca_ProdutoPescaId",
                table: "Profissoes",
                column: "ProdutoPescaId",
                principalTable: "ProdutosPesca",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Documentos_RG_RGId",
                table: "Documentos");

            migrationBuilder.DropForeignKey(
                name: "FK_Profissoes_ProdutosPesca_ProdutoPescaId",
                table: "Profissoes");

            migrationBuilder.DropTable(
                name: "ProdutosPesca");

            migrationBuilder.DropIndex(
                name: "IX_Profissoes_ProdutoPescaId",
                table: "Profissoes");

            migrationBuilder.DropColumn(
                name: "ProdutoPescaId",
                table: "Profissoes");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "RG",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Profissoes",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Filiacoes",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Escolaridades",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Enderecos",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "RGId",
                table: "Documentos",
                newName: "RGid");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Documentos",
                newName: "id");

            migrationBuilder.RenameIndex(
                name: "IX_Documentos_RGId",
                table: "Documentos",
                newName: "IX_Documentos_RGid");

            migrationBuilder.AddColumn<string>(
                name: "ProdutoPesca",
                table: "Profissoes",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddForeignKey(
                name: "FK_Documentos_RG_RGid",
                table: "Documentos",
                column: "RGid",
                principalTable: "RG",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
