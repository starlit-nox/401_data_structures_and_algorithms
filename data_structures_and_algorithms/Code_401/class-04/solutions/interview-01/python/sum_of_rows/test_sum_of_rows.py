from sum_of_rows import sum_rows


def test_all_positives():
    matrix = [[1, 2, 3], [3, 5, 7], [1, 7, 10]]
    expected = [6, 15, 18]
    actual = sum_rows(matrix)
    assert actual == expected


def test_some_negatives():
    matrix = [[0, 1, 5], [-4, 7, 2], [-3, 12, 11]]
    expected = [6, 5, 20]
    actual = sum_rows(matrix)
    assert actual == expected


def test_with_nulls():
    matrix = [[0, 1, None], [-4, None, 2], [None, 12, 11]]
    expected = [1, -2, 23]
    actual = sum_rows(matrix)
    assert actual == expected

