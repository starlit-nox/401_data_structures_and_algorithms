using StackQueuePsuedos;
using Xunit;

namespace CodeChallengeTests
{
  public class CodeChallenge11Tests
  {
    [Fact]
    public void Enqueue_WhenCalled_AddsItemToThePseudoQueue()
    {
      // Arrange
      var pseudoQueue = new StackQueuePsuedo();

      // Act
      pseudoQueue.Enqueue(1);
      pseudoQueue.Enqueue(2);
      pseudoQueue.Enqueue(3);

      // Assert
      Assert.Equal(1, pseudoQueue.Dequeue());
      Assert.Equal(2, pseudoQueue.Dequeue());
      Assert.Equal(3, pseudoQueue.Dequeue());
    }

    [Fact]
    public void Dequeue_EmptyQueue_ThrowsInvalidOperationException()
    {
      // Arrange
      var pseudoQueue = new StackQueuePsuedo();

      // Act & Assert
      Assert.Throws<InvalidOperationException>(() => pseudoQueue.Dequeue());
    }

    [Fact]
    public void EnqueueAndDequeue_InterleavedOperations_ExpectedOrder()
    {
      // Arrange
      var pseudoQueue = new StackQueuePsuedo();

      // Act
      pseudoQueue.Enqueue(11);
      pseudoQueue.Enqueue(12);
      var firstDequeue = pseudoQueue.Dequeue();
      pseudoQueue.Enqueue(13);
      var secondDequeue = pseudoQueue.Dequeue();

      // Assert
      Assert.Equal(11, firstDequeue);
      Assert.Equal(12, secondDequeue);
      Assert.Equal(13, pseudoQueue.Dequeue());
    }
  }
}