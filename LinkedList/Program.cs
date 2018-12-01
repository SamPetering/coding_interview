using System;

namespace LinkedList
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] intArr = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            LinkedList myList = new LinkedList();

            // fill nodes in list
            foreach(var i in intArr)
            {
                myList.append(i);
            }

            // print each node
            myList.printAllValues();

            Console.WriteLine("\nPrepending new values to Linked List\n");

            // prepend a new array
            int[] newArr = new int[] { 11, 12, 13, 14, 15 };
            foreach(var i in newArr)
            {
                myList.prepend(i);
            }

            // print each node
            myList.printAllValues();

            Console.WriteLine("\nDeleting initial values from Linked List\n");

            // delete inital array from linked list
            foreach (var i in intArr)
            {
                myList.deleteWithValue(i);
            }

            // print each node
            myList.printAllValues();

            Console.WriteLine("\nDelete head from Linked List\n");

            //delete the head node
            myList.deleteWithValue(myList.head.data);

            // print each node
            myList.printAllValues();

            Console.ReadKey();
        }
    }

    public class Node
    {
        public Node next;
        public int data;
        public Node(int data)
        {
            this.data = data;
        }

    }

    public class LinkedList
    {
        public Node head;
        public void append(int data)
        {
            if (head == null)
            {
                head = new Node(data);
                return;
            }
            Node current = head;
            while (current.next != null)
            {
                current = current.next;
            }
            current.next = new Node(data);
        }

        public void prepend(int data)
        {
            Node newHead = new Node(data);
            newHead.next = head;
            head = newHead;
        }

        public void deleteWithValue(int data)
        {
            if (head == null) return;
            if (head.data == data)
            {
                head = head.next;
                return;
            }

            Node current = head;
            while (current.next != null)
            {
                if(current.next.data == data)
                {
                    current.next = current.next.next;
                    return;
                }
                current = current.next;
            }
        }

        public void printAllValues()
        {
            if (head != null)
            {
                Node current = head;
                while (current != null)
                {
                    Console.WriteLine(current.data);
                    current = current.next;
                }
            }
            else
            {
                Console.WriteLine("null");
            }
            return;
        }
    }

}
