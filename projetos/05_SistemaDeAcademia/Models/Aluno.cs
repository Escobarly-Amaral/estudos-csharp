namespace AcademiaSystem.Models;

internal class Aluno
{
    public string Nome { get; set; }
    public int Idade { get; set; }
    public float Peso { get; set; }
    public float Altura { get; set; }
    private string _matricula;
    public string Matricula
    {
        get { return _matricula; }
        private set { _matricula = $"{Nome}_{Idade}"; }
    }
    public Aluno(string Nome, int Idade, float Peso, float Altura)
    {
        this.Nome = Nome;
        this.Idade = Idade;
        this.Peso = Peso;
        this.Altura = Altura;
        Matricula = "gerar";
    }

    public void ExibirDados()
    {
        Console.WriteLine("Nome: " + Nome);
        Console.WriteLine("Idade: " + Idade);
        Console.WriteLine("Peso: " + Peso);
        Console.WriteLine("Altura: " + Altura);
        Console.WriteLine("IMC: " + CalcularIMC());
        Console.WriteLine("Matricula: " + Matricula);
    }

    public float CalcularIMC() => Peso / (float) Math.Pow(Altura, 2);
}