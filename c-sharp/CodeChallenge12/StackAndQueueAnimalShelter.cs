namespace CodeChallenges
{
  public class Animal
  {
    public string Species { get; set; }
    public string Name { get; set; }

    public Animal(string species, string name)
    {
      Species = species;
      Name = name;
    }
  }

  public class StackAndQueueAnimalShelter
  {
    private Queue<Animal> dogsQueue;
    private Queue<Animal> catsQueue;

    public StackAndQueueAnimalShelter()
    {
      dogsQueue = new Queue<Animal>();
      catsQueue = new Queue<Animal>();
    }

    public void Enqueue(Animal animal)
    {
      if (animal.Species == "dog")
      {
        dogsQueue.Enqueue(animal);
      }
      else if (animal.Species == "cat")
      {
        catsQueue.Enqueue(animal);
      }
    }

    public Animal Dequeue(string pref)
    {
      if (pref == "dog")
      {
        if (dogsQueue.Count > 0)
        {
          return dogsQueue.Dequeue();
        }
      }
      else if (pref == "cat")
      {
        if (catsQueue.Count > 0)
        {
          return catsQueue.Dequeue();
        }
      }

      return null;
    }
  }
}
