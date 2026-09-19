namespace Pessoas{

partial class Pessoa
{
    public string Nome {get; set;}
    public string Sobrenome {get; set;}
    public int AnoNascimento {get; set;}
    private int _idade;
    private int _cpf;

    public int Idade
    {
        get
        {
            return _idade;
        }
        set
        {
            _idade = CalcularIdade(AnoNascimento);
        }
    }

    public int Cpf
    {
        get
        {
            return _cpf;
        }

        set
        {
            _cpf = value;
        }  
    }
}
}