using System;
using System.Collections.Generic;
using System.Text;

namespace Banking_Cash_Counter
{
    class Queue
    {
        private static int front, rear, capacity;
        private static int[] queue;

        public Queue(int c)
        {
            front = rear = 0;
            capacity = c;
            queue = new int[capacity];
        }

        /// <summary>
		///function to insert an element & at the rear of the queue  
		/// </summary>
        public void enqueue(int data)
        {
            if (capacity == rear)
            {
                Console.Write("\nQueue is full\n");
                return;
            }
            else
            {
                queue[rear] = data;
                rear++;
            }
            return;
        }

        /// <summary>
        ///  function to delete an element & from the front of the queue  
        /// </summary>
        public void dequeue()
        {
            if (front == rear)
            {
                Console.Write("\nQueue is empty\n");
                return;
            }
            else
            {
                for (int i = 0; i < rear - 1; i++)
                {
                    queue[i] = queue[i + 1];
                }
                if (rear < capacity)
                {
                    queue[rear] = 0;
                }
                rear--;
            }
            return;
        }

        /// <summary>
        /// print queue elements  
        /// </summary>
        public void display()
        {
            int i;
            if (front == rear)
            {
                Console.Write("\nQueue is Empty\n");
                return;
            }
            for (i = front; i < rear; i++)
            {
                Console.Write(" {0} ", queue[i]);
            }
            return;
        }
    }
}