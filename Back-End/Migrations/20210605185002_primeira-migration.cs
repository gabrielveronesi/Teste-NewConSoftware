using Microsoft.EntityFrameworkCore.Migrations;

namespace Back_End.Migrations
{
    public partial class primeiramigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PontoTuristico",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Descricao = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Localizacao = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cidade = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Estado = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PontoTuristico", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "PontoTuristico",
                columns: new[] { "Id", "Cidade", "Descricao", "Estado", "Localizacao", "Nome" },
                values: new object[] { 1, "Morro do Corcovado", "Este monumento na capital fluminense é uma das 7 Maravilhas do Mundo", "Rio de Janeiro", "Floresta da Tijuca", "Cristo Redentor" });

            migrationBuilder.InsertData(
                table: "PontoTuristico",
                columns: new[] { "Id", "Cidade", "Descricao", "Estado", "Localizacao", "Nome" },
                values: new object[] { 2, "Moema", "Perfeito para corridas matinais, piqueniques, descansos à sombra das árvores.", "São Paulo", "Av. Pedro Álvares Cabral - Vila Mariana", "Parque do Ibirapuera" });

            migrationBuilder.InsertData(
                table: "PontoTuristico",
                columns: new[] { "Id", "Cidade", "Descricao", "Estado", "Localizacao", "Nome" },
                values: new object[] { 3, "Foz do Iguaçu", "As cataratas formam quedas d’água lindas, mostrando toda força da natureza!", "Paraná", "Extremo Oeste Paranaense", "Cataratas do Iguaçu" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PontoTuristico");
        }
    }
}
