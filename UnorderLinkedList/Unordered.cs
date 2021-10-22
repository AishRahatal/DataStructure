using System;
using System.IO;

namespace UnorderedLinkList
{
   
    class Unordered
    {
       
        public static void Main(string[] args)
        {


            LinkedListOperations obj = new LinkedListOperations();
            string path = @"E:\dotnet\DataStructure\Algorithms\Datastructure2\TextFile.txt";

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




            Console.WriteLine("Inserting from file into linklist :\n");


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

            Console.WriteLine(" Enter Fruit name to add into file :\n");
            string fruit = Console.ReadLine();

            string createText = fruit + Environment.NewLine;
            File.AppendAllText(path, fruit);
            obj.List(fruit);
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("file content After appending  :\n");
            obj.Display();

            Console.WriteLine("\n");
            Console.WriteLine("\n");
//==================================================================================================================================
            Console.WriteLine(" Size of linkedlist :\n");
            obj.getsize();

            Console.WriteLine("-----------------------------------------");
//================================================================================================================================
            Console.WriteLine(" Search fruit name  :\n");
            string searchfruit = Console.ReadLine();
            var check=obj.Search(searchfruit);

            if (check !=null)
            {

                Console.WriteLine("Found Data !! " + searchfruit);

            }
            else
            {
                Console.WriteLine(" Data not found !!");
            }

 //===============================================================================================================================           

            

        }

       
        }
    }

