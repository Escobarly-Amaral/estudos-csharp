using System;

class Program
{
    static void Main(string[] args)
    {
        Random random = new Random();
        int recomecar = 0;
        int numero_secreto;
        int numero = 0;

        do
        {
            numero_secreto = random.Next(1, 11);
            Console.WriteLine("Adivinhe o numero secreto de 1 a 10: ");

            do
            {
                bool numeroValido = int.TryParse(Console.ReadLine(), out numero);
                if(!numeroValido || numero > 10 || numero < 1)
                {
                    Console.WriteLine("Numero invalido!");
                    continue;
                }
                
                if (numero > numero_secreto)
                {
                    Console.WriteLine("Numero muito alto!");
                }else if(numero < numero_secreto)
                {
                    Console.WriteLine("Numero muito baixo!");
                }
                else
                {
                    Console.WriteLine("Parabens voce acertou!");
                }
            }while(numero != numero_secreto);

            Console.WriteLine("Voce deseja recomecar?\n1=Sim\n0=Nao");
            bool recomecarValido;

            do
            {
                recomecarValido = int.TryParse(Console.ReadLine(), out recomecar);
            }while(recomecar < 0 || recomecar > 1 || !recomecarValido);

        }while(recomecar == 1);
    }
}