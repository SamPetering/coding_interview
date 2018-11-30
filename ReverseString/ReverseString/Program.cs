using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseString
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please enter a string to reverse: ");
            Console.WriteLine(reverse(Console.ReadLine()));
            Console.ReadLine();
        }
        public static string reverse(string str)
        {
            string rev = "";
            char[] arr = str.ToCharArray();
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                rev += arr[i];
            }
            return rev;
        }
    }
}
