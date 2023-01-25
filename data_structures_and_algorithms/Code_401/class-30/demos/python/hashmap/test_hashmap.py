from hashmap import Hashmap


def test_get_apple():
    hashmap = Hashmap()
    hashmap.set("apple", "Used for apple sauce")
    actual = hashmap.get("apple")
    expected = "Used for apple sauce"
    assert actual == expected


def test_internals():
    hashmap = Hashmap(1024)
    hashmap.set("ahmad", 30)
    hashmap.set("silent", True)
    hashmap.set("listen", "to me")

    actual = []

    # NOTE: purposely breaking encapsulation to test the "internals" of Hashmap
    for item in hashmap._buckets:
        if item:
            actual.append(item.display())

    expected = [[["silent", True], ["listen", "to me"]], [["ahmad", 30]]]

    assert actual == expected
