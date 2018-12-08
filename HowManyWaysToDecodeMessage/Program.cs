using System;

namespace HowManyWaysToDecodeMessage
{
    class Program
    {
        static void Main(string[] args)
        {
            string data = "21234";
            int[] memo = new int[data.Length + 1];
            Console.WriteLine(num_ways(data, data.Length, memo));
            Console.ReadKey();
        }

        static int num_ways(string data, int k, int[] memo)
        {
            if (k == 0)
                return 1;

            int s = data.Length - k;

            if (data[s] == '0')
                return 0;

            if (memo[k] != 0)
                return memo[k];

            int result = num_ways(data, k - 1, memo);

            if (k >= 2 && Convert.ToInt32(Convert.ToString(data[s]) + Convert.ToString(data[s + 1])) <= 26)
                result += num_ways(data, k - 2, memo);

            memo[k] = result;
            return result;
        }
    }
}
