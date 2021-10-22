using System;
using System.Collections.Generic;
using System.Text;

namespace OrderedLinkedList
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

    class LinkListFunctions
    {
        internal Node head;
        public void List(string data)
        {
            Node newnode = new Node(data);
            if (head == null)
            {
                head = newnode;
                // insert in head if x is lower than the head
            }
            else if (head.data.CompareTo(data) > 0)
            {
                newnode.next = head;
                head = newnode;
            }
            else
            {
                // find the first node which value is lower than x (or the tail)
                Node current;
                for (current = head; current.next != null && current.next.data.CompareTo(data) < 0; current = current.next) ;

                // to remove duplicates
                if (data != current.data)
                {
                    newnode.next = current.next;
                    current.next = newnode;
                }



            }
        }





        internal void Display()
        {

            Node temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("Linked list is empty");
                return;
            }
            while (temp != null)
            {
                Console.WriteLine(temp.data);
                temp = temp.next;


            }

        }

        internal void getsize()
        {
            int count = 0;
            Node temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("Linked list is empty");
                return;
            }
            while (temp != null)
            {
                temp = temp.next;

                count++;
            }
            Console.WriteLine("\nSize of Linked list = " + count);


        }
        internal Node Search(string value)
        {
            while (this.head != null)
            {
                if (this.head.data == value)
                {
                    return this.head;

                }
                this.head = this.head.next;
            }
            return null;

        }

    }
}
