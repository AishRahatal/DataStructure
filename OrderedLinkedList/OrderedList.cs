using System;
using System.IO;

namespace OrderedLinkedList
{
   
    class OrderedList
    {
        
        public static void Main(string[] args)
        {


            LinkListFunctions obj = new LinkListFunctions();
            string path = @"E:\dotnet\DataStructure\Algorithms\OrderedLinkedList\TextFile.txt";

            FileStream file = null;
            StreamReader reader = null;
            string filecontent = String.Empty;

            char[] space = { ' ' };

            if (File.Exists(path))
            {
                file = new FileStream(path, FileMode.Open, FileAccess.Read);
            }
            else
            {
                Console.WriteLine("file does not exist");
                return;
            }
            try
            {
                reader = new StreamReader(file);
                filecontent = reader.ReadToEnd();
            }
            catch (Exception)
            {
                Console.WriteLine("Error occured");

            }
            finally
            {
                if (reader != null)
                    reader.Close();
            }
            string[] words = filecontent.Split(space);

            Console.WriteLine("Before insering into linkedlist file contents :");

            foreach (var item in words)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("-----------------------------------------");


            Console.WriteLine("Inserting from file into linkedlist  into sorted order:\n");


            for (int i = 0; i < words.Length; i++)
            {

                obj.List(words[i]);

            }
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("file content :\n");
            obj.Display();
            Console.WriteLine("\n -----------------------------------------");
            //===================================================================================================================================
            Console.WriteLine("Appending to file inserting from linkedlist :\n");

            Console.WriteLine(" Enter Number to add into file :\n");
            string number = Console.ReadLine();
            string createText = number + Environment.NewLine;
            File.AppendAllText(path, number);
            obj.List(number);
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("file content After appending  :\n");
            obj.Display();
            
            //==================================================================================================================================
            Console.WriteLine("-----------------------------------------");

            Console.WriteLine(" \n Size of linkedlist :\n");

            obj.getsize();

            Console.WriteLine("-----------------------------------------");
            //================================================================================================================================
            Console.WriteLine(" Search Number   :\n");
            string num = Console.ReadLine();
            var check = obj.Search(num);

            if (check != null)
            {

                Console.WriteLine("Found Data !! " + num);

            }
            else
            {
                Console.WriteLine(" Data not found !!");
            }

            //===============================================================================================================================           



        }

        

    }

}

