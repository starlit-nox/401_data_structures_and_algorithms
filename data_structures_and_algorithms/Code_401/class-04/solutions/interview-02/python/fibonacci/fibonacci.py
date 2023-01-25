def fib_sum(n):

    if n < 2:
        return n

    return fib_sum(n - 1) + fib_sum(n - 2)


def fib_sum_iterative(n):

    if n < 2:
        return n

    sums = []

    sums.append(0)

    sums.append(1)

    for i in range(2, n + 1):
        sums.append(sums[i - 1] + sums[i - 2])

    return sums[n]
