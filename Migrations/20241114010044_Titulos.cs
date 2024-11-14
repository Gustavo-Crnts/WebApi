using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WebApi.Migrations
{
    /// <inheritdoc />
    public partial class Titulos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TB_PARTIDAS",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Dia = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false),
                    Horario = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false),
                    Estadio = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false),
                    Competicao = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false),
                    Adversario = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false),
                    Resultado = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false),
                    Placar = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_PARTIDAS", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TB_TITULOS",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Data = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false),
                    Premiacao = table.Column<int>(type: "int", nullable: false),
                    Campeonato = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false),
                    Artilheiro = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_TITULOS", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "TB_PARTIDAS",
                columns: new[] { "Id", "Adversario", "Competicao", "Dia", "Estadio", "Horario", "Placar", "Resultado" },
                values: new object[,]
                {
                    { 1, "Flamengo", "Brasileirao Serie A", "16/12/2015", "Maracana", "21:30", "3x0", "Vitoria" },
                    { 2, "Racing", "Sulamericana", "23/10/2024", "Neo Quimica Arena", "21:00", "2x2", "Empate" },
                    { 3, "Palmeiras", "Copa do Brasil", "01/12/2024", "Allianz Parque", "19:00", "51x0", "Vitoria" }
                });

            migrationBuilder.InsertData(
                table: "TB_TITULOS",
                columns: new[] { "Id", "Artilheiro", "Campeonato", "Data", "Premiacao" },
                values: new object[,]
                {
                    { 1, "Paolo Guerrero", "Mundial de Clubes", "16/12/2012", 1000000 },
                    { 2, "Emerson Sheik", "Libertadores da America", "04/06/2012", 2000000 },
                    { 3, "Jo", "Brasileirao Serie A", "15/11/2017", 1000000 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TB_PARTIDAS");

            migrationBuilder.DropTable(
                name: "TB_TITULOS");
        }
    }
}
