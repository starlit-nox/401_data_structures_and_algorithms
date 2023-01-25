from array_binary_search import binary_search


def test_one_item():
    actual = binary_search(["apples"], "apples")
    expected = 0
    assert actual == expected


def test_three_items_key_in_middle():
    actual = binary_search(["a", "b", "c"], "b")
    expected = 1
    assert actual == expected


def test_sample_1():
    actual = binary_search([4, 8, 15, 16, 23, 42], 15)
    expected = 2
    assert actual == expected


def test_sample_2():
    actual = binary_search([11, 22, 33, 44, 55, 66, 77], 90)
    expected = -1
    assert actual == expected
