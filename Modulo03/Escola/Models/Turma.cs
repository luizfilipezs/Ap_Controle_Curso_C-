namespace Modulo03.Escola.Models
{
    public class Turma : BaseModel
    {
        public Professor? Professor { get; set; }
        public List<Aluno>? Alunos { get; set; }
        public List<Materia>? Materias { get; set; }
    }
}
