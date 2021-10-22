using System;
using System.Collections.Generic;
using System.Text;

namespace GenericLinarySearch
    {

    class Linearsearch
    {
        static void Main(string[] args)
        {
           
            int[] A = { 5, 8, 9, -1, 4 };
            Console.WriteLine(" Numbers present in array:");
            foreach( var element in A)
            {
                Console.WriteLine(element);

            }

            Console.WriteLine("Enter Number to find:");
            int k = Convert.ToInt32(Console.ReadLine());
            

            GenericSearch<int> obj1 = new GenericSearch<int>(A,k);
            obj1.PrintSearchValue();
            Console.WriteLine("-----------------------------------");


            string characters = "a b c d e f g h";
            char[] alphabets = characters.ToCharArray();
            Console.WriteLine(" Characters present in array:");
            foreach (var c in alphabets)
            {
                Console.WriteLine(c);

            }
            Console.WriteLine("Enter Character to find:");
            char ch = Convert.ToChar(Console.ReadLine());
            GenericSearch<char> obj2 = new GenericSearch<char>(alphabets, ch);
            obj2.PrintSearchValue();

            Console.WriteLine("-----------------------------------");


            string[] fruits = { "apple", "banana", "berry", "Kiwi", "orange" };
            Console.WriteLine(" Fruit names present in array:");
            foreach (var s in fruits)
            {
                Console.WriteLine(s);

            }
            Console.WriteLine("Enter string to find:");
            string st = Console.ReadLine();
            GenericSearch<string> obj3 = new GenericSearch<string>(fruits, st);
            obj3.PrintSearchValue();
            Console.WriteLine("-----------------------------------");

            double[]b  = { 5.0, 0.8, 9.9, -1.5, 4.5 };
            Console.WriteLine(" Numbers present in array:");
            foreach (var n in  b)
            {
                Console.WriteLine(n);

            }

            Console.WriteLine("Enter Number to find:");
           double a = Convert.ToDouble(Console.ReadLine());


            GenericSearch<double> obj4 = new GenericSearch<double>(b, a);
            obj4.PrintSearchValue();
            Console.WriteLine("-----------------------------------");
            Console.WriteLine();

        }
    }


}
