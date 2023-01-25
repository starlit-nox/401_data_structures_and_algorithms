def tree_intersection(tree_a, tree_b):
    a_values_table = {}
    common_values = []

    _add_to_table(tree_a.root, a_values_table)
    
    _find_common(tree_b.root, a_values_table, common_values)

    return common_values


def _add_to_table(root, ht):
    if not root:
        return

    ht[root.value] = True

    _add_to_table(root.left, ht)
    _add_to_table(root.right, ht)


def _find_common(root, values_table, common):
    if not root:
        return

    if root.value in values_table:
        common.append(root.value)

    _find_common(root.left, values_table, common)
    _find_common(root.right, values_table, common)


def tree_intersection_iterable(tree_a, tree_b):
    """
    If iterable BinaryTree implementation then below solution is great for readability
    """

    a_values_table = {}
    common_values = []

    for value in tree_a:
        a_values_table[value] = True

    for value in tree_b:
        if value in a_values_table:
            common_values.append(value)

    return common_values

def tree_intersection_one_liner(tree_a, tree_b):
    """
    If Tree implementation is iterable then 
    convert trees to sets
    then cast intersection to list
    """
    return list(set(tree_b) & set(tree_a))


"""Algo

Traverse tree_a and create a hashtable of it's values,
    where key is each node's value and the value is True

Traverse tree_b and store
each value in tree_b that is found in a_values hashtable

return list of intersecting values
"""
