namespace LoteriasPr.Models;

public class Aposta
{
    public int Min { get; }
    public int Max { get; }
    public int TotalNumeros => Max - Min + 1;
    public int NumerosSorteados { get; }
    public int NumerosApostados { get; }

    public Aposta(int min, int max, int sorteados, int apostados)
    {
        if (apostados < sorteados)
            throw new ArgumentException("Números apostados devem ser >= números sorteados.");

        Min = min;
        Max = max;
        NumerosSorteados = sorteados;
        NumerosApostados = apostados;
    }
}
