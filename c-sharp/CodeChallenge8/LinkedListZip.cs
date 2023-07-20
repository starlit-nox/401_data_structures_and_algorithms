using System.Collections.Generic;
namespace CodeChallenges
{
  public class CodeChallenge8
  {
    public static LinkedList<int> ZipLists(LinkedList<int> list1, LinkedList<int> list2)
    {

      LinkedList<int> result = new LinkedList<int>();

      LinkedListNode<int> current1 = list1.First;
      LinkedListNode<int> current2 = list2.First;

      while (current1 != null || current2 != null)
      {
        if (current1 != null)
        {
          result.AddLast(current1.Value);
          current1 = current1.Next;
        }

        if (current2 != null)
        {
          result.AddLast(current2.Value);
          current2 = current2.Next;
        }
      }

      return result;
    }
  }
}