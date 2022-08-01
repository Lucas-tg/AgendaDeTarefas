using Microsoft.EntityFrameworkCore.Migrations;

namespace AgendaDeTarefas.Migrations
{
    public partial class CreateTableTarefas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Tarefa",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    titulo = table.Column<string>(nullable: false),
                    data = table.Column<string>(nullable: false),
                    horaInicio = table.Column<string>(nullable: false),
                    horaFim = table.Column<string>(nullable: false),
                    prioridade = table.Column<string>(nullable: false),
                    finalizada = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tarefa", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tarefa");
        }
    }
}
