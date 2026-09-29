namespace AcademiaSystem.Models;

internal class Aluno
{

    // Propriedades
    public string Nome { get; set
        {
            if (!string.IsNullOrWhiteSpace(value))
            {
                field = value;
            }
        }
    }
    public int Idade { get; set
        {
            if (value >= idadeMinima)
            {
                field = value;
            }
        }
    }
    public float Peso { get;
        set
        {
            if(value > 0)
            {
                field = value;
            }
        }    
    }
    public float Altura { get; set
        {
            if (value > 0)
            {
                field = value;
            }   
        }
    }
    public string Matricula
    {
        get { return _matricula; }
        private set { _matricula = $"{Nome}_{Idade}"; }
    }

    // Campos
    private string _matricula;
    private int idadeMinima = 12;

    // Métodos
    public void ExibirDados()
    {
        Console.WriteLine("Nome: " + Nome);
        Console.WriteLine("Idade: " + Idade);
        Console.WriteLine("Peso: " + Peso);
        Console.WriteLine("Altura: " + Altura);
        Console.WriteLine("IMC: " + CalcularIMC());
        Console.WriteLine("Matricula: " + Matricula);
    }

    public float CalcularIMC(){
        if(Altura > 0) {
           return Peso / (float) Math.Pow(Altura, 2);
        }

        return 0;
    }
    public float AdicionarPeso(float value) => Peso += value;
    public float RemoverPeso(float value) => Peso -= value;
    public float AdicionarAltura(float value) => Altura += value;
    public float RemoverAltura(float value) => Altura -= value;
    public int AdicionarIdade(int value) => Idade += value;
    public int RemoverIdade(int value) => Idade -= value;

    // Construtores
    public Aluno(string Nome, int Idade, float Peso, float Altura)
    {
        this.Nome = Nome;
        this.Idade = Idade;
        this.Peso = Peso;
        this.Altura = Altura;
        Matricula = "gerar";
    }

    public Aluno(string Nome, int Idade, float Peso)
    {
        this.Nome = Nome;
        this.Idade = Idade;
        this.Peso = Peso;
        Matricula = "gerar";
    }

    public Aluno(string Nome, int Idade)
    {
        this.Nome = Nome;
        this.Idade = Idade;
        Matricula = "gerar";
    }

    public Aluno(string Nome)
    {
        this.Nome = Nome;
        Matricula = "gerar";
    }
}