using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecursiveStaircaseProblem
{
    class Program
    {
        static void Main(string[] args) {
            // for a staircase of size n, if you can only move 1 or 2 steps at a time
            // how many unique paths are there up the staircase?


            // exampls:
            // if n = 4 there are 5 unique paths:
            // 1 2 3 4
            // 1 _ 3 4
            // 1 2 _ 4
            // _ 2 3 4
            // _ 2 _ 4
            int n = 3;
            int[] memo = new int[n + 1];
            Console.WriteLine(num_ways(n, memo));

            // for a staircase of size n, where you can move by any number of steps in a given array
            int[] stepSizeArr = new int[] { 1, 2, 3, 5 };
            memo = new int[n + 1];
            Console.WriteLine(num_ways_VariableStep(n, stepSizeArr, memo));
            Console.ReadKey();
        }

        static int num_ways(int n, int[] memo)
        {
            if (n == 0 || n == 1)
                return 1;
            if (memo[n] != 0)
                return memo[n];
            int result = num_ways(n - 1, memo) + num_ways(n - 2, memo);
            memo[n] = result;
            return result;
        }

        static int num_ways_VariableStep(int n, int[] stepSizeArr, int[] memo)
        {

            if (n == 0 || n == 1)
                return 1;
            if (memo[n] != 0)
                return memo[n];

            int result = 0;

            foreach(var step in stepSizeArr)
            {
                result += n - step > -1 ? num_ways_VariableStep(n - step, stepSizeArr, memo) : 0;
            }
            memo[n] = result;
            return result;
        }
    }
}
