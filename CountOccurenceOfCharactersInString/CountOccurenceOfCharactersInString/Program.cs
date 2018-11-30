using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountCharacterInString
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Enter a string to get the count of its characters: ");
                Dictionary<char, int> result = CharacterCount(Console.ReadLine());
                Console.WriteLine("\n");
                foreach (var r in result)
                {
                    Console.WriteLine("{0} - {1}", r.Key, r.Value);
                }
                Console.WriteLine("\n");
            }
        }
        static Dictionary<char, int> CharacterCount(string input)
        {
            Dictionary<char, int> result = new Dictionary<char, int>();
            foreach (var c in input)
            {
                if (!char.IsWhiteSpace(c))
                {
                    if (result.Keys.Contains(c))
                    {
                        result[c]++;
                    }
                    else
                    {
                        result.Add(c, 1);
                    }
                }
            }
            return result;
        }
    }
}
