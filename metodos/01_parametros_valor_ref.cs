using System;

class Program
{
    static void Main(string[] args)
    {
        int valor1 = 50;
        int valor2 = 50;

        Matematica.Adicionar10(valor1);
        Matematica.Adicionar10Ref(ref valor2);

        Console.WriteLine("Valor 1 = " + valor1);
        Console.WriteLine("Valor 2 = " + valor2);
    }
}

class Matematica
{
    public static void Adicionar10(int valor1)
    {
        valor1 += 10;
        Console.WriteLine("Resultado (por valor): " + valor1);
    }

    public static void Adicionar10Ref(ref int valor1)
    {
        valor1 += 10;
        Console.WriteLine("Resultado (por referencia): " + valor1);
    }
}