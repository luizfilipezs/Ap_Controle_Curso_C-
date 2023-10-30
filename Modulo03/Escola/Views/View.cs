using Modulo03.Escola.Models;
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
        const string TEXTO_SIM = "SIM";
        const string TEXTO_NAO = "NÃO";


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
            return Console.ReadLine()?.Trim();
        }

        private void AbrirCrudAluno()
        {
            CrudAluno crud = new();
            Aluno? model;

            Console.WriteLine("Você escolheu Aluno.");
            ExibirAcoes();

            switch (ObterEscolhaUsuario())
            {
                case ACAO_CRIAR:
                    model = new()
                    {
                        Matricula = RequerirInformacaoUsuario("Digite a matrícula:"),
                        Nome = RequerirInformacaoUsuario("Digite o nome:"),
                        Sobrenome = RequerirInformacaoUsuario("Digite o sobrenome:")
                    };

                    crud.Create(model);
                    break;
                case ACAO_LISTAR:
                    crud.Read();
                    break;
                case ACAO_EDITAR:
                    model = new()
                    {
                        Id = RequerirIdRegistro(),
                        Matricula = RequerirInformacaoUsuario("Digite a matrícula:"),
                        Nome = RequerirInformacaoUsuario("Digite o nome:"),
                        Sobrenome = RequerirInformacaoUsuario("Digite o sobrenome:")
                    };

                    crud.Update(model);
                    break;
                case ACAO_EXCLUIR:
                    int id = RequerirIdRegistro();

                    crud.Delete(id);
                    break;
                default:
                    Console.WriteLine("Opção inválida.");
                    break;
            }
        }

        private void AbrirCrudProfessor()
        {
            CrudProfessor crud = new();
            Professor? model;

            Console.WriteLine("Você escolheu Professor.");
            ExibirAcoes();

            switch (ObterEscolhaUsuario())
            {
                case ACAO_CRIAR:
                    model = new()
                    {
                        Matricula = RequerirInformacaoUsuario("Digite a matrícula:"),
                        Nome = RequerirInformacaoUsuario("Digite o nome:"),
                        Sobrenome = RequerirInformacaoUsuario("Digite o sobrenome:"),
                    };

                    crud.Create(model);
                    break;
                case ACAO_LISTAR:
                    crud.Read();
                    break;
                case ACAO_EDITAR:
                    model = new()
                    {
                        Id = RequerirIdRegistro(),
                        Matricula = RequerirInformacaoUsuario("Digite a matrícula:"),
                        Nome = RequerirInformacaoUsuario("Digite o nome:"),
                        Sobrenome = RequerirInformacaoUsuario("Digite o sobrenome:"),
                    };

                    crud.Update(model);
                    break;
                case ACAO_EXCLUIR:
                    int id = RequerirIdRegistro();

                    crud.Delete(id);
                    break;
                default:
                    Console.WriteLine("Opção inválida.");
                    break;
            }
        }

        private void AbrirCrudMateria()
        {
            CrudMateria crud = new();
            Materia? model;

            Console.WriteLine("Você escolheu Matéria.");
            ExibirAcoes();

            switch (ObterEscolhaUsuario())
            {
                case ACAO_CRIAR:
                    model = new()
                    {
                        Nome = RequerirInformacaoUsuario("Digite o nome:"),
                    };

                    crud.Create(model);
                    break;
                case ACAO_LISTAR:
                    crud.Read();
                    break;
                case ACAO_EDITAR:
                    model = new()
                    {
                        Id = RequerirIdRegistro(),
                        Nome = RequerirInformacaoUsuario("Digite o nome:"),
                    };

                    crud.Update(model);
                    break;
                case ACAO_EXCLUIR:
                    int id = RequerirIdRegistro();

                    crud.Delete(id);
                    break;
                default:
                    Console.WriteLine("Opção inválida.");
                    break;
            }
        }

        private void AbrirCrudTurma()
        {
            CrudTurma crud = new();
            Turma? model;

            Console.WriteLine("Você escolheu Turma.");
            ExibirAcoes();

            switch (ObterEscolhaUsuario())
            {
                case ACAO_CRIAR:
                    model = new()
                    {
                    };

                    crud.Create(model);
                    break;
                case ACAO_LISTAR:
                    crud.Read();
                    break;
                case ACAO_EDITAR:
                    model = new()
                    {
                        Id = RequerirIdRegistro(),
                    };

                    crud.Update(model);
                    break;
                case ACAO_EXCLUIR:
                    int id = RequerirIdRegistro();

                    crud.Delete(id);
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
            Console.Write($"Você deseja fazer uma nova operação?\n{TEXTO_SIM}\n{TEXTO_NAO}\n >>");

            return ObterEscolhaUsuario()?.ToUpper() == TEXTO_SIM;
        }

        private int RequerirIdRegistro()
        {
            while (true)
            {
                try
                {
                    string id = RequerirInformacaoUsuario("Digite o ID:");

                    return Convert.ToInt32(id);
                }
                catch (Exception e)
                {
                    Console.WriteLine("Valor inválido.");
                }
            }
        }

        private string RequerirInformacaoUsuario(string mensagem)
        {
            string? resposta;

            do
            {
                Console.WriteLine(mensagem);
                resposta = ObterEscolhaUsuario();
            }
            while (resposta == null);

            return resposta;
        }
    }
}
