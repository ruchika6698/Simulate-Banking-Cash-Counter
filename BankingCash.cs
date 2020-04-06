using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Banking_Cash_Counter
{
    partial class BankingCash
    {
        private static int key;
        private static int data;

        public static int Key { get => key; set => key = value; }
        public static int Data { get => data; set => data = value; }

        /// <summary>
        /// Main Method
        /// </summary>
        static void Main(string[] args)
        {
            Queue customers = new Queue(100);
            Stack s = new Stack();
            LinkedList list = new LinkedList();
            Hash hash = new Hash();
            
            int BALANCE = 5000;
            int M = 3;
            /// <summary>
            /// Take User Input
            /// </summary>
            int[] customerArray = new int[100];
            Console.Write("Number of Customers in the row :");
            int Customer = Convert.ToInt32(Console.ReadLine());
           
            for (int i = 1; i <= Customer; i++)
            {
                Console.Write("Customer {0}: ", i);
                customerArray[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.Write("\nNumber of Customers in the row : \n");
            for (int i = 1; i <= Customer; i++)
            {
                Console.WriteLine("Customers in Queue:");
                customers.enqueue(customerArray[i]);
                customers.display();
                Console.Write("\n");
                Console.WriteLine("Customers in list:");
                list.insert(customerArray[i]);
                list.print();
                Console.Write("\n");
                Console.WriteLine("Customers in Stack:");
                s.Push(customerArray[i]);
                Console.Write("\n");
                Console.WriteLine("Customers in HashTable:");
                hash.add(customerArray[i], "Customer");
                hash.show();
                Console.Write("\n");
            }
            Console.Write("\n\n");

            /// <summary>
            /// Banking Cash deposit,Withdraw,balanced.
            /// </summary>
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

                /// <summary>
                /// Remove element from queue,stack,Linked list,hash
                /// </summary>
                customers.dequeue();
                Console.Write("one customer remove from queue\n");
                Console.WriteLine(s.Pop() + " Popped from stack \n");
                list.delete();
                Console.WriteLine("One Customer removed from list \n");
                hash.remove(1);
                Console.WriteLine("One hash table is removed");
            }

        }
    }
}