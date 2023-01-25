// AnimalShelter code challenge solution.

import java.util.LinkedList;

public class AnimalShelter {
  
  // static classes, just so that we have a dog class and a cat class to reference
  static class Dog {}

  static class Cat{}

  // instance variables: two queues (using LinkedLists for portability), one for each animal type
  private LinkedList<Dog> dogs;
  private LinkedList<Cat> cats;

  public AnimalShelter() {
    this.dogs = new LinkedList<>();
    this.cats = new LinkedList<>();
  }

  // overloaded enqueue method to automatically handle dogs vs cats
  public void enqueue(Dog d) {
    this.dogs.add(d);
  }

  public void enqueue(Cat c) {
    this.cats.add(c);
  }

  // type-parameterized dequeue method to return the type the user wants
  public <T> T dequeue(Class<T> type) {
    if(type == Dog.class) {
      return (T)this.dogs.poll();
    } else if (type == Cat.class) {
      return (T)this.cats.poll();
    } else {
      throw new IllegalArgumentException("This shelter only supports cats and dogs.");
    }
  }


  // main method for standalone testing
  public static void main(String[] args) {
    AnimalShelter as = new AnimalShelter();
    Dog d1 = new Dog();
    Dog d2 = new Dog();
    Cat c1 = new Cat();
    Cat c2 = new Cat();
    Cat c3 = new Cat();
    as.enqueue(d1);
    as.enqueue(d2);
    as.enqueue(c1);
    assert c1 == as.dequeue(Cat.class);
    assert d1 == as.dequeue(Dog.class);
    as.enqueue(c2);
    as.enqueue(c3);
    assert c2 == as.dequeue(Cat.class);
    assert c3 == as.dequeue(Cat.class);
    assert d2 == as.dequeue(Dog.class);
  }
}
