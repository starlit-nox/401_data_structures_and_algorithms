namespace CodeChallenges
{
  public class CodeChallenge2Modified : CodeChallenge2
  {
    public new static int[] InsertShiftArray(int[] array, int value)
    {
      int middleIndex = array.Length / 2;
      int[] newArray = new int[array.Length + 1];

      for (int i = 0, j = 0; i < newArray.Length; i++, j++)
      {
        if (i == middleIndex)
        {
          newArray[i] = value;
          j--;
        }
        else
        {
          newArray[i] = array[j];
        }
      }

      return newArray;
    }
  }
}
