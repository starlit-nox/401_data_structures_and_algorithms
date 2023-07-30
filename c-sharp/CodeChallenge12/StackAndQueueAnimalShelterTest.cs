using CodeChallenges;
using Xunit;
using System.Reflection;

namespace CodeChallengeTests
{
  public class CodeChallenge12Tests
  {
    private MethodInfo EnqueueMethod;
    private MethodInfo DequeueMethod;
    public CodeChallenge12Tests()
    {
      EnqueueMethod = typeof(AnimalShelter).GetMethod("Enqueue");
      DequeueMethod = typeof(AnimalShelter).GetMethod("Dequeue");
    }
    [Fact]
    public void Enqueue_Should_Add_Dog_To_DogsQueue()
    {
      // Arrange
      var animalShelter = new AnimalShelter();
      var dog = new Animal { Species = "dog", Name = "Max" };
      // Act
      EnqueueMethod.Invoke(animalShelter, new object[] { dog });
      var result = DequeueMethod.Invoke(animalShelter, new object[] {"dog"});
      // Assert
      Assert.Equal(dog, result);
    }

    [Fact]
    public void Enqueue_Should_Add_Cat_To_CatsQueue()
    {
      // Arrange
      var animalShelter = new AnimalShelter();
      var cat = new Animal { Species = "cat", Name = "Whiskers" };

      // Act
      EnqueueMethod.Invoke(animalShelter, new object[] { cat });
      var result = DequeueMethod.Invoke(animalShelter, new object[] { "cat" });

      // Assert
      Assert.Equal(cat, result);
    }

    [Fact]
    public void Enqueue_Should_Ignore_Animal_With_Invalid_Species()
    {
      // Arrange
      var animalShelter = new AnimalShelter();
      var bird = new Animal { Species = "bird", Name = "Tweety" };

      // Act
      EnqueueMethod.Invoke(animalShelter, new object[] { bird });
      var result = DequeueMethod.Invoke(animalShelter, new object[] { "bird" });


      // Assert
      Assert.Null(result);
    }

    [Fact]
    public void Dequeue_Should_Return_Dog_When_Preference_Is_Dog()
    {
      // Arrange
      var animalShelter = new AnimalShelter();
      var dog1 = new Animal { Species = "dog", Name = "Rover" };
      var dog2 = new Animal { Species = "dog", Name = "Buddy" };

      EnqueueMethod.Invoke(animalShelter, new object[] { dog1 });
      EnqueueMethod.Invoke(animalShelter, new object[] { dog2 });


      // Act
      var result = DequeueMethod.Invoke(animalShelter, new object[] { "dog" });

      // Assert
      Assert.Equal(dog1, result);
    }

    [Fact]
    public void Dequeue_Should_Return_Cat_When_Preference_Is_Cat()
    {
      // Arrange
      var animalShelter = new AnimalShelter();
      var cat1 = new Animal { Species = "cat", Name = "Fluffy" };
      var cat2 = new Animal { Species = "cat", Name = "Whiskers" };

      EnqueueMethod.Invoke(animalShelter, new object[] { cat1 });
      EnqueueMethod.Invoke(animalShelter, new object[] { cat2 });

      // Act
      var result = DequeueMethod.Invoke(animalShelter, new object[] { "cat"});

      // Assert
      Assert.Equal(cat1, result);
    }

    [Fact]
    public void Dequeue_Should_Return_Null_When_Preference_Is_Invalid()
    {
      // Arrange
      var animalShelter = new AnimalShelter();
      var dog = new Animal { Species = "dog", Name = "Buddy" };

      EnqueueMethod.Invoke(animalShelter, new object[] { dog });

      // Act
      var result = DequeueMethod.Invoke(animalShelter, new object[] { "bird" });

      // Assert
      Assert.Null(result);
    }

    [Fact]
    public void Dequeue_Should_Return_Null_When_No_Animals_Of_Preference_Are_Available()
    {
      // Arrange
      var animalShelter = new AnimalShelter();
      var cat = new Animal { Species = "cat", Name = "Whiskers" };

      EnqueueMethod.Invoke(animalShelter, new object[] { cat });
      // Act
      var dequeuedDog = DequeueMethod.Invoke(animalShelter, new object[] { "dog" });

      // Assert
      Assert.Null(dequeuedDog);
    }
  }
}
