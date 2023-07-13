using CodeChallenges;
using Xunit;
using System.Reflection;

namespace CodeChallengeTests
{
  public class CodeChallenge6Test
  {
    [Fact]
    public void InsertableLinkedList_Can_Append_New_Value()
    {
      InsertableLinkedList list = new InsertableLinkedList();
      MethodInfo appendMethod = typeof(LinkedList).GetMethod("Append");
      Assert.True(appendMethod != null);
      
      int valueToInsert = 10;
      
      list.Append(valueToInsert);
      appendMethod.Invoke(list, new object[] {valueToInsert});
       
      Assert.Equal(true, false);
    }
  }
}