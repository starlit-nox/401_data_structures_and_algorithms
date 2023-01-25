from linked_list import LinkedList


class Hashmap:
    """
    This class simulates the functionality of the hashmap.

    Run 'python -m doctest -v hashmap.py' in terminal in action
    Hover over Hashmap class definition to also see doctest in action
    Try breaking expected values and see what happens

    Use doctest WITH unit tests, NOT INSTEAD of unit tests

    Some tests:
    >>> hashmap = Hashmap(1024)
    >>> hashmap.set('ahmad', 30)
    >>> hashmap.set('silent', True)
    >>> hashmap.set('listen', 'to me')
    >>> for item in hashmap._buckets:
    ...     if item:
    ...         item.display()
    [['silent', True], ['listen', 'to me']]
    [['ahmad', 30]]
    """

    def __init__(self, size=1024):
        self.size = size
        self._buckets = [None] * size

    def _hash(self, key):
        h = 0
        for ch in key:
            h += ord(ch)
        h = (h * 19) % self.size
        return h

    def set(self, key, value):
        hashed_key = self._hash(key)

        if not self._buckets[hashed_key]:
            self._buckets[hashed_key] = LinkedList()

        self._buckets[hashed_key].add([key, value])

    def get(self, key):
        hashed_key = self._hash(key)

        bucket = self._buckets[hashed_key]

        current = bucket.head

        while current:
            if current.data[0] == key:
                return current.data[1]

        raise KeyError("Key not found", key)
