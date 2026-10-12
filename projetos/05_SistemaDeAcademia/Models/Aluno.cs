namespace AcademiaSystem.Models;

internal class Aluno : Pessoa
{
    // Campos
    public const int idadeMinima = 12;
    public float imc = 0f;

    // Propriedades
    public int Idade {get; set
        {
            if(value < idadeMinima)
            {
                ConsoleLogger.warn($"Idade {value} é menor que a idade mínima de {idadeMinima} anos.");
            }else if(value > 120)
            {
                ConsoleLogger.warn("A idade não pode ser maior que 120 anos");
            }
            else
            {
                field = value;
            }
        }
    }

    // Metodos
    public void ExibirDados()
    {
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Idade: {Idade} anos");
        Console.WriteLine($"Peso: {Peso} kg");
        Console.WriteLine($"Altura: {Altura} m");
        Console.WriteLine($"IMC: {imc} kg/m²");
    }

    public float CalcularIMC(float peso, float altura, bool definirIMC = false)
    {
        try
        {
            if(altura <= 0.1f)
            {
                throw new Exception("Altura inválida para cálculo do IMC.");
            }

            if(peso <= 0.1f)
            {
                throw new Exception("Peso inválido para cálculo do IMC.");
            }

            float imc = (float) Math.Round(peso / Math.Pow(altura, 2), 2);
            
            if(definirIMC)
            {
                this.imc = imc;
            }

            return imc;
        }catch (Exception ex)
        {
            ConsoleLogger.error($"CalcularIMC(): {ex.Message}");
            if(definirIMC == true)
            {
                ConsoleLogger.warn("IMC não definido devido a erro no cálculo.");
            }
            return 0;
        }
    }

    // Construtores
    public Aluno(string nome, int idade, float peso, float altura)
    {
        Nome = nome;
        Idade = idade;
        Peso = peso;
        Altura = altura;
        CalcularIMC(peso, altura, true);
    }

    public Aluno(string nome, int idade, float peso) : this(nome, idade, peso, 0f)
    {
    }
    public Aluno(string nome, int idade) : this(nome, idade, 0f, 0f)
    {
    }
    public Aluno(string nome) : this(nome, 0, 0f, 0f)
    {
    }
}