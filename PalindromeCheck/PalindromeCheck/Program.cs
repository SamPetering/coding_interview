using System;

namespace PalindromeCheck
{
    class Program
    {
        static void Main(string[] args)
        {
            while (0 < 1)
            {
            Console.WriteLine("Please enter a string: ");
            string str = Console.ReadLine();
            if (PalindromeCheck(str.ToUpper()))
            {
                Console.WriteLine(str + " is a palindrome!");
            }
            else
            {
                Console.WriteLine(str + " is not a palindrome.");
            }
                Console.WriteLine("\n");
            }
        }
        static bool PalindromeCheck(string str)
        {
            int left = 0;
            int right = str.Length - 1;
            while(left < right)
            {
                if (str[left] != str[right])
                {
                    return false;
                }
                else
                {
                    left += 1;
                    right -= 1;
                }
            }
            return true;
        }
    }
}
