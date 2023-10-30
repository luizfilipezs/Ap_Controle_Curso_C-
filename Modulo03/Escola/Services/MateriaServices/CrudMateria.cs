using Modulo03.Escola.Models;

namespace Modulo03.Escola.Services.MateriaServices
{
    public class CrudMateria : ICrud<Materia>
    {
        private static readonly List<Materia> Materias = new();
        private static int UltimoId;

        public Materia Create(Materia materia)
        {
            materia.Id = UltimoId++;
            Materias.Add(materia);

            return materia;
        }
        public List<Materia> Read()
        {
            return Materias;
        }
        public void Update(Materia materia)
        {
            int indiceMateria = Materias.FindIndex((item) => item.Id == materia.Id);

            if (indiceMateria != -1) {
                Materias[indiceMateria] = materia;
            } else {
                Console.WriteLine("Materia não encontrado.");
            }
        }
        public void Delete(int id)
        {
            int indiceMateria = Materias.FindIndex((item) => item.Id == id);

            if (indiceMateria != -1) {
                Materias.RemoveAt(indiceMateria);
            } else {
                Console.WriteLine("Materia não encontrado.");
            }
        }
    }
}
