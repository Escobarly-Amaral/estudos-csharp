using System;

class Program
{
    static void Main(string[] args)
    {
        int[] numeros = {93, 43, 82, 11, 100, 21, 102, 104, 133, 123};
        int maior = -999999;

        for (int i = 0; i < numeros.Length; i++)
        {
            if(numeros[i] > maior)
            {
                maior = numeros[i];
            }
        }

        Console.WriteLine($"Maior numero: {maior}");
    }
}