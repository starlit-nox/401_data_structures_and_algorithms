def reverse_array(my_list):

    reversed_list = []

    for i in range(len(my_list)):
        reversed_list.append(my_list[-(i + 1)])

    return reversed_list


def reverse_array_pure_2(my_list):

    return [my_list[-(i + 1)] for i in range(len(my_list))]


def reverse_array_in_place(my_list):

    for i in range(0, len(my_list) // 2):
        my_list[i], my_list[-(i + 1)] = my_list[-(i + 1)], my_list[i]

    return my_list
