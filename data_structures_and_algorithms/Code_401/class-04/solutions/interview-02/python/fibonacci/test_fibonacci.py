from fibonacci import fib_sum, fib_sum_iterative
import pytest


def test_sum_zero():
    expected = 0
    actual = fib_sum(0)
    assert expected == actual


def test_sum_one():
    expected = 1
    actual = fib_sum(1)
    assert expected == actual


def test_sum_two():
    expected = 1
    actual = fib_sum(2)
    assert expected == actual


def test_sum_three():
    expected = 2
    actual = fib_sum(3)
    assert expected == actual


def test_sum_four():
    expected = 3
    actual = fib_sum(4)
    assert expected == actual


def test_sum_eight():
    expected = 21
    actual = fib_sum(8)
    assert expected == actual


def test_sum_fourteen():
    expected = 377
    actual = fib_sum(14)
    assert expected == actual


@pytest.mark.skip("takes a long time on most computers")
def test_sum_forty_five():
    expected = 1134903170
    actual = fib_sum(45)
    assert expected == actual


def test_sum_zero_iterative():
    expected = 0
    actual = fib_sum_iterative(0)
    assert expected == actual


def test_sum_one_iterative():
    expected = 1
    actual = fib_sum_iterative(1)
    assert expected == actual


def test_sum_two_iterative():
    expected = 1
    actual = fib_sum_iterative(2)
    assert expected == actual


def test_sum_three_iterative():
    expected = 2
    actual = fib_sum_iterative(3)
    assert expected == actual


def test_sum_four_iterative():
    expected = 3
    actual = fib_sum_iterative(4)
    assert expected == actual


def test_sum_eight_iterative():
    expected = 21
    actual = fib_sum_iterative(8)
    assert expected == actual


def test_sum_fourteen_iterative():
    expected = 377
    actual = fib_sum_iterative(14)
    assert expected == actual


def test_sum_forty_five_iterative():
    expected = 1134903170
    actual = fib_sum_iterative(45)
    assert expected == actual

