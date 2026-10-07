using AcademiaSystem.Models;

internal class Treino
{
    public int Repeticoes {get;set;}
    public int Series {get;set;}
    public float Carga {get;set;}
    public static float CalcularCargaTotal(int repetiçoes, float carga) => (float) repetiçoes * carga;
    
}