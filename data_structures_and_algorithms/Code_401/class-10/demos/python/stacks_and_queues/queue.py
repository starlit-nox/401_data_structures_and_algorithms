from collections import deque


class Queue:
    """
    Not what you're being asked to do for lab
    but probably how you'd do in real life
    """

    def __init__(self):
        """
        Notice that we have an attribute responsible for our storage
        vs. extending from the storage class itself.
        This follows the "favor composition" guideline, which is
        an important OOP concept 
        """
        self.storage = deque()

    def enqueue(self, value):
        self.storage.appendleft(value)

    def dequeue(self):
        return self.storage.pop()

    def peek(self):
        return self.storage[-1]

    def is_empty(self):
        return len(self.storage) == 0
