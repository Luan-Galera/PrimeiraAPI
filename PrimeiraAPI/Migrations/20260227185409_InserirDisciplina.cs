using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PrimeiraAPI.Migrations
{
    /// <inheritdoc />
    public partial class InserirDisciplina : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Disciplinas",
                columns: table => new
                {
                    DisciplinaId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CargaHoraria = table.Column<int>(type: "int", nullable: false),
                    SemestreSugerido = table.Column<int>(type: "int", nullable: false),
                    CursoId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Disciplinas", x => x.DisciplinaId);
                    table.ForeignKey(
                        name: "FK_Disciplinas_Cursos_CursoId",
                        column: x => x.CursoId,
                        principalTable: "Cursos",
                        principalColumn: "CursoId");
                });

            migrationBuilder.CreateTable(
                name: "DisciplinasCursos",
                columns: table => new
                {
                    DisciplinaCursoId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CursoID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DisciplinaID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NotaCurricular = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DisciplinasCursos", x => x.DisciplinaCursoId);
                    table.ForeignKey(
                        name: "FK_DisciplinasCursos_Cursos_CursoID",
                        column: x => x.CursoID,
                        principalTable: "Cursos",
                        principalColumn: "CursoId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DisciplinasCursos_Disciplinas_DisciplinaID",
                        column: x => x.DisciplinaID,
                        principalTable: "Disciplinas",
                        principalColumn: "DisciplinaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Disciplinas_CursoId",
                table: "Disciplinas",
                column: "CursoId");

            migrationBuilder.CreateIndex(
                name: "IX_DisciplinasCursos_CursoID",
                table: "DisciplinasCursos",
                column: "CursoID");

            migrationBuilder.CreateIndex(
                name: "IX_DisciplinasCursos_DisciplinaID",
                table: "DisciplinasCursos",
                column: "DisciplinaID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DisciplinasCursos");

            migrationBuilder.DropTable(
                name: "Disciplinas");
        }
    }
}
