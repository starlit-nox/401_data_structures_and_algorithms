# Implementation: Singly Linked Lists

## Specifications

- Read all of these instructions carefully.
- Name things exactly as described.
- Do all your work in a your `data-structures-and-algorithms` public repository.
- Create a new branch in your repo named as noted below.
- Follow the language-specific instructions for the challenge type listed below.
- Update the "Table of Contents" - in the README at the root of the repository - with a link to this challenge's README file.

### Challenge Setup & Execution

**Branch Name:** `linked-list`

**Challenge Type:** New Implementation

## Features

### Node

- Create a Node class that has properties for the value stored in the Node, and a pointer to the next Node.

### Linked List

- Create a Linked List class
- Within your Linked List class, include a head property.
  - Upon instantiation, an empty Linked List should be created.
- The class should contain the following methods
  - insert
    - Arguments: value
    - Returns: nothing
    - Adds a new node with that value to the `head` of the list with an O(1) Time performance.
  - includes
    - Arguments: value
    - Returns: Boolean
      - Indicates whether that value exists as a Node's value somewhere within the list.
  - to string
    - Arguments: none
    - Returns: a string representing all the values in the Linked List, formatted as:
    - `"{ a } -> { b } -> { c } -> NULL"`

## Structure and Testing

Utilize the Single-responsibility principle: any methods you write should be clean, reusable, abstract component parts to the whole challenge. You will be given feedback and marked down if you attempt to define a large, complex algorithm in one function definition.

Be sure to follow your language/frameworks standard naming conventions (e.g. _C#_ uses PascalCasing for all method and class names).

Any exceptions or errors that come from your code should be contextual, descriptive, capture-able errors. For example, rather than a default error thrown by your language, your code should raise/throw a custom error that describes what went wrong in calling the methods you wrote for this lab.


Write tests to prove the following functionality:

1. Can successfully instantiate an empty linked list
1. Can properly insert into the linked list
1. The head property will properly point to the first node in the linked list
1. Can properly insert multiple nodes into the linked list
1. Will return true when finding a value within the linked list that exists
1. Will return false when searching for a value in the linked list that does not exist
1. Can properly return a collection of all the values that exist in the linked list

Ensure your tests are passing before you submit your solution.

## Stretch Goal

Create a new branch called `doubly-linked-list`, and, using the resources available to you online, implement a doubly linked list (completely separate from your singly linked list).

## Documentation: Your README.md

```markdown
# Singly Linked List
<!-- Short summary or background information -->

## Challenge
<!-- Description of the challenge -->

## Approach & Efficiency
<!-- What approach did you take? Why? What is the Big O space/time for this approach? -->

## API
<!-- Description of each method publicly available to your Linked List -->
```

## Submission Instructions

1. Create a pull request from your branch to your `main` branch
1. In your open pull request, leave as a comment [a checklist](https://github.com/blog/1825-task-lists-in-all-markdown-documents){:target="_blank"} of the specifications and tasks above, with the actual steps that you completed checked off
1. Submitting your completed work:
   1. Copy the link to your open pull request and paste it into the corresponding assignment
   1. Leave a description of how long this assignment took you in the comments box
   1. Add any additional comments you like about your process or any difficulties you may have had with the assignment
1. Merge your branch into `main`, and delete your branch (don't worry, the PR link will still work)
