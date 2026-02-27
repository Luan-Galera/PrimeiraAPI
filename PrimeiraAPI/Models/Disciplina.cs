using System.ComponentModel.DataAnnotations;

namespace PrimeiraAPI.Models
{
    public class Disciplina
    {
        public Guid DisciplinaId { get; set; }
        [Required]
        public string? Nome { get; set; }
        public int CargaHoraria { get; set; }
        public int SemestreSugerido { get; set; }

        public ICollection<Curso> Cursos = new List<Curso>();
    }
}
