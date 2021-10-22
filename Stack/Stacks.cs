using System;

namespace Stack
{
    public class Node
    {
        public string data;
        public Node next;

        public Node()
        {
        }

        public Node(string data)
        {
            this.data = data;
        }

    }
    class Stacks
    {
        internal Node top = null;

      
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Stack Program!");
            Stacks s = new Stacks();

           string str="(5 + 6)∗(7 + 8) / (4 + 3)(5 + 6)∗(7 + 8) / (4 + 3)";

            //Console.WriteLine(" ------------------------");
            //s.peek();
            //Console.WriteLine(" ------------------------");
            //s.pop();
            s.checkArithmetic(str);

        }

        //Adding node to stack
        internal void push(string data)
        {
            Node newnode = new Node(data);

            newnode.next = top;
            top = newnode;
            Console.WriteLine(top.data + "  :Pushed in to stack");

        }
        // Retrving top node of stack
        internal void peek()
        {
            if (isEmpty())
            {
                Console.WriteLine(" There is nothing in top of stack!");

            }
            else
            {
                Console.WriteLine("Top node of stack " + top.data);
            }

        }

        // Removing node from stack
        internal void pop()
        {
            if (isEmpty())
            {
                Console.WriteLine("Stack is empty");
                return;
            }

            while (!isEmpty())
            {
                Console.WriteLine(" Popped  Node !! " + top.data);

                top = top.next;

            }
            Console.WriteLine(" ------------------------");

            Console.WriteLine(" Stack: ");

            if (isEmpty())
            {
                Console.WriteLine("Stack is empty");

            }

        }

        //checking stack is empty
        internal bool isEmpty()
        {
            return (top == null);
        }

        //checking parenthsis are balenced or not
        public  void checkArithmetic(string str)
        {
            Stacks stack = new Stacks();
            int count1 = 0, count2 = 0;

            char[] ch = str.ToCharArray();

           for(int i = 0; i < ch.Length; i++)
            {
                if (ch[i] == '(')
                {
                    Console.WriteLine(" ------------------------");

                    count1++;

                    Console.WriteLine("Parenthesis "+count1);
                    push("(");
                    Console.WriteLine(" ------------------------");
                    peek();

                }
                else if(ch[i] == ')')
                {
                   
                    Console.WriteLine(" ------------------------");

                    count2++;
                    Console.WriteLine("Parenthesis " + count2);
                    pop();
                    Console.WriteLine(" ------------------------");
                    peek();

                }




            }


           if(count1 == count2)
            {
                Console.WriteLine(" ----------------------------------------------------");

                Console.WriteLine("Parenthesis are balanced .. Expression is correct");
                Console.WriteLine(str);
            }
           else
            {
                Console.WriteLine(" ----------------------------------------------------");

                Console.WriteLine("Parenthesis are not balanced ");

            }
        }
        
    }
}
