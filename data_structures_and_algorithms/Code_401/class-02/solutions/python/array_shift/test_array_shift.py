from array_shift import insert_shift_array


def test_even():
    expected = [2, 4, 5, 6, 8]
    actual = insert_shift_array([2, 4, 6, 8], 5)
    assert actual == expected


def test_odd():
    expected = [4, 8, 15, 16, 23, 42]
    actual = insert_shift_array([4, 8, 15, 23, 42], 16)
    assert actual == expected


def test_empty():
    expected = [4]
    actual = insert_shift_array([], 4)
    assert actual == expected


def test_other_value_types():
    expected = [2, 4, None, 6, 8]
    actual = insert_shift_array([2, 4, 6, 8], None)
    assert actual == expected
