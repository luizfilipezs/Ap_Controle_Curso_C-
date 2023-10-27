using Modulo03.Escola.Models;
using Modulo03.Escola.Services;
using Modulo03.Escola.Services.AlunoServices;
using Modulo03.Escola.Services.MateriaServices;
using Modulo03.Escola.Services.ProfessorServices;
using Modulo03.Escola.Services.TurmaServices;

namespace Modulo03.Escola.View
{
    public class View
    {
        const string CRUD_ALUNO = "1";
        const string CRUD_PROFESSOR = "2";
        const string CRUD_MATERIA = "3";
        const string CRUD_TURMA = "4";
        const string ACAO_CRIAR = "1";
        const string ACAO_LISTAR = "2";
        const string ACAO_EDITAR = "3";
        const string ACAO_EXCLUIR = "4";

        public void Main()
        {
            do
            {
                ExibirRecursos();

                switch (ObterEscolhaUsuario())
                {
                    case CRUD_ALUNO:
                        AbrirCrudAluno();
                        break;
                    case CRUD_PROFESSOR:
                        AbrirCrudProfessor();
                        break;
                    case CRUD_MATERIA:
                        AbrirCrudMateria();
                        break;
                    case CRUD_TURMA:
                        AbrirCrudTurma();
                        break;
                    default:
                        Console.WriteLine();
                        break;
                }
            }
            while (Continuar());
        }

        private void ExibirRecursos()
        {
            Console.WriteLine("Digite um valor:");
            Console.WriteLine($"{ACAO_CRIAR}. Aluno");
            Console.WriteLine($"{ACAO_LISTAR}. Professor");
            Console.WriteLine($"{ACAO_EDITAR}. Matéria");
            Console.WriteLine($"{ACAO_EXCLUIR}. Turma");
        }

        private string? ObterEscolhaUsuario()
        {
            return Console.ReadLine()?.Trim().ToUpper();
        }

        private void AbrirCrudAluno()
        {
            Console.WriteLine("Você escolheu Aluno.");

            CrudAluno crudAluno = new();
            Aluno aluno = new();

            AbrirCrud(crudAluno, aluno);
        }

        private void AbrirCrudProfessor()
        {
            Console.WriteLine("Você escolheu Professor.");

            CrudProfessor crudProfessor = new();
            Professor professor = new();

            AbrirCrud(crudProfessor, professor);
        }

        private void AbrirCrudMateria()
        {
            Console.WriteLine("Você escolheu Matéria.");

            CrudMateria crudMateria = new();
            Materia materia = new();

            AbrirCrud(crudMateria, materia);
        }

        private void AbrirCrudTurma()
        {
            Console.WriteLine("Você escolheu Turma.");

            CrudTurma crudTurma = new();
            Turma turma = new();

            AbrirCrud(crudTurma, turma);
        }

        private void AbrirCrud<T>(ICrud<T> crud, T model) where T : BaseModel
        {
            ExibirAcoes();

            switch (ObterEscolhaUsuario())
            {
                case ACAO_CRIAR:
                    crud.Create(model);
                    break;
                case ACAO_LISTAR:
                    crud.Read();
                    break;
                case ACAO_EDITAR:
                    crud.Update(model);
                    break;
                case ACAO_EXCLUIR:
                    crud.Delete(model.Id);
                    break;
                default:
                    Console.WriteLine("Opção inválida.");
                    break;
            }
        }

        private void ExibirAcoes()
        {
            Console.WriteLine("O que deseja fazer?");
            Console.WriteLine($"{ACAO_CRIAR}. Criar");
            Console.WriteLine($"{ACAO_LISTAR}. Listar");
            Console.WriteLine($"{ACAO_EDITAR}. Editar");
            Console.WriteLine($"{ACAO_EXCLUIR}. Excluir");
        }

        private bool Continuar()
        {
            const string TEXTO_SIM = "SIM";
            const string TEXTO_NAO = "NÃO";

            Console.Write($"Você deseja fazer uma nova operação?\n{TEXTO_SIM}\n{TEXTO_NAO}\n >>");

            return ObterEscolhaUsuario() == TEXTO_SIM;
        }
    }
}
