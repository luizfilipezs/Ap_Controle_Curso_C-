using Modulo03.Escola.Models;

namespace Modulo03.Escola.Services.PessoaServices
{
    public class CrudPessoa : ICrud<Pessoa>
    {
        private static readonly List<Pessoa> Pessoas = new();
        private static int UltimoId;

        public Pessoa Create(Pessoa pessoa)
        {
            pessoa.Id = UltimoId++;
            Pessoas.Add(pessoa);

            return pessoa;
        }
        public List<Pessoa> Read()
        {
            return Pessoas;
        }
        public void Update(Pessoa pessoa)
        {
            int indicePessoa = Pessoas.FindIndex((item) => item.Id == pessoa.Id);

            if (indicePessoa != -1) {
                Pessoas[indicePessoa] = pessoa;
            } else {
                Console.WriteLine("Pessoa não encontrado.");
            }
        }
        public void Delete(int id)
        {
            int indicePessoa = Pessoas.FindIndex((item) => item.Id == id);

            if (indicePessoa != -1) {
                Pessoas.RemoveAt(indicePessoa);
            } else {
                Console.WriteLine("Pessoa não encontrado.");
            }
        }
    }
}
