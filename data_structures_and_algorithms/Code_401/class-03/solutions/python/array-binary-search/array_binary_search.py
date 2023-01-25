def binary_search_i(nums, key):

    left = 0

    right = len(nums) - 1

    while left <= right:

        mid = (right - left) // 2 + left

        candidate = nums[mid]

        if candidate == key:
            return mid
        elif key < candidate:
            right = mid - 1
        else:
            left = mid + 1

    return -1


def binary_search(nums, key, left=0, right=None):

    if right is None:
        right = len(nums) - 1

    if right < left:
        return -1

    mid = (right - left) // 2 + left

    candidate = nums[mid]

    if candidate == key:

        return mid

    elif key < candidate:

        return binary_search(nums, key, left, mid - 1)

    else:

        return binary_search(nums, key, mid + 1, right)
