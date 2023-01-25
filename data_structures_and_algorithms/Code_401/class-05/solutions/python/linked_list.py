class LinkedList:
    """
    Put docstring here
    """

    def __init__(self, values=None):
        self.head = None
        if values:
            for value in reversed(values):
                self.insert(value)

    def __str__(self):
        text = ""

        current = self.head

        while current:
            text += f"{{ {current.value} }} -> "
            current = current.next

        return text + "NULL"

    def insert(self, value):
        self.head = Node(value, self.head)

    def includes(self, value):
        current = self.head
        while current:
            if current.value == value:
                return True

            current = current.next

        return False

    def append(self, value):

        node = Node(value)

        if not self.head:
            self.head = node
            return

        current = self.head

        while current.next:
            current = current.next

        if current:
            current.next = node

    def insert_before(self, before_value, insert_value):

        if not self.head:
            raise TargetError

        if self.head.value == before_value:
            self.head = Node(insert_value, self.head)
            return

        current = self.head

        while current.next:
            if current.next.value == before_value:
                current.next = Node(insert_value, current.next)
                return
            current = current.next

        raise TargetError

    def insert_after(self, after_value, insert_value):

        current = self.head

        while current:
            if current.value == after_value:
                current.next = Node(insert_value, current.next)
                return

            current = current.next

        raise TargetError

    def kth_from_end(self, k):
        current = self.head
        length = 0
        while current:
            length += 1
            current = current.next

        current = self.head

        steps_remaining = length - k - 1

        if steps_remaining < 0:
            raise TargetError

        for _ in range(steps_remaining):
            current = current.next
            if not current:
                raise TargetError

        return current.value


class Node:
    def __init__(self, value, next_=None):
        self.value = value
        self.next = next_


class TargetError(Exception):
    pass
