using System;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue myQ = new Queue();
            myQ.add(10);
            myQ.add(15);
            myQ.add(20);
            myQ.add(25);

            while (!myQ.isEmpty())
            {
                Console.WriteLine(myQ.remove());
            }
            Console.ReadKey();
        }
    }
    class Queue
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

        private Node head;
        private Node tail;

        public bool isEmpty()
        {
            return head == null;
        }

        public int peek()
        {
            if (isEmpty())
                return -1;
            else
                return head.data;
        }

        public void add(int data)
        {
            Node node = new Node(data);
            if (tail != null)
            {
                tail.next = node;
            }
            tail = node;
            if (head == null)
            {
                head = node;
            }
        }
        public int remove()
        {
            int data = head.data;
            head = head.next;
            if (head == null)
            {
                tail = null;
            }
            return data;
        }
    }
}
