using System;

class Program
{
    static void Main(string[] args)
    {
        int tentativas, numeroSecreto, numeroAdivinha, jogarNovamente;

        do
        {
            string numeroAdivinhat = "", numeroSecretoT = "";
            tentativas = 0;
            Console.WriteLine("Jogador 1, por favor insira o numero secreto: ");
            do{
                numeroSecretoT = Console.ReadLine();
            }while(!int.TryParse(numeroSecretoT, out numeroSecreto));

            Console.Clear();  

            Console.WriteLine("Jogador 2, tente adivinhar o numero secreto. ");

            do
            {
                tentativas++;
                Console.WriteLine($"Tentativa nº {tentativas}");
                do{
                    numeroAdivinhat = Console.ReadLine();
                }while(!int.TryParse(numeroAdivinhat, out numeroAdivinha));


                if(numeroSecreto > numeroAdivinha)
                {
                    Console.WriteLine("Maior!");
                }else if(numeroSecreto < numeroAdivinha)
                {
                    Console.WriteLine("Menor!");
                }
                else
                {
                    Console.WriteLine("Acertou!");
                }
            }while(numeroSecreto != numeroAdivinha);

            Console.WriteLine("Quer jogar de novo?\n1 = Sim\n0 = Nao");
            while(!int.TryParse(Console.ReadLine(), out jogarNovamente) || (jogarNovamente != 0 && jogarNovamente != 1))
            {
                Console.WriteLine("Escolha invalida. Tente novamente");
            }            

        }while(jogarNovamente == 1);
    }
}