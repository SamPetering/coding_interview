using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibBottomUp
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 20;
            Console.WriteLine(fib(n));
            Console.ReadKey();
        }

        static int fib(int n)
        {

            if (n == 1 || n == 2)
                return 1;
            int[] bottom_up = new int[n + 1];
            bottom_up[1] = 1;
            bottom_up[2] = 1;
            for (int i = 3; i <= n; i++)
            {
                bottom_up[i] = bottom_up[i - 1] + bottom_up[i - 2];
            }
            return bottom_up[n];
        }
    }
}
