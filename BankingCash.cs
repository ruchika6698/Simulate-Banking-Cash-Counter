using System;
using System.Collections;
using System.Collections.Generic;

namespace Banking_Cash_Counter
{
    partial class BankingCash
    {
        //Stack
        class Stack
        {
            public int Count { get; private set; }
            private int[] stack = new int[6];
            public Stack(int size)
            {
                stack = new int[size];
                Count = 0;
            }
            public Stack()
            {
            }
            //push customer 
            public void Push(int s)
            {
                if (Count != stack.Length)
                {
                    stack[Count++] = s;
                }
                else
                {
                    Console.WriteLine("Stack is full!");
                }
            }
            //pop Customer after operations Completed
            public int Pop()
            {
                int s = -1;
                if (Count == 0)
                {
                    Console.WriteLine("Stack is empty!");
                }
                else
                {
                    s = stack[--Count];
                }
                return s;
            }
            public void Display()
            {
                if (Count == 0)
                {
                    Console.WriteLine("Stack is empty!");
                }
                else
                {
                    Console.WriteLine("Stack data:");
                    for (int i = Count - 1; i >= 0; i--)
                        Console.WriteLine(stack[i]);
                }
            }
        }

        //Linked List 
        class LinikedList
        {
            internal class Node
            {
                internal int data;
                internal Node next;
                public Node(int d)
                {
                    data = d;
                    next = null;
                }
            }
            internal class SingleLinkedList
            {
                internal Node head;
            }
            internal void Insert(SingleLinkedList singlyList, int new_data)
            {
                Node new_node = new Node(new_data);
                if (singlyList.head == null)
                {
                    singlyList.head = new_node;
                    return;
                }
                Node lastNode = GetLastNode(singlyList);
                lastNode.next = new_node;
            }

            internal void Delete(SingleLinkedList singlyList, int key)
            {
                Node temp = singlyList.head;
                Node prev = null;
                if (temp != null && temp.data == key)
                {
                    singlyList.head = temp.next;
                    return;
                }
                while (temp != null && temp.data != key)
                {
                    prev = temp;
                    temp = temp.next;
                }
                if (temp == null)
                {
                    return;
                }
                prev.next = temp.next;
            }

            private Node GetLastNode(SingleLinkedList singlyList)
            {
                throw new NotImplementedException();
            }
        }



        static void Main(string[] args)
        {
            //constant
            int BALANCE = 5000;
            int M = 3;
            //Enqueue and Dequeue
            Queue customers = new Queue();
            Stack s = new Stack();
            LinkedList list = new LinkedList();
            Hashtable h = new Hashtable();

            customers.Enqueue(1);
            customers.Enqueue(2);
            customers.Enqueue(3);
            customers.Enqueue(4);
            customers.Enqueue(5);
            customers.Enqueue(6);
            Console.WriteLine("Number of Customers in the Queue: {0}", customers.Count);

            s.Push(1);
            s.Push(2);
            s.Push(3);
            s.Push(4);
            s.Push(5);
            s.Push(6);
            Console.WriteLine("Number of Customers in the Stack:{0}", s.Count);
/*
            list.Insert(1);
            list.Insert(2);
            list.Insert(3);
            list.Insert(4);
            list.Insert(5);
            list.Insert(6);
            list.Print();
            */
            h.Add(1, "Customer");
            h.Add(2, "Customer");
            h.Add(3, "Customer");
            h.Add(4, "Customer");
            h.Add(5, "Customer");
            h.Add(6, "Customer");
            Console.WriteLine("Initial list:");
            foreach (var key in h.Keys)
            {
                Console.WriteLine("{0},{1}", key, h[key]);
            }

                Console.WriteLine("Welcome to Banking Cash Counter");
                Console.WriteLine("1.Deposit cash");
                Console.WriteLine("2.Withdraw cash");
                Console.WriteLine("3.Check Balance");
                Console.WriteLine("Choose the operation You Want to perform:");

                while (M <= 3)
                {
                    int n = Convert.ToInt32(Console.ReadLine());
                    switch (n)
                    {
                        case 1:
                            Console.WriteLine("Enter Money to deposit:");
                            int deposit = Convert.ToInt32(Console.ReadLine());
                            BALANCE = BALANCE + deposit;
                            Console.WriteLine("Your Money Has been Successfully Deposit:" + deposit);
                            Console.WriteLine("Your Current balanced after money deposit:" + BALANCE);
                            break;
                        case 2:
                            Console.WriteLine("Enter Money to Withdraw:");
                            int withDraw = Convert.ToInt32(Console.ReadLine());
                            BALANCE = BALANCE - withDraw;
                            Console.WriteLine("Your Current balanced after money withdraw:" + BALANCE);
                            break;
                        case 3:
                            Console.WriteLine("Current Balance in Your Account:" + BALANCE);
                            break;
                        default:
                            Console.WriteLine("Exit");
                            break;
                    }
                    Console.WriteLine(customers.Dequeue());
                    Console.WriteLine("Number of Customers in the Queue: {0}", customers.Count);
                    Console.WriteLine(s.Pop() + " Popped from stack");
                   // list.Delete(1);
                    h.Remove(1);
                    Console.WriteLine("New list after removing an item: ");
                    foreach (object key in h.Keys)
                    {
                        Console.WriteLine("{0},{1}", key, h[key]);
                    }
                }
        }
    }
}
