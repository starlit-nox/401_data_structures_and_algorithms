def sum_rows(matrix):
    """
    For input matrix of n rows
    return list of n length with the sums of each row
    """

    sums = []

    for row in matrix:

        sum = 0

        for column in row:

            # handle None
            column_val = column or 0

            sum += column_val

        sums.append(sum)

    return sums
