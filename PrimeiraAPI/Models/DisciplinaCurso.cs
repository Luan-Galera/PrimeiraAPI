namespace PrimeiraAPI.Models
{
    public class DisciplinaCurso
    {
        public Guid DisciplinaCursoId { get; set; }

        public Guid CursoID { get; set; }
        public Curso? Curso { get; set; }

        public Guid DisciplinaID { get; set; }
        public Disciplina? Disciplina { get; set; }
        
        public double NotaCurricular { get; set; }
    }
}
