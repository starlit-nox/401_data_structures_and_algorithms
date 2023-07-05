using CodeChallenges;
using Xunit;
using System.Reflection;
namespace CodeChallengeTests
{
  public class CodeChallenge5Test
  {
    [Fact]
    public void LinkedList_ContainsHeaderProperty()
    {
      Type type = typeof(LinkedList);

      PropertyInfo header = type.GetProperty("header");
      PropertyInfo Header = type.GetProperty("Header");

      Assert.True(header != null || Header != null);
    }
  }
}