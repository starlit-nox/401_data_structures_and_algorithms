def insert_shift_array(arr, val):
    """Inserts value into given array at mid point

    Arguments:
        arr {sequence} -- [Any sequence that can be converted to a list]
        val {[any]} -- [the value to insert]

    Returns:
        [list] -- [new list with value inserted in middle]
    """
    lst = list(arr)
    mid = (len(lst) + 1) // 2
    return lst[:mid] + [val] + lst[mid:]
