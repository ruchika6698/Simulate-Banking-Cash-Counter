using System;
using System.Collections.Generic;
using System.Text;

namespace Banking_Cash_Counter
{
	class Stack
	{ 
		public const int MAX = 1000;
		int top;
		/// <summary>
		///	Maximum size of Stack 
		/// </summary>
		int[] a = new int[MAX];  

		public bool isEmpty()
		{
			return (top < 0);
		}

		/// <summary>
		///	Push Customers into stack
		/// </summary>
		public bool Push(int x)
		{
			if (top >= (MAX - 1))
			{
				Console.Write("Stack Overflow");
				return false;
			}
			else
			{
				a[++top] = x;
				Console.Write(x + " Elements pushed into stack");
				return true;
			}
		}

		/// <summary>
		///	remove Customers from stack
		/// </summary>
		public int Pop()
		{
			if (top < 0)
			{
				Console.Write("Stack Underflow");
				return 0;
			}
			else
			{
				int x = a[top--];
				return x;
			}
		}
	}
}
