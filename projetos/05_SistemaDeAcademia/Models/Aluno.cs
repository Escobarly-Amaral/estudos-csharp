namespace AcademiaSystem.Models;

internal class Aluno
{
    // Campos
    private string _matricula;
    public const int idadeMinima = 12;
    // Propriedades
    public string Nome
    {
        get;
        set
        {
            if (!string.IsNullOrWhiteSpace(value) && value.Length >= 4)
            {
                field = value;
            }
        }
    }
    public int Idade
    {
        get;
        set
        {
          if(value >= idadeMinima)
            {
                field = value;
            }  
        }
    }
    public float Altura
    {
        get;
        set
        {
           if(value > 0)
            {
                field = value;
            } 
        }
    }

    public float Peso
    {
        get;
        set
        {
            if(value > 0)
            {
                field = value;
            }
        }
    }
    public string Matricula
    {
        get
        {
            return _matricula;
        }
        private set
        {
            if(string.IsNullOrWhiteSpace(_matricula)) _matricula = $"{Nome}_{Idade}";
        }
    }
    public float Imc
    {
        get;
        private set;
    }
    // Métodos
    private void CalcularImc()
    {
        if (Altura > 0 && Peso > 0)
        {
            Imc = Peso / (Altura * Altura);
        }
    }
    public void ExibirDados()
    {
        Console.WriteLine("Matricula: " + Matricula);
        Console.WriteLine("Nome: " + Nome);
        Console.WriteLine("Idade: " + Idade);
        Console.WriteLine("Altura: " + Altura);
        Console.WriteLine("Peso: " + Peso);
        Console.WriteLine("IMC: " + Imc + "\n");
    }
    public float AumentarPeso(float value) => Peso += value;
    public float DiminuirPeso(float value) => Peso -= value;
    public float AumentarAltura(float value) => Altura += value;
    public float DiminuirAltura(float value) => Altura -= value;
    public int AumentarIdade(int value) => Idade += value;
    public int DiminuirIdade(int value) => Idade -= value;
    // Construtores
    public Aluno(string Nome, int Idade, float Peso, float Altura){
        this.Nome = Nome;
        this.Idade = Idade;
        this.Altura = Altura;
        this.Peso = Peso;
        this.Matricula = "gerar";
        CalcularImc();
    }
    public Aluno(string Nome, int Idade, float Peso) : this(Nome, Idade, Peso, 0){
    }
    public Aluno(string Nome, int Idade) : this(Nome, Idade, 0){
    }
}