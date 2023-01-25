from collections import deque


class Queue(deque):
    """Extend deque to expose Queue operations"""

    def enqueue(self, value):
        self.append(value)

    def dequeue(self):
        return self.popleft()


class AnimalShelter:
    def __init__(self):
        self.storage = Queue()

    def enqueue(self, animal):
        self.storage.enqueue(animal)

    def dequeue(self, pref):

        if not pref in ["dog", "cat"]:

            return None

        animal = None

        front = None

        current = self.storage.dequeue()

        while current != front:

            front = front or current

            if self._is_preferred(pref, current):

                if current == front:
                    return current

                animal = animal or current

            self.storage.enqueue(current)

            current = self.storage.dequeue()

        return animal

    def _is_preferred(self, pref, animal):

        if pref == "cat":
            clazz = Cat
        elif pref == "dog":
            clazz = Dog

        return isinstance(animal, clazz)


class Dog:
    def __repr__(self):
        return "I am a Dog instance"


class Cat:
    def __repr__(self):
        return "I am a Cat instance"
