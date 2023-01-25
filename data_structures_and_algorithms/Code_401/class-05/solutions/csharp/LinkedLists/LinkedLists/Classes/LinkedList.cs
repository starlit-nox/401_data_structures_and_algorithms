using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedLists.Classes
{
    public class LinkList
    {
        public Node Head { get; set; }
        private Node Current { get; set; }

        // Require at least one node
        public LinkList(object n)
        {
            Node node = new Node() { Value = n };
            Head = node;
            Current = Head;
        }

        // Empty Linked List
        public LinkList()
        {

        }

        /// <summary>
        /// Add First adds a node to the beginning of a linked list
        /// </summary>
        /// <param name="data"></param>
        public void Insert(object data)
        {
            Current = Head;
            Node node = new Node() { Value = data };
            node.Next = Head;
            Head = node;
            Current = node;
        }


        /// <summary>
        /// Determines if a given value exists in the linked list
        /// </summary>
        /// <param name="value">value to be searched</param>
        /// <returns>response if the given value exists</returns>
        public bool Includes(object value)
        {
            Current = Head;

            while (Current != null)
            {
                if(Current.Value.ToString() == value.ToString())
                {
                    return true;
                } 

                Current = Current.Next;
            }

            return false;
        }
        /// <summary>
        /// Add Before adds a node before a specified node in a link list
        /// </summary>
        /// <param name="data"></param>
        /// <param name="before"></param>
        public void AddBefore(object data, object before)
        {
            Node node = new Node() { Value = data };
            Current = Head;
            while (Current.Next != null)
            {
                if (Current.Next.Value.ToString() == before.ToString())
                {
                    node.Next = Current.Next;
                    Current.Next = node;
                    Current = Current.Next;

                }

                Current = Current.Next;
            }
        }

        
        /// <summary>
        /// Add After adds a node after a specified node in a linked list
        /// </summary>
        /// <param name="data"></param>
        /// <param name="after"></param>
        public void AddAfter(object data, object after)
        {
            Node node = new Node() { Value = data };
            Current = Head;
            while (Current.Next != null)
            {
                if (Current.Value.ToString() == after.ToString())
                {
                    node.Next = Current.Next;
                    Current.Next = node;

                }

                Current = Current.Next;
            }
        }

        /// <summary>
        /// Add Last adds a node to the end of a linked list
        /// </summary>
        /// <param name="data"></param>
        public void AddLast(object data)
        {
            Node node = new Node() { Value = data };
            Current = Head;

            while (Current.Next != null)
            {
                Current = Current.Next;
            }
            Current.Next = node;
        }

        public override string ToString()
        {
            Current = Head;
            StringBuilder sb = new StringBuilder();

            while (Current != null)
            {
                sb.Append($"{Current.Value} => ");
                Current = Current.Next;
            }
            sb.Append("=> NULL");

            return sb.ToString();
        }

        public int KthElementFromEnd(int k)
        {
            Node Runner = Head, Walker = Head;
            int counter = 0;

            while(Runner.Next != null)
            {
                counter++;
                Runner = Runner.Next;
                if(counter > k)
                {
                    Walker = Walker.Next;
                }
            }

            return (int)Walker.Value;
        }
    }
}
