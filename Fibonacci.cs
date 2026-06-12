using System;
using System.Numerics;

namespace FibonacciApp
{
    public class Fibonacci
    {
        public static BigInteger[] Generate(int n)
        {
            BigInteger[] sequence = new BigInteger[n];

            if (n > 0) sequence[0] = 1;
            if (n > 1) sequence[1] = 2;

            for (int i = 2; i < n; i++)
            {
                sequence[i] = sequence[i - 1] + sequence[i - 2];
            }

            return sequence;
        }

        public static BigInteger GetMax(BigInteger[] arr)
        {
            BigInteger max = arr[0];
            foreach (var num in arr)
            {
                if (num > max)
                    max = num;
            }
            return max;
        }

        public static int GetIterations(BigInteger[] arr)
        {
            return arr.Length;
        }
    }
}