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
    /// <summary>
    /// CORRECT BIGINTEGER AFTER
    /// </summary>
    /// <param name="n"></param>
    /// <param name="k"></param>
    /// <returns></returns>
    public static BigInteger Combinacao(int n, int k)
    {
        return Fatorial(n) / (Fatorial(k) * Fatorial(n - k));
    }
}