using System;

namespace HashTable
{
    class Program
    {
        static void Main(string[] args)
        {

            //Using singly LinkedList here we call for hash function .. i.e class HashNodeFunctions.cs


            #region HashNodeFunctions 
            HashNodeFunctions h = new HashNodeFunctions();
            Console.WriteLine("Hash table with LinkedList\n");
            h.init();
            h.Get(10);
            h.Get(4);
            h.Get(2);
            h.Get(3);
            h.Get(77);
            h.Get(5);
            h.Get(55);
            h.Get(26);
            h.Get(31);
            h.Get(54);
            h.Get(93);


            Console.WriteLine("Hash table :\n");

            h.print();
            Console.WriteLine("\n");
            Console.WriteLine("------------------------------");
            Console.WriteLine(" Search Number   :\n");
            int num = Convert.ToInt32(Console.ReadLine());
            var check = h.Search(num);
            Console.WriteLine("\n");

            if (check != null)
            {

                Console.WriteLine("Found Data !! " + num);

            }
            else
            {
                Console.WriteLine(" Data not found !!");
            }

            #endregion HashNodeFunctions 
            Console.WriteLine("------------------------------");


            //Using Array here we call for hash function .. i.e class HashFunction.cs

            #region HasFunction
            HashFunction h1 = new HashFunction();


            Console.WriteLine("Hash table with Array :\n");
            h1.init();
            h1.insert(10);
            h1.insert(4);
            h1.insert(2);
            h1.insert(3);
            h1.insert(77);
            h1.insert(5);
            h1.insert(55);
            h1.insert(26);
            h1.insert(31);
            h1.insert(54);
            h1.insert(93);



            Console.WriteLine("Hash table :\n");


            h1.print();
            Console.WriteLine("\n");

            Console.WriteLine("deleting value 10..\n");
            h1.delete(10);
            Console.WriteLine("After the deleting hash table\n");
            h1.print();
            Console.WriteLine("\n");

            Console.WriteLine("deleteting value 5..\n");
            h1.delete(5);
            Console.WriteLine("After the deletion hash table\n");
            h1.print();
            Console.WriteLine("\n");

            Console.WriteLine("searching value 4..\n");
            h1.search(4);
            Console.WriteLine("searching value 10..\n");
            h1.search(10);

            #endregion HashFunction
        }
    }
}
