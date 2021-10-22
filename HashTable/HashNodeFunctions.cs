using System;
using System.Collections.Generic;
using System.Text;

namespace HashTable
{
    public class Node
    {
        public int data;
        public Node next;

        public Node() { }

        public Node(int data)
        {
            this.data = data;
        }
    }

    class HashNodeFunctions
    {

        Node[] chain = new Node[11];

        internal void init()
        {
            int i;
            for (i = 0; i < 11; i++)
                chain[i] = null;// All  places of chain is assign to null
        }

        internal void Get(int value)
        {
            Node newNode = new Node(value);
            newNode.data = value;
            newNode.next = null;// assigning newnode next value setting as null

            //calculate hash key
            int key = value % 11; // 10%11=0  so key=10 | 4%11=4, key=4| 26%11=4, key=4

            //check if chain[key] is empty adding node
            if (chain[key] == null)
                chain[key] = newNode;
            //collision then add next to present key
            else
            {
                //add the node at the end of chain[key].
                Node temp = chain[key];
                while (temp.next != null)
                {
                    temp = temp.next;
                }

                temp.next = newNode;
            }
        }



        internal void print()
        {
            int i;

            for (i = 0; i < 11; i++)
            {
                Node temp = chain[i];
                Console.Write("chain[{0}] --->", i);
                while (temp != null)
                {
                    Console.Write("\t" + temp.data);
                    temp = temp.next;
                }
                Console.WriteLine("\t null\n");
            }
        }
        internal Node Search(int value)
        {
            for (int i = 0; i < 11; i++)
            {
                Node temp = chain[i];
                while (temp != null)
                {
                    if (temp.data == value)
                    {
                        return temp;

                    }
                    temp = temp.next;
                }

            }
            return null;
        }

    }
}