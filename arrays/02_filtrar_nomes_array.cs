using System;

class Program
{
    static void Main(string[] args)
    {
        string[] nomes = new[] {"Escobarly", "Calleby"};

        /*
            string[] nomes = new string[5];
            nomes[0] = "Escobarly";
            nomes[1] = "Calleby";
            nomes[2] = "Patricia";
            nomes[3] = "Ednaldo";
            nomes[4] = "Pamella";
        */

        foreach(string nome in nomes)
        {
            if (nome.Length > 7)
            {
                Console.WriteLine(nome);
            }
        }
    }
}
