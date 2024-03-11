using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infraestrutura.Migrations
{
    /// <inheritdoc />
    public partial class PathArquivos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Digitalizados",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    AssociadoId = table.Column<int>(type: "INTEGER", nullable: false),
                    CPF = table.Column<string>(type: "TEXT", nullable: false),
                    RG = table.Column<string>(type: "TEXT", nullable: false),
                    Filiacao = table.Column<string>(type: "TEXT", nullable: false),
                    Residencia = table.Column<string>(type: "TEXT", nullable: false),
                    Autorizacao = table.Column<string>(type: "TEXT", nullable: false),
                    ReqLicensa = table.Column<string>(type: "TEXT", nullable: false),
                    ReqINSS = table.Column<string>(type: "TEXT", nullable: false),
                    CanhotoProtocolo = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Digitalizados", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Digitalizados");
        }
    }
}
