using System;

namespace TraverseTree
{
    class Program
    {
        static void Main(string[] args)
        {
            // create a tree from an array of integers
            int[] intArr = new int[] { 10, 8, 20, 5, 9, 15, 25, 2, 7, 12, 19, 30, 1, 4, 11, 29, 35 };
            Node tree = new Node(intArr[0]);
            for (int i = 1; i < intArr.Length; i++)
            {
                tree.insert(intArr[i]);
            }

            //traverse the entire tree In Order
            tree.printInOrder();


            //check if tree contains a value
            Console.WriteLine("Does tree contain 40: " + tree.contains(40));
            Console.WriteLine("Does tree contain 35: " + tree.contains(35));

            Console.ReadKey();
        }
    }

    class Node
    {
        Node left, right;
        int data;
        public Node(int data)
        {
            this.data = data;
        }

        public void insert(int value)
        {
            if (value <= data)
            {
                if (left == null)
                {
                    left = new Node(value);
                }
                else
                {
                    left.insert(value);
                }
            }
            else
            {
                if (right == null)
                {
                    right = new Node(value);
                }
                else
                {
                    right.insert(value);
                }
            }
        }

        public bool contains(int value)
        {
            if (value == data)
            {
                return true;
            }
            else if (value < data)
            {
                if (left == null)
                {
                    return false;
                }
                else
                {
                    return left.contains(value);
                }
            }
            else
            {
                if (right == null)
                {
                    return false;
                }
                else
                {
                    return right.contains(value);
                }
            }
        }

        public void printInOrder()
        {
            if (left != null)
            {
                left.printInOrder();
            }
            Console.WriteLine(data);
            if (right != null)
            {
                right.printInOrder();
            }
        }
    }
}
