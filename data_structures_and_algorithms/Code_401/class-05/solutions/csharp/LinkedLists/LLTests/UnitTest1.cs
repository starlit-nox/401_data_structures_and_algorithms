using System;
using Xunit;
using LinkedLists.Classes;

namespace LLTests
{
    public class UnitTest1
    {
        [Fact]
        public void CanInstantiateEmptyList()
        {
            LinkList ll = new LinkList();
            Assert.Null(ll.Head);
        }

        [Fact]
        public void CanInsertIntoLinkedList()
        {
            LinkList ll = new LinkList(4);

            bool value = ll.Includes(4);
            Assert.True(value);

        }

        [Fact]
        public void HeadPointsToFirstNodeInLinkedList()
        {
            LinkList ll = new LinkList();
            ll.Insert(10);
            ll.Insert(14);

            Assert.Equal(14, ll.Head.Value);
        }

        [Fact]
        public void CanInsertMultipleNodesIntoLinkedList()
        {
            LinkList ll = new LinkList(4);
            ll.Insert(8);
            ll.Insert(15);
            ll.Insert(16);


            bool value = ll.Includes(15);
            Assert.True(value);
        }

        [Fact]
        public void CannotFindNodeThatDoesNotExist()
        {
            LinkList ll = new LinkList(4);
            ll.Insert(8);
            ll.Insert(15);
            ll.Insert(16);

            bool value = ll.Includes(20);
            Assert.False(value);
        }
    }
}
