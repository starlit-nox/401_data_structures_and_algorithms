namespace CodeChallenges 
{
    public class StackQueuePsuedo
    {
        private Stack stack1 = new CodeChallenges.Stack();
        private Stack stack2 = new Stack();

        public void Enqueue(int value)
        {
            while (stack1.Count > 0)
            {
                stack2.Push(stack1.Pop());
            }
            stack1.Push(value);
            while (stack2.Count > 0)
            {
                stack1.Push(stack2.Pop());
            }
        }

        public int Dequeue()
        {
            if (stack1.Count == 0)
                throw new InvalidOperationException("Queue is empty.");

            return stack1.Pop();
        }
    }
}