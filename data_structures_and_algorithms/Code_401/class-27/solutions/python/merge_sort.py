def merge_sort(items):
    
    return divide(items, glue = merge)

    
def divide(items, glue):

    # conquer step - recursive base case
    if len(items) < 2:
        return items

    mid = len(items) // 2

    left = divide(items[0:mid], glue)

    right = divide(items[mid:], glue)

    # "glue" it all back together
    return glue(left, right)


def merge(left, right):

    result = []

    while left or right:

        if not left:
            result += right
            break
        
        if not right:
            result += left
            break

        # To ponder: what, if any, are the big O implications
        # of removing from front of collection?
        # Are there other data structures that may be more efficient?
        if left[0] < right[0]:
            result.append(left.pop(0))
        else:
            result.append(right.pop(0))

    return result

        

