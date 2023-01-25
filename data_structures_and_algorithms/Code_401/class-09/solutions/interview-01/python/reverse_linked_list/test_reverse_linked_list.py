from reverse_linked_list import reverse_linked_list, LinkedList


def test_reverse_none():
    ll = LinkedList()
    expected = ""
    flipped = reverse_linked_list(ll)
    actual = str(flipped)
    assert actual == expected


def test_reverse_one():
    ll = LinkedList(["apple"])
    expected = "[apple] -> X"
    flipped = reverse_linked_list(ll)
    actual = str(flipped)
    assert actual == expected


def test_reverse_three():
    ll = LinkedList(["apple", "banana", "cucumber"])
    expected = "[cucumber] -> [banana] -> [apple] -> X"
    flipped = reverse_linked_list(ll)
    actual = str(flipped)
    assert actual == expected

