using System;

class Program
{
    static void Main(string[] args)
    {
        Matematica mat = new Matematica();
        mat.Somar(10, 76);
        Console.WriteLine(mat.Somar(14, 83, 65));
    }
}

class Matematica
{
    public void Somar(int valor1, int valor2)
    {
        Console.WriteLine(valor1+valor2);
    }

    public int Somar(int valor1, int valor2, int valor3)
    {
        return valor1 + valor2 + valor3;
    }
}