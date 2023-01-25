def multi_bracket_validation(text):

    pair_map = {
        "[": "]",
        "{": "}",
        "(": ")",
    }

    # no easy access to custom stack so use List in a last-in-first-out way
    stack = [] 

    for char in text:

        if char in pair_map:

            stack.append(char)

        elif char in pair_map.values():

            if not len(stack):
                return False

            opener = stack.pop()

            if char != pair_map[opener]:
                return False

    return len(stack) == 0
