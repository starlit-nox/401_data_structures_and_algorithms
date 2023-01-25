using System;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        /// <summary>
        /// Recursive Fibonacci 
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        static int Fibonacci(int n)
        {
            if (n <= 1)
                return n;

            return Fibonacci(n - 1) + Fibonacci(n - 2);
        }

        /// <summary>
        /// Non recursive fib iterative
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static long Fib(int n)
        {
            if (n < 2)
                return n;
            long[] f = new long[n + 1];
            f[0] = 0;
            f[1] = 1;

            for (int i = 2; i <= n; i++)
            {
                f[i] = f[i - 1] + f[i - 2];
            }
            return f[n];
        }
    }
}
