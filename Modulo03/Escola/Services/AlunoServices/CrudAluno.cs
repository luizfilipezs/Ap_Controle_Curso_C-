using Modulo03.Escola.Models;

namespace Modulo03.Escola.Services.AlunoServices
{
    public class CrudAluno : ICrud<Aluno>
    {
        private static readonly List<Aluno> Alunos = new();
        private static int UltimoId;

        public Aluno Create(Aluno aluno)
        {
            aluno.Id = UltimoId++;
            Alunos.Add(aluno);

            return aluno;
        }
        public List<Aluno> Read()
        {
            return Alunos;
        }
        public void Update(Aluno aluno)
        {
            int indiceAluno = Alunos.FindIndex((item) => item.Id == aluno.Id);

            if (indiceAluno != -1) {
                Alunos[indiceAluno] = aluno;
            } else {
                Console.WriteLine("Aluno não encontrado.");
            }
        }
        public void Delete(int id)
        {
            int indiceAluno = Alunos.FindIndex((item) => item.Id == id);

            if (indiceAluno != -1) {
                Alunos.RemoveAt(indiceAluno);
            } else {
                Console.WriteLine("Aluno não encontrado.");
            }
        }
    }
}
