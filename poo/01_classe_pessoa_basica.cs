using System;

class Program
{
    static void Main(string[] args)
    {
        Pessoa p1 = new Pessoa()
        {
            nome = "Escobarly",
            sobrenome = "Amaral",
            idade = 19
        };

        Pessoa p2 = new Pessoa();
        p2.nome = "Calleby";
        p2.sobrenome = "Amaral";
        p2.idade = 7;

        p1.Cumprimentar();
        p2.Cumprimentar();
    }
}

class Pessoa
{
    public string nome;
    public string sobrenome;
    public int idade;

    public void Cumprimentar()
    {
        Console.WriteLine($"Seja bem-vindo {nome} {sobrenome}");
    }
}