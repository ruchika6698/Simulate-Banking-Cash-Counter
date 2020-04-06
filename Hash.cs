using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Banking_Cash_Counter
{
    class Hash
    {
        /// <summary>
        /// class for hash entery
        /// </summary>
        class hashentry
        {
            int key;
            string data;
            public hashentry(int key, string data)
            {
                this.key = key;
                this.data = data;
            }
            public int getkey()
            {
                return key;
            }
            public string getdata()
            {
                return data;
            }
        }

        private const int maxSize = 10;                       //our table size
        hashentry[] table;
        public IEnumerable<object> Key { get; internal set; }
        public IEnumerable<object> Keys { get; internal set; }

        public Hash()
        {
            table = new hashentry[maxSize];
            for (int i = 0; i < maxSize; i++)
            {
                table[i] = null;
            }
        }
        public string retrieve(int key)
        {
            int hash = key % maxSize;
            while (table[hash] != null && table[hash].getkey() != key)
            {
                hash = (hash + 1) % maxSize;
            }
            if (table[hash] == null)
            {
                return "nothing found!";
            }
            else
            {
                return table[hash].getdata();
            }
        }
        /// <summary>
        /// Method to add key and value & data
        /// </summary>
        public void add(int key, string data)
        {
            if (!checkOpenSpace())
            {
                Console.WriteLine("table is at full capacity!");
                return;
            }
            int hash = (key % maxSize);
            while (table[hash] != null && table[hash].getkey() != key)
            {
                hash = (hash + 1) % maxSize;
            }
            table[hash] = new hashentry(key, data);
        }
        /// <summary>
        /// checks for open spaces in the table for insertion
        /// </summary>
        private bool checkOpenSpace()
        {
            bool isOpen = false;
            for (int i = 0; i < maxSize; i++)
            {
                if (table[i] == null)
                {
                    isOpen = true;
                }
            }
            return isOpen;
        }
        /// <summary>
        /// Method to remove key and value & data
        /// </summary>
        public bool remove(int key)
        {
            int hash = key % maxSize;
            while (table[hash] != null && table[hash].getkey() != key)
            {
                hash = (hash + 1) % maxSize;
            }
            if (table[hash] == null)
            {
                return false;
            }
            else
            {
                table[hash] = null;
                return true;
            }
        }
        /// <summary>
        /// Method to show key and value & data
        /// </summary>
        public void show()
        {
            for (int i = 0; i < table.Length; i++)
            {
                if (table[i] == null && i <= maxSize)                               //if we have null entries
                {
                    continue;                                                       //dont print them, continue looping
                }
                else
                {
                    Console.WriteLine("{0}", table[i].getdata());
                }
            }
        }
    }
}
