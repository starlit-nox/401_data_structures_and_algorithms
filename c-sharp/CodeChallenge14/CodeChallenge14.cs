using System;

namespace CodeChallenges
{
  public class CodeChallenge14
  {
    public class MaxStack
    {

    }

    public static string DuckDuckGoose(string[] stringArray, int k)
    {
      if (stringArray == null || stringArray.Length == 0)
        throw new ArgumentException("The array must not be null or empty.");

      if (k <= 0)
        throw new ArgumentException("The value of k must be greater than zero.");

      int currentIndex = 0;

      while (stringArray.Length > 1)
      {
        currentIndex = (currentIndex + k - 1) % stringArray.Length;
        stringArray = RemoveAtIndex(stringArray, currentIndex);
      }

      return stringArray[0];
    }

    private static string[] RemoveAtIndex(string[] array, int index)
    {
      string[] newArray = new string[array.Length - 1];
      Array.Copy(array, 0, newArray, 0, index);
      Array.Copy(array, index + 1, newArray, index, array.Length - index - 1);
      return newArray;
    }
  }
}
