using CodeChallenges;
using Xunit;
using System.Reflection;
namespace CodeChallengeTests
{
  public class CodeChallenge5Test
  {
    [Fact]
    public void LinkedList_Can_Add_Single_Value()
    {
      MethodInfo insertMethod = typeof(LinkedList).GetMethod("Insert");
      Assert.True(insertMethod != null);
      LinkedList list = new LinkedList();

      int value = 5;
      insertMethod.Invoke(list, new object[]{value});
      Assert.Equal(value, list.Head.Value);
    }

    [Fact]
    public void LinkedList_Can_Add_Two_Nodes()
    {
      MethodInfo insertMethod = typeof(LinkedList).GetMethod("Insert");
      Assert.True(insertMethod != null);
      LinkedList list = new LinkedList();
      int value = 5;
      int value2 = 6;
      insertMethod.Invoke(list, new object[]{value});
      insertMethod.Invoke(list, new object[]{value2});

      Assert.Equal(value2, list.Head.Value);
      Assert.Equal(value, list.Head.Next.Value);
    }

    [Fact]
    public void Includes_Returns_True_When_Value_Is_Present()
    {
      MethodInfo insertMethod = typeof(LinkedList).GetMethod("Insert");
      Assert.True(insertMethod != null);
      
      LinkedList list = new LinkedList();
      int value1 = 5;
      int value2 = 6;
      int value3 = -1;
      int value4 = -2;
      int value5 = 0;
      insertMethod.Invoke(list, new object[]{value1});
      insertMethod.Invoke(list, new object[]{value2});
      insertMethod.Invoke(list, new object[]{value3});
      insertMethod.Invoke(list, new object[]{value4});
      insertMethod.Invoke(list, new object[]{value5});

      MethodInfo includesMethod = typeof(LinkedList).GetMethod("Includes");
      Assert.True(includesMethod != null);

      bool result1 = (bool)includesMethod.Invoke(list, new object[]{value1});
      bool result2 = (bool)includesMethod.Invoke(list, new object[]{value2});
      bool result3 = (bool)includesMethod.Invoke(list, new object[]{value3});
      bool result4 = (bool)includesMethod.Invoke(list, new object[]{value4});
      bool result5 = (bool)includesMethod.Invoke(list, new object[]{value5});

      Assert.True(result1);
      Assert.True(result2);
      Assert.True(result3);
      Assert.True(result4);
    }

    [Fact]
    public void Includes_Returns_False_When_Value_IsNot_Present()
    {
      MethodInfo insertMethod = typeof(LinkedList).GetMethod("Insert");
      Assert.True(insertMethod != null);
      
      LinkedList list = new LinkedList();
      int value1 = 5;
      int value2 = 6;
      int value3 = -1;
      int value4 = -2;
      int value5 = 0;
      insertMethod.Invoke(list, new object[]{value1});
      insertMethod.Invoke(list, new object[]{value2});
      insertMethod.Invoke(list, new object[]{value3});
      insertMethod.Invoke(list, new object[]{value4});
      insertMethod.Invoke(list, new object[]{value5});

      MethodInfo includesMethod = typeof(LinkedList).GetMethod("Includes");
      Assert.True(includesMethod != null);

      bool result1 = (bool)includesMethod.Invoke(list, new object[]{1122});
      bool result2 = (bool)includesMethod.Invoke(list, new object[]{123213});
      bool result3 = (bool)includesMethod.Invoke(list, new object[]{555});
      bool result4 = (bool)includesMethod.Invoke(list, new object[]{666});


      Assert.False(result1);
      Assert.False(result2);
      Assert.False(result3);
      Assert.False(result4);
    }

    [Fact]
    public void ToString_Returns_Correct_String_Representation_With_Two_Nodes()
    {
      MethodInfo insertMethod = typeof(LinkedList).GetMethod("Insert");
      Assert.True(insertMethod != null);

      LinkedList list = new LinkedList();
      int value1 = 5;
      int value2 = 6;
      insertMethod.Invoke(list, new object[]{value1});
      insertMethod.Invoke(list, new object[]{value2});

      MethodInfo toStringMethod = typeof(LinkedList).GetMethod("ToString");
      Assert.True(toStringMethod != null);

      string expectedString = "5 -> 6 -> NULL";
      string result = (string)toStringMethod.Invoke(list, new object[]{});;

      Assert.Equal(expectedString, result);
    }

    [Fact]
    public void ToString_Returns_Correct_String_Representation_With_5_Nodes()
    {
      MethodInfo insertMethod = typeof(LinkedList).GetMethod("Insert");
      Assert.True(insertMethod != null);
      
      LinkedList list = new LinkedList();
      insertMethod.Invoke(list, new object[]{-1});
      insertMethod.Invoke(list, new object[]{99});
      insertMethod.Invoke(list, new object[]{6});
      insertMethod.Invoke(list, new object[]{12});
      insertMethod.Invoke(list, new object[]{0});

      MethodInfo toStringMethod = typeof(LinkedList).GetMethod("ToString");
      Assert.True(toStringMethod != null);

      string expectedString = "0 -> 12 -> 6 -> 99 -> -1 -> NULL";
      string result = (string)toStringMethod.Invoke(list, new object[]{});

      Assert.Equal(expectedString, result);
    }

    [Fact]
    public void ToString_Returns_Correct_String_Representation_With_0_Nodes()
    {
      MethodInfo insertMethod = typeof(LinkedList).GetMethod("Insert");
      Assert.True(insertMethod != null);
      LinkedList list = new LinkedList();

      MethodInfo toStringMethod = typeof(LinkedList).GetMethod("ToString");
      Assert.True(toStringMethod != null);

      string expectedString = "NULL";
      string result = (string)toStringMethod.Invoke(list, new object[]{});

      Assert.Equal(expectedString, result);
    }
  }
}