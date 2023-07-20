namespace CodeChallenges
{
  public class CodeChallenge9
  {
    public void ReverseLinkedList(LinkedListKth list)
    {
      Node prev = null;
      Node current = list.Head;
      Node next = null;

      while (current != null)
      {
        next = current.Next;
        current.Next = prev;
        prev = current;
        current = next;
      }

       list.Head = prev;
    }

    public void IsPalindrome()
    {

    }
  }
}