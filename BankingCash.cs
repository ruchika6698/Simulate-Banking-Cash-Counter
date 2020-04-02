using System;
using System.Collections;
using System.Collections.Generic;

namespace Banking_Cash_Counter
{
    class BankingCash
    {
        static void Main(string[] args)
        {
            //constant
            int BALANCE = 5000;
            int M = 3;

            //Enqueue and Dequeue
            Queue customers = new Queue();

            customers.Enqueue(1);
            customers.Enqueue(2);
            customers.Enqueue(3);
            customers.Enqueue(4);
            customers.Enqueue(5);
            customers.Enqueue(6);
            Console.WriteLine("Number of Customers in the Queue: {0}", customers.Count);

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
            }
        }
    }
}
