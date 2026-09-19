using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Dictionary<string, Dictionary<string, string>> alunos_ifce = new Dictionary<string, Dictionary<string, string>>();
        int opcao = 0;

        do
        {
            Console.WriteLine("=== Sistema de cadastro alunos ===");
            Console.WriteLine("1 = Cadastrar aluno");
            Console.WriteLine("2 = Remover aluno");
            Console.WriteLine("3 = Ver alunos");
            Console.WriteLine("4 = Ver aluno");
            Console.WriteLine("5 = Sair");

            if(!int.TryParse(Console.ReadLine(), out opcao))
            {
                Console.WriteLine("Opção inválida");
                continue;
            }

            switch (opcao)
            {
                case 1:
                    Console.WriteLine("Digite a matricula do aluno: ");
                    string matricula = Console.ReadLine();

                    Console.WriteLine("Digite o nome do aluno: ");
                    string nome = Console.ReadLine();

                    Console.WriteLine("Digite o curso do aluno: ");
                    string curso = Console.ReadLine();

                    var alunoAdd = new Dictionary<string, string>();
                    alunoAdd.Add("Nome", nome);
                    alunoAdd.Add("Curso", curso);

                    alunos_ifce.Add(matricula, alunoAdd);

                    Console.WriteLine("Aluno cadastrado com sucesso!");
                    break;
                case 2:
                    Console.WriteLine("Digite a matricula do aluno: ");
                    string remover = Console.ReadLine();

                    if (alunos_ifce.ContainsKey(remover))
                    {
                        alunos_ifce.Remove(remover);
                        Console.WriteLine("Aluno removido do sistema!");
                    }
                    else
                    {
                        Console.WriteLine("Aluno não encontrado!");
                    }
                    break;
                case 3:
                    if(!(alunos_ifce.Count > 0))
                    {
                      Console.WriteLine("Nenhum aluno cadastrado no sistema!");  
                      break;
                    }

                    foreach(var aluno in alunos_ifce)
                    {
                        Console.WriteLine($"{aluno.Key} - {aluno.Value["Nome"]}");
                    }
                    break;
                case 4:
                    Console.WriteLine("Digite a matricula do aluno: ");
                    string searchMAT = Console.ReadLine();

                    if (!(alunos_ifce.ContainsKey(searchMAT)))
                    {
                        Console.WriteLine("Aluno não encontrado!");
                        break;
                    }

                    var alunoFound = alunos_ifce[searchMAT];

                    Console.WriteLine($"Matricula: {searchMAT}");
                    Console.WriteLine($"Nome: {alunoFound["Nome"]}");
                    Console.WriteLine($"Curso: {alunoFound["Curso"]}");

                    break;
                case 5:
                    break;
                default:
                    Console.WriteLine("Opção inválida!");
                    break;
            }
        }while(opcao != 5);
    }
}