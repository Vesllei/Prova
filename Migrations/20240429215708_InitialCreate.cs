using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Weslley.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "funcionarios",
                columns: table => new
                {
                    funcionarioId = table.Column<string>(type: "TEXT", nullable: false),
                    Nome = table.Column<string>(type: "TEXT", nullable: true),
                    Cpf = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_funcionarios", x => x.funcionarioId);
                });

            migrationBuilder.CreateTable(
                name: "folhas",
                columns: table => new
                {
                    folhaId = table.Column<string>(type: "TEXT", nullable: false),
                    valor = table.Column<double>(type: "REAL", nullable: false),
                    quantidade = table.Column<double>(type: "REAL", nullable: false),
                    mes = table.Column<int>(type: "INTEGER", nullable: false),
                    ano = table.Column<int>(type: "INTEGER", nullable: false),
                    funcionarioId = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_folhas", x => x.folhaId);
                    table.ForeignKey(
                        name: "FK_folhas_funcionarios_funcionarioId",
                        column: x => x.funcionarioId,
                        principalTable: "funcionarios",
                        principalColumn: "funcionarioId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_folhas_funcionarioId",
                table: "folhas",
                column: "funcionarioId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "folhas");

            migrationBuilder.DropTable(
                name: "funcionarios");
        }
    }
}
