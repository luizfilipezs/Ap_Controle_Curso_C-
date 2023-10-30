using Modulo03.Escola.Models;

namespace Modulo03.Escola.Services.ProfessorServices
{
    public class CrudProfessor : ICrud<Professor>
    {
        private static readonly List<Professor> Professores = new();
        private static int UltimoId;

        public Professor Create(Professor professor)
        {
            professor.Id = UltimoId++;
            Professores.Add(professor);

            return professor;
        }
        public List<Professor> Read()
        {
            return Professores;
        }
        public void Update(Professor professor)
        {
            int indiceProfessor = Professores.FindIndex((item) => item.Id == professor.Id);

            if (indiceProfessor != -1) {
                Professores[indiceProfessor] = professor;
            } else {
                Console.WriteLine("Professor não encontrado.");
            }
        }
        public void Delete(int id)
        {
            int indiceProfessor = Professores.FindIndex((item) => item.Id == id);

            if (indiceProfessor != -1) {
                Professores.RemoveAt(indiceProfessor);
            } else {
                Console.WriteLine("Professor não encontrado.");
            }
        }
    }
}
