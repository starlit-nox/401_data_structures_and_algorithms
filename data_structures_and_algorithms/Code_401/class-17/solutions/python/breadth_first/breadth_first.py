from collections import deque


class BinaryTree:
    """Simple BinaryTree with enough functionality for breadth first operations"""

    def __init__(self):
        self._root = None

    def add(self, value):

        node = _Node(value)

        if not self._root:
            self._root = node
            return

        q = Queue()

        q.enqueue(self._root)

        while not q.is_empty():

            current = q.dequeue()

            if current.left:
                q.enqueue(current.left)
            else:
                current.left = node
                break

            if current.right:
                q.enqueue(current.right)
            else:
                current.right = node
                break

    @staticmethod
    def breadth_first(tree):

        if not tree or not tree._root:
            return []

        values = []

        q = Queue()

        q.enqueue(tree._root)

        while not q.is_empty():

            current = q.dequeue()

            if current.left:
                q.enqueue(current.left)

            if current.right:
                q.enqueue(current.right)

            values.append(current.value)

        return values


class _Node:
    """Protected Tree Node"""
    def __init__(self, value, left=None, right=None):
        self.value = value
        self.left = left
        self.right = right


class Queue:
    """Implementation of Queue that "composes" built in deque class"""

    def __init__(self):
        self._dq = deque()

    def enqueue(self, value):
        self._dq.appendleft(value)

    def dequeue(self):
        return self._dq.pop()

    def peek(self):
        return self._dq[-1]

    def is_empty(self):
        return len(self._dq) == 0
