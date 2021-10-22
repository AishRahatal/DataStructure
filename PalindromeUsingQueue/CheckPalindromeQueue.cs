using System;

namespace PalindromeUsingQueue
{
    public class Node
    {
        public char data;
        public Node next;

        public Node()
        {
        }

        public Node(char data)
        {
            this.data = data;
        }

    }
    class CheckPalindromeQueue
    {
        internal Node head;
        static void Main(string[] args)
        {
            Console.WriteLine("Palindrome check Using queue :");
            Console.WriteLine("Enter string to check if it is palindrome or not:");

            string str = Console.ReadLine();
            CheckPalindromeQueue check = new CheckPalindromeQueue();

            check.checkpalindrome(str);
        }
        // adding from front
        internal void enqueue(char data)
        {
            Node newnode = new Node(data);

            if (head == null)
            {
                head = newnode;
            }
            else
            {

                Node temp = new Node(data);
                temp = head;
                while (temp.next != null)
                    temp = temp.next;
                temp.next = newnode;

            }
            Console.WriteLine("\n {0} Node added to Queue", newnode.data);
            Console.WriteLine(" ------------------------");



        }


        //Removing node from queue 
        internal void dequeue()
        {

            if (head == null)
            {
                return;
               // Console.WriteLine(" Cant perform delete operation ");
            }
            else
            {
                while (head != null)
                {
                    Node temp = head;
                    Console.WriteLine("\n" + temp.data + "  Removed node from Queue ");

                    head = head.next;
                    temp = null;
                }
                Console.WriteLine(" ------------------------");

                
            }
        }

        internal void checkpalindrome(string str)
        {
            CheckPalindromeQueue q = new CheckPalindromeQueue();

            char[] ch = str.ToCharArray();

            int mid = ch.Length / 2;
            string temp = "";
            Console.WriteLine(" iterating continuous :");

            for (int i=0; i<ch.Length;i++)
            {
                
              q.enqueue(ch[i]);
             temp = string.Concat(temp ,ch[i]);

            }

            string reverse = "";
            Console.WriteLine(" iterating reverse :");

            for (int i = ch.Length-1; i >=0; i--)
            {


                q.dequeue();
                
                reverse = string.Concat(reverse ,ch[i]);

                
            }
            Console.WriteLine("\n Reversed string :"+reverse);
            Console.WriteLine("");

            if (reverse == temp)
            {
                Console.WriteLine("String is Palindrome");
            }
            else
            {
                Console.WriteLine("String is not Palindrome");

            }

        }
    }
}
