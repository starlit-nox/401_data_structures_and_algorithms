namespace CodeChallenges
{
    public class Node
    {
        public int Value { get; set; }
        public Node Next { get; set; }

        public Node(int value)
        {
            Value = value;
            Next = null;
        }
    }

    public class Stack
    {
        private Node top;

        public Stack()
        {
            top = null;
        }

        public void Push(int value)
        {
            Node newNode = new Node(value);
            newNode.Next = top;
            top = newNode;
        }

        public int Pop()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("Stack is empty. Cannot pop.");
            }

            int value = top.Value;
            top = top.Next;
            return value;
        }

        public int Peek()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("Stack is empty. Cannot peek.");
            }

            return top.Value;
        }

        public bool IsEmpty()
        {
            return top == null;
        }
    }

    public class Queue
    {
        private Node front;

        public Queue()
        {
            front = null;
        }

        public void Enqueue(int value)
        {
            Node newNode = new Node(value);
            if (front == null)
            {
                front = newNode;
            }
            else
            {
                Node current = front;
                while (current.Next != null)
                {
                    current = current.Next;
                }
                current.Next = newNode;
            }
        }

        public int Dequeue()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("Queue is empty. Cannot dequeue.");
            }

            int value = front.Value;
            front = front.Next;
            return value;
        }

        public int Peek()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("Queue is empty. Cannot peek.");
            }

            return front.Value;
        }

        public bool IsEmpty()
        {
            return front == null;
        }
    }
}
