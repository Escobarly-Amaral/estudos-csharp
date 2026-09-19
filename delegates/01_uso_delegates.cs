using System;
class Program
{
    public delegate void operacao(int valor1, int valor2);
    public static void Main(string[] args)
    {
        operacao conta = null;
        conta += Matematica.Somar;
        conta += Matematica.Subtrair;
        conta += Matematica.Multiplicacao;
        conta += Matematica.Divisao;

        conta(3, 9);
    }
}

class Matematica
{
    public static void Somar(int valor1, int valor2)
    {
        Console.WriteLine("Resultado da soma: " + (valor1 + valor2));
    }
    public static void Subtrair(int valor1, int valor2)
    {
        Console.WriteLine("Resultado da subtração: " + (valor1 - valor2));
    }
    public static void Multiplicacao(int valor1, int valor2)
    {
        Console.WriteLine("Resultado da multiplicação: " + (valor1 * valor2));
    }
    public static void Divisao(int valor1, int valor2)
    {
        if(valor2 == 0)
        {
            Console.WriteLine("Erro divisão por 0.");
        }
        else
        {
            float valor3 = (float) valor1/valor2;
            Console.WriteLine("Resultado da divisão: " + valor3);
        }
    }
}