using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DFleetCRUD.Migrations
{
    /// <inheritdoc />
    public partial class MIGRACAO4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Abastecimento",
                columns: table => new
                {
                    AbastecimentoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Estado = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cidade = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Veiculo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Frentista = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CombustivelUtilizado = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    QuantidadeLitros = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    ValorLitro = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    TipoAbastecimento = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompletouTanque = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Estabelecimento = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DataAbastecimento = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Abastecimento", x => x.AbastecimentoId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Abastecimento");
        }
    }
}
