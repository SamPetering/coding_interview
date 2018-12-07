using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountOfSetsEqualToSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int total = 16;
            int[] A = new int[] { 1, 2, 4, 6, 10, 11, 12, 13, 14, 15, 16 };
            Console.WriteLine(count_sets(total, A));
            Console.ReadKey();
        }

        public static int count_sets(int total, int[] A)
        {
            Dictionary<string, int> memo = new Dictionary<string, int>();
            return rec(A, total, A.Length - 1, memo);
        }

        public static int rec(int[] A, int total, int i, Dictionary<string, int> memo)
        {
            string key = total + ":" + i;
            if (memo.ContainsKey(key))
                return memo[key];
            int result;

            if (total == 0)
                return 1;
            if (total < 0)
                return 0;
            if (i < 0)
                return 0;
            if (total < A[i])
                result = rec(A, total, i - 1, memo);
            else
                result = rec(A, total - A[i], i - 1, memo) + rec(A, total, i - 1, memo);

            memo[key] = result;
            return result;
        }
    }
}
