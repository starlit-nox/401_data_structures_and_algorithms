namespace CodeChallenges 
{
    public class LinkedList
    {
        public Node Head;
        // public void Insert(int value)
        // {


        // }

        public bool Includes(int value)
        {
            bool includes = false;

            return includes;
        }

        //Expected Output: a -> b -> c -> NULL
        override public string ToString()
        {
            string listString = "";

            return listString;
        }
    }

    public class Node
    {
        public Node? Next;
        public int Value;
        public Node(int value)
        {
            Value = value;
        }
    }
}