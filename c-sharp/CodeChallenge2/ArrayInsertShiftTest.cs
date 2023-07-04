using CodeChallenges;
using Xunit;

namespace CodeChallengeTests
{
  public class CodeChallenge2Test
  {
    [Fact]
    public void InsertShiftArray_With_OddNumber_Of_Elements()
    {
      int[] inputArray = { 1, 2, 3, 4, 5, 6 };
      int inputValue = 7;
      int[] expectedArray = { 1, 2, 3, 7, 4, 5, 6 };

      int[] result = CodeChallenge2.InsertShiftArray(inputArray, inputValue);

      Assert.Equal(result, expectedArray);
    }
  }
}