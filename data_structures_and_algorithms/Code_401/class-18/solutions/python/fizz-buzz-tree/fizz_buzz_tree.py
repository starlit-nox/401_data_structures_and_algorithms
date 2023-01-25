from collections import deque


def fizz_buzz_tree(tree):
    def fizzify(num):
        txt = ""
        if num % 3 == 0:
            txt += "Fizz"
        if num % 5 == 0:
            txt += "Buzz"
        return txt or str(num)

    return clone_tree(tree, fizzify)


def clone_tree(source_tree, mapper=lambda x: x):
    """
    Clone a KaryTree optionally applying a transformation to value.
    """

    if not source_tree:
        return None

    def walk(source_root, clone_root):
        if not source_root:
            return

        for source_child in source_root.children:
            clone_value = mapper(source_child.value)
            clone_child = Node(clone_value)
            clone_root.children.append(clone_child)
            walk(source_child, clone_child)

    clone_tree = KaryTree()

    if source_tree.root:
        clone_tree.root = Node(mapper(source_tree.root.value))
        walk(source_tree.root, clone_tree.root)

    return clone_tree


class KaryTree:
    def __init__(self, root=None):
        self.root = root


class Node:
    """K-Ary Tree Node"""

    def __init__(self, value):
        self.value = value
        self.children = []
