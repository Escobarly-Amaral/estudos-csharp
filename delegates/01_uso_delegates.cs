using System;

class Program
{
    public delegate float operacao(float num1, float num2);
    static void Main(string[] args)
    {
        operacao conta = null;
        float valor1 = 5;
        float valor2 = 5;
        conta += Matematica.Somar;
        conta += Matematica.Subtrair;
        conta += Matematica.Multiplicar;
        conta += Matematica.Dividir;

        conta(valor1, valor2);
    }
}

class Matematica
{
    public static float Somar(float num1, float num2)
    {
        float soma = num1 + num2;
        Console.WriteLine($"Resultado da soma: {soma}");
        return soma;
    }

    public static float Subtrair(float num1, float num2)
    {
        float subtracao = num1 - num2;
        Console.WriteLine($"Resultado da subtração: {subtracao}");
        return subtracao;
    }

    public static float Multiplicar(float num1, float num2)
    {
        float multiplicacao = num1 * num2;
        Console.WriteLine($"Resultado da multiplicação: {multiplicacao}");
        return multiplicacao;
    }

    public static float Dividir(float num1, float num2)
    {
        if(num2 == 0 || num2 < 0.00001)
        {
            Console.WriteLine($"Resultado da divisão: Indefinido");
            return 0;
        }
        else
        {
            float divisao = num1 / num2;
            Console.WriteLine($"Resultado da divisão: {divisao}");
            return divisao;
        }
    }
}
/*
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
*/