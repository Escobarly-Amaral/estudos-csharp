using System;

class Program
{
    static void Main (string[] args)
    {
        RECOMECAR:
        Random random = new Random();
        int numeroSecreto = random.Next(1, 11);
        int numeroAdivinha = 0;
        int tentativas = 0;
        int recomecar = 0;

        Console.WriteLine("Jogo de adivinhação\nAdivinhe o numero de  1 a 10\n");
        while(numeroAdivinha != numeroSecreto){
            tentativas++;
            Console.WriteLine($"Tentativa nº {tentativas}");
            if(!int.TryParse(Console.ReadLine(), out numeroAdivinha) || numeroAdivinha < 1 || numeroAdivinha > 10)
            {
                Console.WriteLine("Numero invalido!");
            }

            if(numeroAdivinha > numeroSecreto)
            {
                Console.WriteLine("Numero muito alto");
            }else if (numeroAdivinha < numeroSecreto)
            {
                Console.WriteLine("Numero muito baixo");
            }
            else
            {
                Console.WriteLine("Parabens! Voce acertou.");
            }
        }

        Console.WriteLine("Voce gostaria de recomeçar o jogo?\n1 = Sim\n0 = Nao");
        if (!int.TryParse(Console.ReadLine(), out recomecar) || recomecar != 1)
        {
            Console.WriteLine("Jogo finalizado!");
        }
        else
        {
            goto RECOMECAR;
        }

    }
}