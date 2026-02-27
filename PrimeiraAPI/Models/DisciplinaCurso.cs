namespace PrimeiraAPI.Models
{
    public class DisciplinaCurso
    {
        public Guid DisciplinaCursoId { get; set; }

        public Guid CursoId { get; set; }
        public Curso? Cursos { get; set; }

        public Guid DisciplinaId { get; set; }
        public Disciplina? Disciplinas { get; set; }
        
        public double NotaCurricular { get; set; }
    }
}
