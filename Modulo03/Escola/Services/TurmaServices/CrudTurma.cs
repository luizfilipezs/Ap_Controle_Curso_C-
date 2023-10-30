using Modulo03.Escola.Models;

namespace Modulo03.Escola.Services.TurmaServices
{
    public class CrudTurma : ICrud<Turma>
    {
        private static readonly List<Turma> Turmas = new();
        private static int UltimoId;

        public Turma Create(Turma turma)
        {
            turma.Id = UltimoId++;
            Turmas.Add(turma);

            return turma;
        }
        public List<Turma> Read()
        {
            return Turmas;
        }
        public void Update(Turma turma)
        {
            int indiceTurma = Turmas.FindIndex((item) => item.Id == turma.Id);

            if (indiceTurma != -1) {
                Turmas[indiceTurma] = turma;
            } else {
                Console.WriteLine("Turma não encontrado.");
            }
        }
        public void Delete(int id)
        {
            int indiceTurma = Turmas.FindIndex((item) => item.Id == id);

            if (indiceTurma != -1) {
                Turmas.RemoveAt(indiceTurma);
            } else {
                Console.WriteLine("Turma não encontrado.");
            }
        }
    }
}
