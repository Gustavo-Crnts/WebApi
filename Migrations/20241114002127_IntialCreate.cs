using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WebApi.Migrations
{
    /// <inheritdoc />
    public partial class IntialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TB_JOGADORES",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false),
                    Salario = table.Column<int>(type: "int", nullable: false),
                    Partidas = table.Column<int>(type: "int", nullable: false),
                    Gols = table.Column<int>(type: "int", nullable: false),
                    Assistencias = table.Column<int>(type: "int", nullable: false),
                    Posicao = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_JOGADORES", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "TB_JOGADORES",
                columns: new[] { "Id", "Assistencias", "Gols", "Nome", "Partidas", "Posicao", "Salario" },
                values: new object[,]
                {
                    { 1, 13, 10, "Rodrigo Garro", 50, 3, 700000 },
                    { 2, 1, 1, "Andre Ramalho", 35, 2, 500000 },
                    { 3, 0, 0, "Hugo Souza", 28, 1, 350000 },
                    { 4, 8, 26, "Yuri Alberto", 60, 4, 1500000 },
                    { 5, 4, 3, "Memphis Depay", 10, 4, 3000000 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TB_JOGADORES");
        }
    }
}
