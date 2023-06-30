using CodeChallenges;
using Xunit;

namespace CodeChallengeTests
{

  public class CodeChallenge1Test
  {

    [Fact]
    public void ReverseArray_Test()
    {
      int[] testArray1 = { 1, 2, 3, 4, 5 };
      int[] expectedResult1 = { 5, 4, 3, 2, 1 };

      string[] testArray2 = { "red", "blue", "green", "purple"};
      string[] expectedResult2 = { "purple", "green", "blue", "red"};

      Array result1 = CodeChallenge1.ReverseArray(testArray1);
      // Array result2 = CodeChallenge1.ReverseArray(testArray2);

      Assert.Equal(result1, expectedResult1);
      // Assert.Equal(result2, expectedResult2);
    }
  }
}