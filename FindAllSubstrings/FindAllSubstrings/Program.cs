using System;
using System.Collections.Generic;

namespace FindAllSubstrings
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Input a string to get all possible substrings:");
                foreach (var s in GetSubstrings(Console.ReadLine()))
                {
                    Console.WriteLine(s);
                }
                Console.WriteLine("\n");
            }
        }
        static HashSet<string> GetSubstrings(string str)
        {
            HashSet<string> result = new HashSet<string>();
            for (int i = 0; i < str.Length; i++)
            {
                int right = str.Length - i;
                while (right > 0)
                {
                    string sub = str.Substring(i, right).Trim();
                    if (!result.Contains(sub))
                    {
                        result.Add(sub);
                    }
                    right--;
                }
            }
            return result;
        }
    }
}
