using System;
using System.Collections.Generic;

namespace ZipLinkedLists
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            LinkedList linked = new LinkedList(1);
            //ll 1
            Node n1 = new Node(3);
            Node n2 = new Node(5);
            Node n3 = new Node(7);
            Node n4 = new Node(9);
            Node n5 = new Node(11);
            Node n6 = new Node(13);
            Node n7 = new Node(15);


            linked.Head.Next = n1;
            n1.Next = n2;
            n2.Next = n3;
            n3.Next = n4;
            n4.Next = n5;
            n5.Next = n6;
            n6.Next = n7;

            LinkedList linked2 = new LinkedList(2);
            //ll 2
            Node m1 = new Node(4);
            Node m2 = new Node(6);
            Node m3 = new Node(8);
            Node m4 = new Node(10);
            Node m5 = new Node(12);

            linked2.Head.Next = m1;
            m1.Next = m2;
            m2.Next = m3;
            m3.Next = m4;
            m4.Next = m5;

            Output(ZipLists(linked, linked2));
        }


        /// <summary>
        /// O(n) solution to merging together two linked lists
        /// </summary>
        /// <param name="ll1">first linked list</param>
        /// <param name="ll2">second linked list</param>
        /// <returns>a new linked list returned with the two zipped together</returns>
        public static LinkedList<int> Zippy(LinkedList<int> ll1, LinkedList<int> ll2)
        {
            //Create temp linked list to hold new values.
            LinkedList<int> tempLL = new LinkedList<int>();

            //set current pointers from each list
            LinkedListNode<int> current1 = ll1.First;
            LinkedListNode<int> current2 = ll2.First;

            //Add the first value to the temp LL
            tempLL.AddLast(current1.Value);

            //Add first item in second ll. 
            tempLL.AddLast(current2.Value);

            //Run While loop when one of the other LL still has values in it
            while (current1.Next != null || current2.Next != null)
            {
                //only add node to LL if it exists
                if (current1.Next != null)
                {
                    tempLL.AddLast(current1.Next.Value);
                    current1 = current1.Next;
                }

                //only add node to LL if it exists
                if (current2.Next != null)
                {
                    tempLL.AddLast(current2.Next.Value);
                    current2 = current2.Next;
                }
            }

            //return temp with combined linked lists
            return tempLL;

        }

        /// <summary>
        /// O(1) space of merging together two linked lists
        /// </summary>
        /// <param name="ll1">First Linked List</param>
        /// <param name="ll2">2nd seperate Linked List</param>
        /// <returns>The first linked list with the second merged in</returns>
        public static LinkedList ZipLists(LinkedList ll1, LinkedList ll2)
        {
            Node C1 = ll1.Head;
            Node C2 = ll2.Head;
            Node temp = null;

            while (C1 != null && C2 != null)
            {
                if(C1 != null)
                {
                    temp = C1.Next;
                    C1.Next = C2;
                    C1 = temp;                     
                }

                if(C2 != null)
                {
                    temp = C2.Next;
                    if(C1 != null)
                    {
                        C2.Next = C1;

                    }

                    C2 = temp;
                }

            }

            return ll1;

        }

        /// <summary>
        /// Output linked list to console
        /// </summary>
        /// <param name="ll"></param>
        public static void Output(LinkedList ll)
        {
            Node Current = ll.Head;
            while (Current != null)
            {
                Console.Write($"{Current.Value} =>");
                Current = Current.Next;
            }
            Console.WriteLine($"NULL");

        }
    }

    class Node
    {
        public int Value { get; set; }
        public Node Next { get; set; }
        public Node(int value)
        {
            Value = value;
        }
    }

    class LinkedList
    {
        public Node Head { get; set; }
        public LinkedList(int value)
        {
            Node node = new Node(value);
            Head = node;
        }
    }
}
