namespace AcademiaSystem.Models;

internal class Aluno : Pessoa{
    // Propriedades
    public int Idade
    {
        get;
        set{
            if(value > 120)
            {
                ConsoleLogger.warn("A idade não pode ser maior que 120 anos");
            }else if(value < idadeMinima)
            {
                ConsoleLogger.warn($"A idade não pode ser menor que {idadeMinima} anos");
            }
            else
            {
                field = value;
            }
        }
    }

    // Campos/Atributos
    private string _matricula;
    public float imc;
    protected const int idadeMinima = 12;

    // Métodos
    private void GerarMatricula()
    {
        if(!string.IsNullOrEmpty(_matricula))
        {
            ConsoleLogger.warn($"A matrícula do aluno {this.Nome} já foi gerada: {_matricula}");
            return;
        }
        Random random = new Random();
        _matricula = "ALU" + random.Next(1000, 9999).ToString();
    }
    public float CalcularIMC()
    {
        if(this.Altura <= 0)
        {
            ConsoleLogger.error("A altura não pode ser nula ou negativa no cálculo do IMC");
            return 0;
        }

        if(this.Peso <= 0)
        {
            ConsoleLogger.error("O peso não pode ser nulo ou negativo no cálculo do IMC");
            return 0;
        }

        return (float) (this.Peso / Math.Pow(this.Altura, 2));
    }
    public float CalcularIMC(float peso, float altura)
    {
        if(altura <= 0)
        {
            ConsoleLogger.error("A altura não pode ser nula ou negativa no cálculo do IMC");
            return 0;
        }

        if(peso <= 0)
        {
            ConsoleLogger.error("O peso não pode ser nulo ou negativo no cálculo do IMC");
            return 0;
        }

        return (float) (peso / Math.Pow(altura, 2));
    }
    public void definirIMC() => this.imc = CalcularIMC();
    public void ExibirDados()
    {
        Console.WriteLine($"Matrícula: {this._matricula}");
        Console.WriteLine($"Nome: {this.Nome}");
        Console.WriteLine($"Idade: {this.Idade}");
        Console.WriteLine($"Peso: {this.Peso}");
        Console.WriteLine($"Altura: {this.Altura}");
        Console.WriteLine($"IMC: {this.imc}");
    }
    
    // Construtores
    public Aluno(string nome, int idade, float peso, float altura)
    {
        this.Nome = nome;
        this.Idade = idade;
        this.Peso = peso;
        this.Altura = altura;
        GerarMatricula();
        definirIMC();
    }
    public Aluno(string nome, int idade, float peso) : this(nome, idade, peso, 0)
    {
        //  
    }
    public Aluno (string nome, int idade) : this(nome, idade, 0, 0)
    {
        // 
    }
}