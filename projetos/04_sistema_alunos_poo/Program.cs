using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        do
        {
            AlunoManager.ExibirOpcoes();

            if(!int.TryParse(Console.ReadLine(), out AlunoManager.opcao))
            {
                Console.WriteLine("Opcao invalida!");
                continue;
            }

            switch (AlunoManager.opcao)
            {
                case 1:
                    AlunoManager.CadastrarAluno();
                    break;
                case 2:
                    AlunoManager.RemoverAluno();
                    break;
                case 3:
                    AlunoManager.ExibirAlunos();
                    break;
                case 4:
                    AlunoManager.ExibirAluno();
                    break;
                case 5:
                    Console.WriteLine("Saindo...");
                    break;
                default:
                    Console.WriteLine("Opcao invalida");
                    break;
            }
        }while(AlunoManager.opcao != 5);
    }
}

static class AlunoManager
{
    public static int opcao = 0;
    public static List<Aluno> alunos = new List<Aluno>();
    
    public static void ExibirOpcoes()
    {
        Console.WriteLine("==== Sistema de alunos do IFCE ====");
        Console.WriteLine("1 - Cadastrar aluno");
        Console.WriteLine("2 - Remover aluno");
        Console.WriteLine("3 - Ver alunos");
        Console.WriteLine("4 - Ver dados do aluno");
        Console.WriteLine("5 - Sair");
    }

    public static void CadastrarAluno()
    {
        Console.WriteLine("Informe o nome do aluno: ");
        string nome = Console.ReadLine();

        Console.WriteLine("Informe o curso do aluno: ");
        string curso = Console.ReadLine();

        Aluno aluno = new Aluno(nome, curso);
        alunos.Add(aluno);

        Console.WriteLine("Aluno cadastrado com sucesso!");
    }
    public static void RemoverAluno()
    {
        Console.WriteLine("Informe a matricula do aluno: ");
        string matricula = Console.ReadLine();
        Aluno alunoSearched = null;

        if(alunos.Count == 0)
        {
            Console.WriteLine("Nenhum aluno cadastrado no sistema!");
            return;
        }

        foreach(Aluno aluno in alunos)
        {
            if(aluno.Matricula == matricula)
            {
                alunoSearched = aluno;
                break;
            }
        }

        if (alunoSearched != null)
        // Errei aqui tinha colocado "if(alunoSearched)" apenas
        {
            alunos.Remove(alunoSearched);
            Console.WriteLine("Aluno removido do sistema com sucesso!");
        }
        else
        {
            Console.WriteLine("Aluno não encontrado!");
        }
    }
    public static void ExibirAlunos()
    {
        if(alunos.Count > 0)
        {
            foreach(Aluno aluno in alunos)
            {
                aluno.ExibirEmLista();
            }
        }
        else
        {
            Console.WriteLine("Nenhum aluno cadastrado!");
        }
    }

    public static void ExibirAluno()
    {
        Console.WriteLine("Informe a matricula do aluno: ");
        string matricula = Console.ReadLine();
        Aluno alunoS = null;

        if(alunos.Count == 0)
        {
            Console.WriteLine("Nenhum aluno cadastrado no sistema!");
            return;
        }

        foreach(Aluno aluno in alunos)
        {
            if(aluno.Matricula == matricula)
            {
                alunoS = aluno;
                break;
            }
        }

        if(alunoS == null)
        {
            Console.WriteLine("Nenhum aluno encontrado com essa matricula!");
            
        }
        else
        {
            alunoS.ExibirDadosCompletos();
        }
    }
}

class Aluno
{
    public string Nome {get; set;}
    public string Curso {get; set;}
    public string Matricula { get; set; }

    public Aluno(string Nome, string Curso)
    {
        this.Nome = Nome;
        this.Curso = Curso;
        Random random = new Random();
        this.Matricula = $"{random.Next(1000, 10000)}";
    }

    public void ExibirEmLista()
    {
        Console.WriteLine($"{Matricula} - {Nome}");
    }

    public void ExibirDadosCompletos()
    {
        Console.WriteLine($"Matricula: {Matricula}");
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Curso: {Curso}");
    }
}