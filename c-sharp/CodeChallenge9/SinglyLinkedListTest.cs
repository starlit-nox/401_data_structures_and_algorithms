using CodeChallenges;
using Xunit;
using System.Reflection;

namespace CodeChallengeTests
{
  public class CodeChallenge9Test
  {
    [Fact]
    public void TestReverseLinkedList()
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

      // Assert
      Assert.Equal(4, list.Head.Value);
      Assert.Equal(3, list.Head.Next.Value);
      Assert.Equal(2, list.Head.Next.Next.Value);
      Assert.Equal(1, list.Head.Next.Next.Next.Value);
      Assert.Null(list.Head.Next.Next.Next.Next);
    }

    [Fact]
    public void IsPalindrome_Test()
    {
      // Arrange
      LinkedListKth list = new LinkedListKth();
      list.Head = new Node(1);
      list.Head.Next = new Node(2);
      list.Head.Next.Next = new Node(3);
      list.Head.Next.Next.Next = new Node(4);

      // Act
      CodeChallenge9.ReverseLinkedList(list);

      // Assert
      Assert.Equal(4, list.Head.Value);
      Assert.Equal(3, list.Head.Next.Value);
      Assert.Equal(2, list.Head.Next.Next.Value);
      Assert.Equal(1, list.Head.Next.Next.Next.Value);
      Assert.Null(list.Head.Next.Next.Next.Next);
    }
  }
}