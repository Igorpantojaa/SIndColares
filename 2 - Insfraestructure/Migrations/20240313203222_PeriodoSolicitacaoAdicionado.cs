using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infraestrutura.Migrations
{
    /// <inheritdoc />
    public partial class PeriodoSolicitacaoAdicionado : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Periodos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    AnoVigencia = table.Column<string>(type: "TEXT", nullable: false),
                    DataPublicacao = table.Column<DateTime>(type: "TEXT", nullable: false),
                    InicioPeriodo1 = table.Column<DateTime>(type: "TEXT", nullable: false),
                    InicioPeriodo2 = table.Column<DateTime>(type: "TEXT", nullable: false),
                    FimPeriodo1 = table.Column<DateTime>(type: "TEXT", nullable: false),
                    FimPeriodo2 = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Especies = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Periodos", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Periodos");
        }
    }
}
