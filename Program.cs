using System;
using System.Numerics;

namespace FibonacciApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number of Fibonacci elements:");
            int n = int.Parse(Console.ReadLine()!);

            var sequence = Fibonacci.Generate(n);

            Console.WriteLine("\nFibonacci Sequence:");
            foreach (var num in sequence)
            {
                Console.Write(num + " ");
            }

            Console.WriteLine("\n\nMax Value: " + Fibonacci.GetMax(sequence));
            Console.WriteLine("Iterations: " + Fibonacci.GetIterations(sequence));

            Console.WriteLine("\n--- RANGE TEST ---");

            Console.Write("Enter start: ");
            int start = int.Parse(Console.ReadLine()!);

            Console.Write("Enter end: ");
            int end = int.Parse(Console.ReadLine()!);

            for (int i = start; i <= end; i++)
            {
                var seq = Fibonacci.Generate(i);

                Console.WriteLine($"\nN = {i}");
                Console.WriteLine("Max = " + Fibonacci.GetMax(seq));
                Console.WriteLine("Iterations = " + Fibonacci.GetIterations(seq));
            }
        }
    }
}