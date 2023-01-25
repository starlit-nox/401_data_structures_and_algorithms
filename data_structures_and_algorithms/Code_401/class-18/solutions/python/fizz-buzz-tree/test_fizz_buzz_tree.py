import pytest
from fizz_buzz_tree import KaryTree, Node, fizz_buzz_tree


@pytest.fixture
def tree():
    one = Node(1)
    two = Node(2)
    three = Node(3)
    four = Node(4)
    five = Node(5)
    six = Node(6)
    seven = Node(7)
    eight = Node(8)
    nine = Node(9)
    ten = Node(10)
    eleven = Node(11)
    twelve = Node(12)
    thirteen = Node(13)
    fourteen = Node(14)
    fifteen = Node(15)

    """
                            1
                2                       3
            4  5  6               7     8          9
           10  11 12              13            14   15
    """

    one.children = [two, three]
    two.children = [four, five, six]
    three.children = [seven, eight, nine]
    four.children = [ten]
    five.children = [eleven]
    six.children = [twelve]
    seven.children = [thirteen]
    nine.children = [fourteen, fifteen]

    return KaryTree(one)


# TESTS
def test_fizz_buzz_tree(tree):
    fizzy_tree = fizz_buzz_tree(tree)
    assert fizzy_tree.root.value == "1"

    ones_children = [child.value for child in fizzy_tree.root.children]
    assert ones_children == ["2", "Fizz"]

    twos_children = [child.value for child in fizzy_tree.root.children[0].children]
    assert twos_children == ["4", "Buzz", "Fizz"]

    threes_children = [child.value for child in fizzy_tree.root.children[1].children]
    assert threes_children == ["7", "8", "Fizz"]

    nines_children = [
        child.value for child in fizzy_tree.root.children[1].children[2].children
    ]
    assert nines_children == ["14", "FizzBuzz"]
