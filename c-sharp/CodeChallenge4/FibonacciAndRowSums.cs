namespace CodeChallenges
{
  public class CodeChallenge4
  {
    public static int GetNthNumberInFibonacciSequence(int nthNumberInSequence)
    {
      if (nthNumberInSequence <= 0)
      {
        throw new ArgumentException("nthNumberInSequence must be a positive integer.");
      }

      if (nthNumberInSequence == 1 || nthNumberInSequence == 2)
      {
        return 1;
      }

      int prev = 1;
      int curr = 1;

      for (int i = 3; i <= nthNumberInSequence; i++)
      {
        int next = prev + curr;
        prev = curr;
        curr = next;
      }

      return curr;
    }

    public static int[] RowSums(int[][] matrix)
    {
      int rows = matrix.Length;
      int[] rowSums = new int[rows];

      for (int i = 0; i < rows; i++)
      {
        int sum = 0;
        for (int j = 0; j < matrix[i].Length; j++)
        {
          sum += matrix[i][j];
        }
        rowSums[i] = sum;
      }

      return rowSums;
    }
  }
}
