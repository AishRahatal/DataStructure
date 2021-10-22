using System;
using System.Collections.Generic;
using System.Text;

namespace HashTable
{
    class HashFunction
    {
        public int size = 11;
        public int[] arr=new int[11];
        public void init()
        {
            int i;
            for (i = 0; i < size; i++)
                arr[i] = -1;
        }

        public void insert(int value)
        {
            int key = value % size;

            if (arr[key] == -1)
            {
                arr[key] = value;
                Console.WriteLine("\n{0} inserted at arr[{1}] ", value, key);
            }
            else
            {
                Console.Write("Collision : arr[{0}] has element {1} already!", key, arr[key]);
                Console.Write("\t {0} Unable to insert at arr[{1}]", value, key);
                Console.WriteLine("");
            }
        }

       public void delete(int value)
        {
            int key = value % size;
            if (arr[key] == value)
                arr[key] = -1;
            else
                Console.WriteLine("\n {0} not present in the hash table :", value);
        }

        public void search(int value)
        {
            int key = value % size;
            if (arr[key] == value)
                Console.WriteLine("Data Found\n");
            else
                Console.WriteLine("Data  Not Found\n");
        }

        public void print()
        {
            int i;
            for (i = 0; i < size; i++)
                Console.WriteLine("arr[{0}] ={1} ",i, arr[i]);
        }

        

    }
}
