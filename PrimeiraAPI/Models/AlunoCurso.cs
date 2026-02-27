namespace PrimeiraAPI.Models
{
    public class AlunoCurso
    {
        // Identificador único do regitro da associação entre Aluno e Curso
        public Guid AlunoCursoId { get; set; }

        // Chave estrangeira para o Aluno
        public Guid AlunoID { get; set; }
        
        // Propriedade de navegação para o Aluno
        public Aluno? Aluno { get; set; }

        // Chave estrangeira para o Curso
        public Guid CursoID { get; set; }

        // Propriedade de navegação para o Curso
        public Curso? Curso { get; set; }
    }
}
