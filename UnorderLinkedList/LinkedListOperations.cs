using System;
using System.Collections.Generic;
using System.Text;

namespace UnorderedLinkList
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

    class LinkedListOperations
    {
        internal Node head;
        public void List(string data)
        {

            Node node = new Node(data);


            if (this.head == null)
                this.head = node;
            else
            {
                Node temp = head;

                while (temp.next != null)
                {
                    temp = temp.next;
                }

                temp.next = node;
            }

            Console.WriteLine(node.data);

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
                Console.Write(temp.data + " ");
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
