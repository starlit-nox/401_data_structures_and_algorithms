class PseudoQueue:
    def __init__(self):
        self._inbox = Stack()
        self._outbox = Stack()

    def enqueue(self, value):

        while not self._outbox.is_empty():
            self._inbox.push(self._outbox.pop())

        self._inbox.push(value)

    def dequeue(self):
        
        while not self._inbox.is_empty():
            self._outbox.push(self._inbox.pop())

        if self._outbox.is_empty():
            raise RuntimeError("Cannot dequeue from empty queue")

        return self._outbox.pop()
    

class Stack:
    def __init__(self):
        self.top = None

    def push(self, value):
        self.top = Node(value, self.top)

    def pop(self):

        if not self.top:
            raise RuntimeError("Cannot pop from empty stack")

        popped = self.top
        self.top = self.top.next
        return popped.value

    def peek(self):

        if not self.top:
            raise RuntimeError("Cannot peek on empty stack")

        return self.top.value

    def is_empty(self):
        return self.top is None


class Node:
    def __init__(self, value, next=None):
        self.value = value
        self.next = next
