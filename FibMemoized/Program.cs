using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibMemoized
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 20;
            int[] A = new int[n + 1];
            Console.WriteLine(fib(n, A));
            Console.ReadKey();
        }

        static int fib(int n, int[] memo)
        {
            if (memo[n] != 0) return memo[n];
            int result;
            if (n == 1 || n == 2)
                result = 1;
            else
                result = fib(n - 1, memo) + fib(n - 2, memo);
            memo[n] = result;
            return result;
        }
    }
}
