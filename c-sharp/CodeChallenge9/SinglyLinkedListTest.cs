using CodeChallenges;
using Xunit;

namespace CodeChallengeTests
{
  public class CodeChallenge9Test
  {
    [Fact]
    public void TestReverseLinkedList()
    {
      // Arrange
      CodeChallenge9 codeChallenge = new CodeChallenge9();
      LinkedListKth list = new LinkedListKth();
      list.Head = new Node(1);
      list.Head.Next = new Node(2);
      list.Head.Next.Next = new Node(3);
      list.Head.Next.Next.Next = new Node(4);

      // Act
      codeChallenge.ReverseLinkedList(list);

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
      Assert.Equal(true, false);
    }
  }
}