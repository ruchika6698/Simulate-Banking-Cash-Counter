using System;
using System.Collections;

namespace Banking_Cash_Counter
{
    class BankingCash
    {
        private static int employeeMonthlyWage;
        static void Main(string[] args)
        {
            int BALANCE = 5000;
            Queue customers = new Queue();
            

            while (true)
            {
                Console.WriteLine("Welcome to Banking Cash Counter");
                Console.WriteLine("1.Deposit cash");
                Console.WriteLine("2.Withdraw cash");
                Console.WriteLine("3.Check Balance");
                Console.WriteLine("4.Exit");
                Console.WriteLine("Choose the operation You Want to perform:");
                int n = Convert.ToInt32(Console.ReadLine());
                switch (n)
                {
                    case 1:
                        Console.WriteLine("Enter Money to deposit:");
                        int deposit = Convert.ToInt32(Console.ReadLine());
                        BALANCE = BALANCE + deposit;
                        customers.Enqueue(BALANCE);
                        Console.WriteLine("Your Money Has been Successfully Deposit:" + deposit);
                        break;
                    case 2:
                        Console.WriteLine("Enter Money to Withdraw:");
                        int withDraw = Convert.ToInt32(Console.ReadLine());
                        BALANCE = BALANCE - withDraw;
                        if (BALANCE == 0)
                        {
                            //customers.Dequeue(BALANCE);
                            Console.WriteLine("You have withdraw:"+ withDraw + "You have 0 balance in your account");
                        }
                        else
                        {
                            //customers.Dequeue(BALANCE);
                            Console.WriteLine("Your Money Has been withdraw:"+ withDraw);
                        }
                        break;
                    
                    case 3:
                        Console.WriteLine("Current Balance in Your Account:"+ BALANCE);
                        break;
                    case 4:
                        Console.WriteLine("Exit");
                        break;
                    default:
                        break;
                }

            }
        }
    }
}
