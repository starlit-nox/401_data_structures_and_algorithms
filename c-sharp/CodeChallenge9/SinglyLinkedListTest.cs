using CodeChallenges;
using Xunit;
using System.Reflection;

namespace CodeChallengeTests
{
  public class CodeChallenge9Test
  {
    [Fact]
    public void Can_Reverse_SinglyLinkedList_With_5_Nodes()
    {
      // Arrange
      // Create an instance of the InsertableLinkedList
      MethodInfo insertMethod = typeof(LinkedListKth).GetMethod("Insert");
      Assert.True(insertMethod != null);

      LinkedListKth list = new LinkedListKth();
      insertMethod.Invoke(list, new object[] { 10 });
      insertMethod.Invoke(list, new object[] { 20 });
      insertMethod.Invoke(list, new object[] { 30 });
      insertMethod.Invoke(list, new object[] { 40 });
      insertMethod.Invoke(list, new object[] { 50 });

      // Act
      CodeChallenge9.ReverseLinkedList(list);
      PropertyInfo headProperty = typeof(LinkedListKth).GetProperty("Head");
      PropertyInfo valueProperty = typeof(Node).GetProperty("Value");
      PropertyInfo nextProperty = typeof(Node).GetProperty("Next");

      Node head = (Node)headProperty.GetValue(list);
      int value1 = (int)valueProperty.GetValue(head);

      Node node2 = (Node)nextProperty.GetValue(head);
      int value2 = (int)valueProperty.GetValue(node2);

      Node node3 = (Node)nextProperty.GetValue(node2);
      int value3 = (int)valueProperty.GetValue(node3);

      Node node4 = (Node)nextProperty.GetValue(node3);
      int value4 = (int)valueProperty.GetValue(node4);

      Node node5 = (Node)nextProperty.GetValue(node4);
      int value5 = (int)valueProperty.GetValue(node5);

      // Assert
      Assert.Equal(10, value1);
      Assert.Equal(20, value2);
      Assert.Equal(30, value3);
      Assert.Equal(40, value4);
      Assert.Equal(50, value5);
    }

    [Fact]
    public void Can_Reverse_SinglyLinkedList_With_2_Nodes()
    {
      // Arrange
      // Create an instance of the InsertableLinkedList
      MethodInfo insertMethod = typeof(LinkedListKth).GetMethod("Insert");
      Assert.True(insertMethod != null);

      LinkedListKth list = new LinkedListKth();
      insertMethod.Invoke(list, new object[] { 15 });
      insertMethod.Invoke(list, new object[] { 22 });

      // Act
      CodeChallenge9.ReverseLinkedList(list);
      PropertyInfo headProperty = typeof(LinkedListKth).GetProperty("Head");
      PropertyInfo valueProperty = typeof(Node).GetProperty("Value");
      PropertyInfo nextProperty = typeof(Node).GetProperty("Next");

      Node head = (Node)headProperty.GetValue(list);
      int value1 = (int)valueProperty.GetValue(head);

      Node node2 = (Node)nextProperty.GetValue(head);
      int value2 = (int)valueProperty.GetValue(node2);


      // Assert
      Assert.Equal(15, value1);
      Assert.Equal(22, value2);
    }

    [Fact]
    public void IsPalindrome_Test()
    {
      // Create an instance of the InsertableLinkedList
      MethodInfo insertMethod = typeof(LinkedListKth).GetMethod("Insert");
      Assert.True(insertMethod != null);

      LinkedListKth list = new LinkedListKth();
      insertMethod.Invoke(list, new object[] { 10 });
      insertMethod.Invoke(list, new object[] { 20 });
      insertMethod.Invoke(list, new object[] { 30 });
      insertMethod.Invoke(list, new object[] { 40 });
      insertMethod.Invoke(list, new object[] { 50 });

      // Act
      CodeChallenge9.ReverseLinkedList(list);
      PropertyInfo headProperty = typeof(LinkedListKth).GetProperty("Head");
      PropertyInfo valueProperty = typeof(Node).GetProperty("Value");
      PropertyInfo nextProperty = typeof(Node).GetProperty("Next");

      Node head = (Node)headProperty.GetValue(list);
      int value1 = (int)valueProperty.GetValue(head);

      Node node2 = (Node)nextProperty.GetValue(head);
      int value2 = (int)valueProperty.GetValue(node2);

      Node node3 = (Node)nextProperty.GetValue(node2);
      int value3 = (int)valueProperty.GetValue(node3);

      Node node4 = (Node)nextProperty.GetValue(node3);
      int value4 = (int)valueProperty.GetValue(node4);

      Node node5 = (Node)nextProperty.GetValue(node4);
      int value5 = (int)valueProperty.GetValue(node5);
      // Arrange
      // LinkedListKth list = new LinkedListKth();
      // list.Head = new Node(1);
      // list.Head.Next = new Node(2);
      // list.Head.Next.Next = new Node(3);
      // list.Head.Next.Next.Next = new Node(4);

      // // Act
      // CodeChallenge9.ReverseLinkedList(list);

      // // Assert
      // Assert.Equal(10, list.Head.Value);
      // Assert.Equal(3, list.Head.Next.Value);
      // Assert.Equal(2, list.Head.Next.Next.Value);
      // Assert.Equal(1, list.Head.Next.Next.Next.Value);
      // Assert.Null(list.Head.Next.Next.Next.Next);
    }
  }
}