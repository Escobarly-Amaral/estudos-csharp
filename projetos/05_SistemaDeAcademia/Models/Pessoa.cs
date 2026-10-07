namespace AcademiaSystem.Models;

internal class Pessoa
{
    // Propriedades
    public string Nome
    {
        get;
        set{
            if (value.Length < 3)
            {
                ConsoleLogger.warn("O nome deve ter no mínimo 3 caracteres");
            }else if(value.Length > 50)
            {
                ConsoleLogger.warn("O nome deve ter no máximo 50 caracteres");
            }else if (string.IsNullOrEmpty(value))
            {
                ConsoleLogger.warn("O nome não pode ser nulo ou vazio");
            }
            else
            {
                field = value;
            }
        }
    }

    public int Idade
    {
        get;
        set{
           if(value > 120)
            {
                ConsoleLogger.warn("A idade não pode ser maior que 120 anos");
            }else if(value < 0)
            {
                ConsoleLogger.warn("A idade não pode ser negativa");
            }
            else
            {
                field = value;
            }
        }
    }
    public float Peso
    {
        get;
        set{
           if(value < 0 || value > 500)
            {
                ConsoleLogger.warn("O peso não pode ser negativo ou maior que 500 kg");
            }
            else
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
            if(value < 0 || value > 3)
            {
                ConsoleLogger.warn("A altura não pode ser negativa ou maior que 3 metros");
            }
            else
            {
                field = value;
            }
        }
    }
}