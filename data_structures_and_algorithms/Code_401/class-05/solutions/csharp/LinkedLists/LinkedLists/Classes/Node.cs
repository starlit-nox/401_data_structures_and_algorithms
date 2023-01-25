using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedLists.Classes
{
    public class Node
    {
        public Node Next { get; set; }
        public object Value { get; set; }

        /// <summary>
        /// Require a node value for a node to be instantiated
        /// </summary>
        /// <param name="value"></param>
        public Node(object value)
        {
            Value = value;

        }

        public Node()
        {

        }


    }
}
