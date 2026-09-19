using System;

class Program
{
    static void Main(string[] args)
    {
        Random random = new Random();
        int escolhaMaquina, escolhaPlayer, situacao, jogarNovamente;

        do
        {
            Console.WriteLine("Jogo de Pedra, Papel e Tesoura (jokenpo)\n");
            Console.WriteLine("1. Pedra");
            Console.WriteLine("2. Papel");
            Console.WriteLine("3. Tesoura"); 
            do
            {
                escolhaMaquina = random.Next(1, 4);
                Console.WriteLine("Digite o numero correspondente a sua escolha: ");
                while(!int.TryParse(Console.ReadLine(), out escolhaPlayer) || escolhaPlayer > 3 || escolhaPlayer < 1)
                {
                    Console.WriteLine("Escolha invalida. Tente novamente");
                }

                if(
                    (escolhaPlayer == 1 && escolhaMaquina == 3) ||
                    (escolhaPlayer == 2 && escolhaMaquina == 1) ||
                    (escolhaPlayer == 3 && escolhaMaquina == 2)
                )
                {
                    situacao = 1;
                    Console.WriteLine("Parabens! Voce venceu!");
                }else
                if(escolhaPlayer == escolhaMaquina)
                {
                    situacao = 3;
                    Console.WriteLine("Empate. Proxima rodada.");
                }
                else
                {
                    situacao = 2;
                    Console.WriteLine("Voce perdeu.");
                }
            } while(situacao == 3);

            situacao = 0;

            Console.WriteLine("Quer jogar de novo?\n1 = Sim\n0 = Nao");
            while(!int.TryParse(Console.ReadLine(), out jogarNovamente) || (jogarNovamente != 0 && jogarNovamente != 1))
            {
                Console.WriteLine("Escolha invalida. Tente novamente");
            }            
        }while(jogarNovamente == 1);
    }
}