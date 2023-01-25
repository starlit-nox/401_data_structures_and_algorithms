import string


def first_repeated_word(txt):

    # odd, but preferred, way to strip punctuation
    txt = txt.translate(str.maketrans("", "", string.punctuation))
    words = set()
    for word in txt.split():
        word = word.lower()
        if word in words:
            return word
        words.add(word)

    return None
