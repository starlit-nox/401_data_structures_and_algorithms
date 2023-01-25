class BinaryTree:
    def __init__(self):
        self.root = None

    def find_max(self):
        
        if not self.root:
            raise ValueError("Empty Tree")

        max_val = self.root.value

        def traverse(root, max_so_far):

            # nonlocal max_val

            if not root:
                return max_so_far

            if root.value > max_so_far:
                # max_val = root.value
                max_so_far = root.value

            max_so_far = traverse(root.left, max_so_far)
            max_so_far = traverse(root.right, max_so_far)


        max_val = traverse(self.root, max_val)

        return max_val

class Node:
    def __init__(self, value, left=None, right=None):
        self.value = value
        self.left = left
        self.right = right
