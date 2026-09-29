using AcademiaSystem.Models;

Aluno aluno1 = new Aluno("Escobarly", 19, 61.5f, 1.62f);
aluno1.ExibirDados();
Aluno aluno2 = new Aluno("Davi", 12, 31.5f);
aluno2.AdicionarIdade(1);
aluno2.ExibirDados();

float cargaTotal = Treino.CalcularCargaTotal(3,50);

Console.WriteLine(cargaTotal);