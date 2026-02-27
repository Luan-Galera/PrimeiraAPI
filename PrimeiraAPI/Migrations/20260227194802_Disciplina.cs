using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PrimeiraAPI.Migrations
{
    /// <inheritdoc />
    public partial class Disciplina : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DisciplinasCursos_Cursos_CursoID",
                table: "DisciplinasCursos");

            migrationBuilder.DropForeignKey(
                name: "FK_DisciplinasCursos_Disciplinas_DisciplinaID",
                table: "DisciplinasCursos");

            migrationBuilder.RenameColumn(
                name: "DisciplinaID",
                table: "DisciplinasCursos",
                newName: "DisciplinaId");

            migrationBuilder.RenameColumn(
                name: "CursoID",
                table: "DisciplinasCursos",
                newName: "CursoId");

            migrationBuilder.RenameIndex(
                name: "IX_DisciplinasCursos_DisciplinaID",
                table: "DisciplinasCursos",
                newName: "IX_DisciplinasCursos_DisciplinaId");

            migrationBuilder.RenameIndex(
                name: "IX_DisciplinasCursos_CursoID",
                table: "DisciplinasCursos",
                newName: "IX_DisciplinasCursos_CursoId");

            migrationBuilder.AddForeignKey(
                name: "FK_DisciplinasCursos_Cursos_CursoId",
                table: "DisciplinasCursos",
                column: "CursoId",
                principalTable: "Cursos",
                principalColumn: "CursoId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DisciplinasCursos_Disciplinas_DisciplinaId",
                table: "DisciplinasCursos",
                column: "DisciplinaId",
                principalTable: "Disciplinas",
                principalColumn: "DisciplinaId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DisciplinasCursos_Cursos_CursoId",
                table: "DisciplinasCursos");

            migrationBuilder.DropForeignKey(
                name: "FK_DisciplinasCursos_Disciplinas_DisciplinaId",
                table: "DisciplinasCursos");

            migrationBuilder.RenameColumn(
                name: "DisciplinaId",
                table: "DisciplinasCursos",
                newName: "DisciplinaID");

            migrationBuilder.RenameColumn(
                name: "CursoId",
                table: "DisciplinasCursos",
                newName: "CursoID");

            migrationBuilder.RenameIndex(
                name: "IX_DisciplinasCursos_DisciplinaId",
                table: "DisciplinasCursos",
                newName: "IX_DisciplinasCursos_DisciplinaID");

            migrationBuilder.RenameIndex(
                name: "IX_DisciplinasCursos_CursoId",
                table: "DisciplinasCursos",
                newName: "IX_DisciplinasCursos_CursoID");

            migrationBuilder.AddForeignKey(
                name: "FK_DisciplinasCursos_Cursos_CursoID",
                table: "DisciplinasCursos",
                column: "CursoID",
                principalTable: "Cursos",
                principalColumn: "CursoId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DisciplinasCursos_Disciplinas_DisciplinaID",
                table: "DisciplinasCursos",
                column: "DisciplinaID",
                principalTable: "Disciplinas",
                principalColumn: "DisciplinaId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
