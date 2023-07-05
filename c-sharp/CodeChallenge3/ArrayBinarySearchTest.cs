using CodeChallenges;
using Xunit;

namespace CodeChallengeTests
{
  public class CodeChallenge3Test
  {
    [Fact]
    public void BinarySearch_Test()
    {
      int[] inputArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
      int searchKey = 3;
      int result = CodeChallenge3.BinarySearch(inputArray, searchKey);
      Assert.Equal(result, 2);
    }

    [Fact]
    public void BinarySearch_Test_KeyNotFound()
    {
      // Arrange
      int[] inputArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
      int searchKey = 10;

      // Act
      int result = CodeChallenge3.BinarySearch(inputArray, searchKey);

      // Assert
      Assert.Equal(-1, result);
    }

    [Fact]
    public void BinarySearch_Test_EmptyArray()
    {
      // Arrange
      int[] inputArray = new int[0];
      int searchKey = 5;

      // Act
      int result = CodeChallenge3.BinarySearch(inputArray, searchKey);

      // Assert
      Assert.Equal(-1, result);
    }

    [Fact]
    public void BinarySearch_Test_SingleElementArray_Found()
    {
      // Arrange
      int[] inputArray = { 5 };
      int searchKey = 5;

      // Act
      int result = CodeChallenge3.BinarySearch(inputArray, searchKey);

      // Assert
      Assert.Equal(0, result);
    }

    [Fact]
    public void BinarySearch_Test_SingleElementArray_NotFound()
    {
      // Arrange
      int[] inputArray = { 5 };
      int searchKey = 10;

      // Act
      int result = CodeChallenge3.BinarySearch(inputArray, searchKey);

      // Assert
      Assert.Equal(-1, result);
    }

    [Fact]
    public void BinarySearch_Test_DuplicateElements()
    {
      // Arrange
      int[] inputArray = { 1, 2, 3, 3, 3, 4, 5 };
      int searchKey = 3;

      // Act
      int result = CodeChallenge3.BinarySearch(inputArray, searchKey);

      // Assert
      Assert.Equal(2, result);
    }
  }
}