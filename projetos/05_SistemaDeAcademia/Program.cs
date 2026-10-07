using AcademiaSystem.Models;

Aluno aluno1 = new Aluno("Escobarly", 19, 61.5f, 1.62f);
aluno1.ExibirDados();
Aluno aluno2 = new Aluno("Davi", 12, 38f);
aluno2.ExibirDados();
Aluno aluno3 = new Aluno("Maria", 10, 28.5f);
aluno3.ExibirDados();
Aluno alunoTeste = new Aluno("", 0, 0f, 0f);
alunoTeste.ExibirDados();

float cargaTotal = Treino.CalcularCargaTotal(3,50);

Console.WriteLine(cargaTotal);