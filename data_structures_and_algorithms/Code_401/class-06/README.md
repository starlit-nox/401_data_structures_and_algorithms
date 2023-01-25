# Code Challenge

Extend a Linked List to allow various insertion methods.

## Specifications

- Read all of these instructions carefully.
- Name things exactly as described.
- Do all your work in a your `data-structures-and-algorithms` public repository.
- Create a new branch in your repo named as noted below.
- Follow the language-specific instructions for the challenge type listed below.
- Update the "Table of Contents" - in the README at the root of the repository - with a link to this challenge's README file.

### Challenge Setup & Execution

**Branch Name:** `linked-list-insertions`

**Challenge Type:** Extending an Implementation

## Feature Tasks

Write the following methods for the Linked List class:

- append
  - arguments: new value
  - adds a new node with the given `value` to the end of the list
- insert before
  - arguments: value, new value
  - adds a new node with the given new value immediately before the first node that has the value specified
- insert after
  - arguments: value, new value
  - adds a new node with the given new value immediately after the first node that has the value specified

## Examples

### Append

| Initial List | Method Args | Resulting List |
|-----|:----:|----|
| `head -> {1} -> {3} -> {2} -> X` | `5` | `head -> {1} -> {3} -> {2} -> {5} -> X` |
| `head -> X` | `1` | `head -> {1} -> X` |

### Insert Before

| Initial List | Method Args | Resulting List |
|-----|:----:|----|
| `head -> {1} -> {3} -> {2} -> X` | `3, 5` | `head -> {1} -> {5} -> {3} -> {2} -> X` |
| `head -> {1} -> {3} -> {2} -> X` | `1, 5` | `head -> {5} -> {1} -> {3} -> {2} -> X` |
| `head -> {1} -> {2} -> {2} -> X` | `2, 5` | `head -> {1} -> {5} -> {2} -> {2} -> X` |
| `head -> {1} -> {3} -> {2} -> X` | `4, 5` | No change, method exception |

### Insert After

| Initial List | Method Args | Resulting List |
|-----|:----:|----|
| `head -> {1} -> {3} -> {2} -> X` | `3, 5` | `head -> {1} -> {3} -> {5} -> {2} -> X` |
| `head -> {1} -> {3} -> {2} -> X` | `2, 5` | `head -> {1} -> {3} -> {2} -> {5} -> X` |
| `head -> {1} -> {2} -> {2} -> X` | `2, 5` | `head -> {1} -> {2} -> {5} -> {2} -> X` |
| `head -> {1} -> {3} -> {2} -> X` | `4, 5` | No change, method exception |

## Unit Tests

For this and all future code challenges, write tests.

Utilize the Single-responsibility principle: any methods you write should be clean, reusable, abstract component parts to the whole challenge. You will be given feedback and marked down if you attempt to define a large, complex algorithm in one function definition.

You have access to the Node class and all the properties on the Linked List class.

Write tests to prove the following functionality:

1. Can successfully add a node to the end of the linked list
2. Can successfully add multiple nodes to the end of a linked list
3. Can successfully insert a node before a node located i the middle of a linked list
4. Can successfully insert a node before the first node of a linked list
5. Can successfully insert after a node in the middle of the linked list
6. Can successfully insert a node after the last node of the linked list

Unit tests *must be passing* before you submit your final solution code.

## Stretch Goal

Once you've achieved a working solution, write an additional method to delete a node with the given value from the linked list.

## Requirements

Ensure your complete solution follows the standard requirements.

1. Write [unit tests](../../Challenge_Testing){:target="_blank"}
1. Follow the [template for a well-formatted README](../../Challenge_Documentation){:target="_blank"}
1. Submit the assignment following [these instructions](../../Challenge_Submission){:target="_blank"}
