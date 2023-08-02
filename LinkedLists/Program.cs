using System;
using System.Collections;
using System.Collections.Generic;
using System.Xml.Linq;
using static AlgoExpert.Program;

namespace AlgoExpert
{
    public class Program
    {
        public class CustomlinkedList
        {
            int value;
            CustomlinkedList Next;
            CustomlinkedList Head = null;
            public CustomlinkedList(int value) { 
            this.value = value;
            this.Next = null;
            }

            public void push(int new_data)
            {
                /* 1 & 2: Allocate the Node &
                          Put in the data*/
                CustomlinkedList new_node = new CustomlinkedList(new_data);

                // 3. Make next of new Node as head 
                new_node.Next = Head;

                // 4. Move the head to point to new Node 
                Head = new_node;
            }
        }
        public CustomlinkedList RemoveDuplicatesFromLinkedList(CustomlinkedList linkedList)
        {
            // Write your code here.
            return null;
        }
        static void Main(string[] args)
        {
            //-----------1--------------
            CustomlinkedList customlinked = new CustomlinkedList(1);
            customlinked.push(2);
            customlinked.push(3);
            customlinked.push(3);
            customlinked.push(4);

            Console.WriteLine("Hello World!");
            Console.ReadLine();
        }
    }
}