using System;

namespace Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack myStack = new Stack();
            myStack.push(5);
            myStack.push(10);
            myStack.push(15);
            myStack.push(20);
            while (!myStack.isEmpty())
            {
                Console.WriteLine(myStack.pop());
            }
            Console.ReadKey();
        }
    }

    class Stack
    {
        private class Node
        {
            public int data;
            public Node next;
            public Node(int data)
            {
                this.data = data;
            }
        }

        private Node top;

        public bool isEmpty()
        {
            return top == null;
        }

        public int peek()
        {
            if (isEmpty()) return -1;
            return top.data;
        }

        public void push(int data)
        {
            Node node = new Node(data);
            node.next = top;
            top = node;
        }

        public int pop()
        {
            int data = top.data;
            top = top.next;
            return data;
        }
    }
}
