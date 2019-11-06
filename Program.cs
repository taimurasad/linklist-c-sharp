using System;

namespace LinkList
{


    public class LinkedList
    {
        private Node head;

        public void DisplayAllNodes()
        {
            Node current = head;
            while (current != null)
            {
                Console.WriteLine(current.data);
                current = current.next;
            }
        }

        public void AddFirst(Object data)
        {
            Node toAdd = new Node();

            toAdd.data = data;
            toAdd.next = head;

            head = toAdd;
        }

        public void AddLast(Object data)
        {
            if (head == null)
            {
                head = new Node();

                head.data = data;
                head.next = null;
            }
            else
            {
                Node toAdd = new Node();
                toAdd.data = data;

                Node current = head;
                while (current.next != null)
                {
                    current = current.next;
                }

                current.next = toAdd;
            }
        }
    }

    public class Node
    {
        public Node next;
        public Object data;
    }

    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Add First:");
            LinkedList list1 = new LinkedList();

            list1.AddFirst("Get");
            list1.AddFirst("Set");
            list1.AddFirst("Go");
            list1.DisplayAllNodes();

            Console.WriteLine();

            Console.WriteLine("Add Last:");
            LinkedList list2 = new LinkedList();

            list2.AddLast("Get");
            list2.AddLast("Set");
            list2.AddLast("Go");
            list2.DisplayAllNodes();

        }
    }
}
