using System;
using System.Collections;
using System.Collections.Generic;

namespace Banking_Cash_Counter
{
    class BankingCash
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
        static void Main(string[] args)
        {
        //constant
            int BALANCE = 5000;
            int M = 3;
            //Enqueue and Dequeue
            Queue customers = new Queue();
            Stack s = new Stack();

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
                        Console.WriteLine("Current Balance in Your Account:"+ BALANCE);
                        break;
                    default:
                        Console.WriteLine("Exit");
                        break;
                }
                Console.WriteLine(customers.Dequeue());
                Console.WriteLine("Number of Customers in the Queue: {0}", customers.Count);
                Console.WriteLine(s.Pop() + " Popped from stack");
            }
        }
    }
}
