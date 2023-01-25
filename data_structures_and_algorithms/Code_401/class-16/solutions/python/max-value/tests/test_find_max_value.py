from max_value.max_value import BinaryTree, Node

def test_max_val():
    tree = BinaryTree()
    tree.root = Node(10)
    tree.root.left = Node(30)
    tree.root.right = Node(-7)

    actual = tree.find_max()
    expected = 30

    assert actual == expected

