class LinkedList:
    def __init__(self, sequence=[]):
        self.head = None
        for item in sequence:
            self.insert(item)

    def insert(self, value):

        node = Node(value)

        if not self.head:
            self.head = Node(value)
            return

        current = self.head

        while current.next:
            current = current.next

        current.next = node

    def __str__(self):

        txt = ""

        current = self.head

        while current:
            txt += f"[{current.value}] -> "
            current = current.next
            if not current:
                txt += "X"

        return txt


class Node:
    def __init__(self, value, next=None):
        self.value = value
        self.next = next


def reverse_linked_list(ll):
    prev = None
    current = ll.head
    while current:
        next_node = current.next
        current.next = prev
        prev = current
        current = next_node

    ll.head = prev

    return ll

