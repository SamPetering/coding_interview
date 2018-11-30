using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            //find pair of ints where sum = 8
            int sum = 8;

            //ORDERED LIST
            Console.WriteLine("Check Ordered List");

            int[] l1 = new int[] { 1, 2, 3, 9 };
            int[] l2 = new int[] { 1, 2, 4, 4 };

            Console.WriteLine("\n");

            //solution 1: looping entire list
            Console.WriteLine("Loop Entire List");
            Console.WriteLine(LoopEntireList(l1, sum));
            Console.WriteLine(LoopEntireList(l2, sum));

            Console.WriteLine("\n");

            //solution 2: binary search
            Console.WriteLine("Binary Search");
            Console.WriteLine(BinarySearch(l1, sum));
            Console.WriteLine(BinarySearch(l2, sum));

            Console.WriteLine("\n");

            //solution 3: comparing limits
            Console.WriteLine("Compare Limits");
            Console.WriteLine(CompareLimits(l1, sum));
            Console.WriteLine(CompareLimits(l2, sum));

            Console.WriteLine("\n");

            //UNORDERED LIST
            Console.WriteLine("Check Unordered List");

            l1 = new int[] { 3, 2, 9, 1 };
            l2 = new int[] { 4, 2, 4, 1 };

            Console.WriteLine("\n");

            Console.WriteLine("Check Compliment");
            Console.WriteLine(CheckCompliment(l1, sum));
            Console.WriteLine(CheckCompliment(l2, sum));

            Console.ReadKey();
        }

        static bool LoopEntireList(int[] list, int sum)
        {
            for (int i = 0; i < list.Count() - 1; i++)
            {
                for (int x = i + 1; x < list.Count(); x++)
                {
                    if (list[i] + list[x] == sum) { return true; }
                }
            }
            return false;
        }

        static bool BinarySearch(int[] list, int sum)
        {
            for (int i = 0; i < list.Count() - 1; i++)
            {
                int dif = sum - list[i];
                int minI = i;
                int maxI = list.Count() - 1;
                while (minI < maxI)
                {
                    int mid = (minI + maxI) / 2;
                    if (list[mid] < dif)
                    {
                        minI = mid + 1;
                    }
                    else if (list[mid] > dif)
                    {
                        maxI = mid - 1;
                    }
                    else
                    {
                        return true;
                    }

                }
            }
            return false;
        }

        static bool CompareLimits(int[] list, int sum)
        {
            int minI = 0;
            int maxI = list.Count() - 1;

            while (minI < maxI)
            {
                if (list[minI] + list[maxI] > sum)
                {
                    maxI -= 1;
                }
                else if (list[minI] + list[maxI] < sum)
                {
                    minI += 1;
                }
                else
                {
                    return true;
                }
            }
            return false;
        }

        static bool CheckCompliment(int[] list, int sum)
        {
            HashSet<int> compliments = new HashSet<int>();
            compliments.Add(sum - list[0]);
            for (int i = 1; i < list.Count(); i++)
            {
                if (compliments.Contains(list[i]))
                {
                    return true;
                }
                else
                {
                    compliments.Add(sum - list[i]);
                }
            }
            return false;
        }
    }
}
