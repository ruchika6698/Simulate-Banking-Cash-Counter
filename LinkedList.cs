using System;

namespace Banking_Cash_Counter
{
    public class Node
    {
        public Node next;
        public int data;
    }
    /// <summary>
    /// Create a Linked list class
    /// </summary>
    public class LinkedList
    {
        private Node head;
        /// <summary>
        /// method to print a linked last
        /// </summary>
        public void print()
        {
            Node current = head;
            while (current != null)
            {
                Console.WriteLine(current.data);
                current = current.next;
            }
        }
        /// <summary>
        /// method to insert Customer into list
        /// </summary>
        public void insert(int data)
        {
            if (head == null)
            {
                head = new Node();

                head.data = data;
                head.next = null;
            }
            else
            {
                Node Add = new Node();
                Add.data = data;

                Node current = head;
                while (current.next != null)
                {
                    current = current.next;
                }

                current.next = Add;
            }
        }
        /// <summary>
        /// method to delete Customer into list
        /// </summary>
        public void delete()
        {
            head = null;
        }
    }
}
