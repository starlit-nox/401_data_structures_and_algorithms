from insertion_sort import insertion_sort


def test_exists():
    assert insertion_sort


def test_unordered_sort():
    lst = [3, 1, 5, 2, 4]

    insertion_sort(lst)

    assert lst == [1, 2, 3, 4, 5]


def test_ordered_sort():
    lst = [1, 2, 3, 4, 5]

    insertion_sort(lst)

    assert lst == [1, 2, 3, 4, 5]


def test_reversed_sort():
    lst = [5, 4, 3, 2, 1]

    insertion_sort(lst)

    assert lst == [1, 2, 3, 4, 5]


def test_single_item():
    lst = [4]

    insertion_sort(lst)

    assert lst == [4]


def test_no_items():
    lst = []

    insertion_sort(lst)

    assert lst == []

