using CodeChallenges;
using Xunit;
using System.Reflection;

namespace CodeChallengeTests
{
  public class CodeChallenge6Test
  {

    [Fact]
    public void InsertableLinkedList_Can_Append_New_Value_To_EmptyList()
    {
        InsertableLinkedList list = new InsertableLinkedList();

        MethodInfo appendMethod = typeof(InsertableLinkedList).GetMethod("Append");
        Assert.NotNull(appendMethod);

        int valueToInsert = 10;

        appendMethod.Invoke(list, new object[] { valueToInsert });
        PropertyInfo head = typeof(LinkedList).GetProperty("Head");

        Node headValue = (Node)head.GetValue(list);
        PropertyInfo ValueProperty = typeof(Node).GetProperty("Value");
        int result = (int)ValueProperty.GetValue(headValue);
        Assert.Equal(valueToInsert, result);
    }

    [Fact]
    public void InsertableLinkedList_Can_Append_New_Value_To_List_With_2_Nodes()
    {
      MethodInfo insertMethod = typeof(LinkedList).GetMethod("Insert");
      Assert.True(insertMethod != null);
      
      LinkedList list = new LinkedList();
      insertMethod.Invoke(list, new object[]{-1});
      insertMethod.Invoke(list, new object[]{99});

        MethodInfo appendMethod = typeof(InsertableLinkedList).GetMethod("Append");
        Assert.NotNull(appendMethod);

        int valueToInsert = 10;

        appendMethod.Invoke(list, new object[] { valueToInsert });
        PropertyInfo head = typeof(LinkedList).GetProperty("Head");

        Node headValue = (Node)head.GetValue(list);
        PropertyInfo ValueProperty = typeof(Node).GetProperty("Value");
        int result = (int)ValueProperty.GetValue(headValue);
        Assert.Equal(valueToInsert, result);
    }

  }
}