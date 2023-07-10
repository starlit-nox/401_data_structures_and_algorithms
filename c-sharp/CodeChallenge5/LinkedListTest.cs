using CodeChallenges;
using Xunit;
using System.Reflection;
namespace CodeChallengeTests
{
  public class CodeChallenge5Test
  {
    [Fact]
    public void LinkedList_Can_A_Single_Node()
    {
      LinkedList list = new LinkedList();
      Node node = new Node(5);

      list.AddNewNode(node);
      Assert.Equal(list.Head, node);

    }

    [Fact]
    public void LinkedList_Can_A_Two_Nodes()
    {
      LinkedList list = new LinkedList();
      Node node1 = new Node(5);
      Node node2 = new Node(6);

      LinkedList expectedList = new LinkedList();
      node2.Next = node1;
      expectedList.Head = node2;


      list.AddNewNode(node1);
      list.AddNewNode(node2);
      Assert.Equal(expectedList.Head, list.Head);
      Assert.Equal(expectedList.Head.Next, list.Head.Next);
      
    }

  }
}