from reverse_array import reverse_array


def test_reverse_array_even():
    four_in_order = ["Josie", "Belle", "Frodo", "Trinity"]
    expected = four_in_order[::-1]
    actual = reverse_array(four_in_order)
    assert actual == expected


def test_reverse_array_add():
    five_in_order = ["Josie", "Belle", "Frodo", "Trinity", "Leia"]
    expected = five_in_order[::-1]
    actual = reverse_array(five_in_order)
    assert actual == expected


def test_array_not_mutated():
    four_in_order = ["Josie", "Belle", "Frodo", "Trinity"]
    four_in_order_clone = four_in_order[:]
    reverse_array(four_in_order)
    assert four_in_order == four_in_order_clone


def test_single_item():
    actual = reverse_array(["Josie"])
    expected = ["Josie"]
    assert actual == expected

