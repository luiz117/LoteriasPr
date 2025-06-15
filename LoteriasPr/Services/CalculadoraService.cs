using LoteriasPr.Models;
using LoteriasPr.Utils;
using System.Numerics;

namespace LoteriasPr.Services;

public class CalculadoraService
{
    public BigInteger CalcularProbabilidade(Aposta aposta)
    {
        var totalComb = MatematicaHelper.Combinacao(aposta.TotalNumeros, aposta.NumerosSorteados);
        var suasComb = MatematicaHelper.Combinacao(aposta.NumerosApostados, aposta.NumerosSorteados);

        return totalComb / suasComb;
    }
}