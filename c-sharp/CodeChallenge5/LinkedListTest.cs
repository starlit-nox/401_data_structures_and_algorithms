using CodeChallenges;
using Xunit;
using System.Reflection;
namespace CodeChallengeTests
{
  public class CodeChallenge5Test
  {
    [Fact]
    public void LinkedList_Contains_HeaderProperty()
    {
      Type type = typeof(LinkedList);

      PropertyInfo header = type.GetProperty("head");
      PropertyInfo Header = type.GetProperty("Head");

      Assert.True(header != null || Header != null);
    }
    
    [Fact]
    public void LinkedList_HeaderProperty_Is_NodeType()
    {
      Type type = typeof(LinkedList);

      PropertyInfo header = type.GetProperty("head");

      if(header == null){
        header = type.GetProperty("Head");
      }
      Assert.Equal(header.PropertyType, typeof(Node));
    }

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
      node1.Next = node2;
      expectedList.Head = node1;


      list.AddNewNode(node1);
      list.AddNewNode(node2);
      Assert.Equal(expectedList, list);
    }

  }
}