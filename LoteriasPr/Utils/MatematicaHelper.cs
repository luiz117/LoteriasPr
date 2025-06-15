using System.Numerics;

namespace LoteriasPr.Utils;

public static class MatematicaHelper
{
    public static BigInteger Fatorial(int n)
    {
        BigInteger resultado = 1;
        for (int i = 2; i <= n; i++)
            resultado *= i;
        return resultado;
    }

    public static BigInteger Combinacao(int n, int k)
    {
        return Fatorial(n) / (Fatorial(k) * Fatorial(n - k));
    }
}