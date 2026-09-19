using Pessoas;
using System;
class Program
{
    public static void Main(string[] args)
    {
        Pessoa p1 = new Pessoa()
        {
            Nome = "Escobarly",
            Sobrenome = "Amaral",
            AnoNascimento = 2006
        };
        p1.Cumprimentar();
    }
}