using System.Numerics;

namespace Combinations
{
    public static class Math
    {
        private static BigInteger Factorial(int i)
        {
            if (i <= 1)
                return 1;

            return (BigInteger)i * Factorial(i - 1);
        }

        private static BigInteger FactorialDivision(int topFactorial, int divisorFactorial)
        {
            BigInteger result = 1;

            for (int i = topFactorial; i > divisorFactorial; i--)
                result *= (BigInteger)i;

            return result;
        }

        public static BigInteger Permutations(int n, int k)
        {
            // naive: return Factorial(n) / Factorial(n - r);

            return FactorialDivision(n, n - k);
        }

        public static BigInteger Combinations(int n, int k)
        {
            // naive: return Factorial(n) / (Factorial(r) * Factorial(n - r));

            //Console.WriteLine("Permutations : {0}", Permutations(n, r));
            //Console.WriteLine("Factorial    : {0}", Factorial(r));

            return Permutations(n, k) / Factorial(k);

            //return Factorial(n) / (Factorial(k) * Factorial(n - k));
        }
    }
}
