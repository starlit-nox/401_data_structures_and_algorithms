using CodeChallenges;
using System.Collections.Generic;
using Xunit;

namespace CodeChallengeTests
{
  public class CodeChallenge8Test
  {
    [Fact]
    public void LinkedList_ZipLists_Both_Lists_Same_Length()
    {
        LinkedList<int> list1 = new LinkedList<int>();
        list1.AddLast(1);
        list1.AddLast(2);
        list1.AddLast(3);

        LinkedList<int> list2 = new LinkedList<int>();
        list2.AddLast(10);
        list2.AddLast(20);
        list2.AddLast(30);

        LinkedList<int> result = CodeChallenge8.ZipLists(list1, list2);

        Assert.Equal(1, result.First.Value); // First node
        Assert.Equal(10, result.First.Next.Value); // Second node
        Assert.Equal(2, result.First.Next.Next.Value); // Third node
        Assert.Equal(20, result.First.Next.Next.Next.Value); // Fourth node
        Assert.Equal(3, result.First.Next.Next.Next.Next.Value); // Fifth node
        Assert.Equal(30, result.First.Next.Next.Next.Next.Next.Value); // Sixth node
    }

    [Fact]
    public void LinkedList_ZipLists_First_List_Longer()
    {
        LinkedList<int> list1 = new LinkedList<int>();
        list1.AddLast(1);
        list1.AddLast(2);
        list1.AddLast(3);
        list1.AddLast(4);

        LinkedList<int> list2 = new LinkedList<int>();
        list2.AddLast(10);
        list2.AddLast(20);

        LinkedList<int> result = CodeChallenge8.ZipLists(list1, list2);

        Assert.Equal(1, result.First.Value);
        Assert.Equal(10, result.First.Next.Value);
        Assert.Equal(2, result.First.Next.Next.Value);
        Assert.Equal(20, result.First.Next.Next.Next.Value);
        Assert.Equal(3, result.First.Next.Next.Next.Next.Value);
        Assert.Equal(4, result.First.Next.Next.Next.Next.Next.Value);
    }

    [Fact]
    public void LinkedList_ZipLists_Second_List_Longer()
    {
        LinkedList<int> list1 = new LinkedList<int>();
        list1.AddLast(1);
        list1.AddLast(2);

        LinkedList list2 = new LinkedList();
        list2.Insert(10);
        list2.Insert(20);
        list2.Insert(30);
        list2.Insert(40);

        LinkedList result = LinkedList.ZipLists(list1, list2);

        Assert.Equal(1, result.KthFromEnd(6));
        Assert.Equal(10, result.KthFromEnd(5));
        Assert.Equal(2, result.KthFromEnd(4));
        Assert.Equal(20, result.KthFromEnd(3));
        Assert.Equal(30, result.KthFromEnd(2));
        Assert.Equal(40, result.KthFromEnd(1));
    }

    // [Fact]
    // public void LinkedList_ZipLists_One_List_Empty()
    // {
    //     LinkedList list1 = new LinkedList();
    //     list1.Insert(1);
    //     list1.Insert(2);

    //     LinkedList list2 = new LinkedList();

    //     LinkedList result = LinkedList.ZipLists(list1, list2);

    //     Assert.Equal(1, result.KthFromEnd(2));
    //     Assert.Equal(2, result.KthFromEnd(1));
    // }

    // [Fact]
    // public void LinkedList_ZipLists_Both_Lists_Empty()
    // {
    //     LinkedList list1 = new LinkedList();
    //     LinkedList list2 = new LinkedList();

    //     LinkedList result = LinkedList.ZipLists(list1, list2);

    //     Assert.Null(result.head);
    // }
}
}