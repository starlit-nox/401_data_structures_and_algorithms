import pytest
from merge_sort import merge_sort, merge as combine

def test_exists():
    assert merge_sort

def test_empty():
    assert merge_sort([]) == []

def test_sort_single():
    assert merge_sort([5]) == [5]

def test_combine():
    assert combine([3,5],[4,6]) == [3,4,5,6]

def test_combine_ragged():
    assert combine([3,5],[4,6,9,11,32]) == [3,4,5,6,9,11,32]

def test_sort_double():
    assert merge_sort([5,1]) == [1,5]

def test_sort_double_sorted():
    assert merge_sort([1,5]) == [1,5]

def test_sort_triple():
    assert merge_sort([3,5,1]) == [1,3,5]

def test_sort_quadruple():
    assert merge_sort([3,5,2,7]) == [2,3,5,7]

def test_sort_ragged():
    assert merge_sort([5,2,8,3,9]) == [2,3,5,8,9]

def test_sort_reversed():
    assert merge_sort([9,8,5,3,2]) == [2,3,5,8,9]
