# Comparators

SWBAT...

- implement comparator callbacks to control sorting domain objects.
- explain how sorting algorithms use the `< 0`, `0`, and `> 0` return values to control their results.
- identify situations where testing callbacks is easier & more robust than testing entire algorithms.

When faced with a sorting problem, engineers will rarely need to write a sorting algorithm implementation.
We do often need to provide comparators.
Comparators are callback functions for `sort` implementations.
They tell the sort algorithm how it will order the items in the collection.
This code challenge introduces students to the concept of the comparator.
It builds on their knowledge of callbacks in `map`, `filter`, and `reduce`.
It also expands their intuitive understanding of `<` as the comparator for numbers to compare their custom data types.

It has a secondary goal of showing that testing callbacks is much easier than testing algorithms as a whole.
The provided starter code has big-picture tests to prove that the student's sort usages work, but they are big & bulky & hard to debug.
The second part of the assignment is to extract the comparators and focus on them in isolation.
This builds experience with the callbacks themselves, as well as writing narrow tests in isolation.

## Warnings

### In place sort

While not critical in this lab, students will at some point need to be aware of in-place sort modifying the underlying array.
