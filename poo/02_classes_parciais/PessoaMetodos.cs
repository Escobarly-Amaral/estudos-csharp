namespace Pessoas{

partial class Pessoa
{
    public static int CalcularIdade(int anoNascimento)
    {
        return DateTime.Now.Year - anoNascimento;
    }

    public void Cumprimentar(){
        Console.WriteLine($"Seja bem vindo {Nome} {Sobrenome}");
    }
}

}