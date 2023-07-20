using CodeChallenges;
using Xunit;
using System.Reflection;

namespace CodeChallengeTests
{
  public class CodeChallenge7Test
  {
    [Fact]
    public void KthFromEnd_Test()
    {
      Assert.Equal(true, false);
    }

[Fact]
public void InsertableLinkedList_Returns_Correct_Kth_Node_From_End()
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


    // Call the KthFromEnd method with k = 2 (getting the 2nd node from the end)
    MethodInfo kthFromEndMethod = typeof(LinkedListKth).GetMethod("KthFromEnd");
    Assert.NotNull(kthFromEndMethod);

    int k = 2;
    Node kthNode = (Node)kthFromEndMethod.Invoke(list, new object[] { k });

    // Check that the result is not null and that the value of the kth node is correct
    Assert.NotNull(kthNode);

    PropertyInfo valueProperty = typeof(Node).GetProperty("Value");
    int result = (int)valueProperty.GetValue(kthNode);

    // The expected value of the kth node from the end is 30
    Assert.Equal(30, result);
}
  }
}