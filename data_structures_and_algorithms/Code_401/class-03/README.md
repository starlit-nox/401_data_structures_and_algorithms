# Code Challenge

Binary search in a sorted 1D array

## Specifications

- Read all of the following instructions carefully.
- Name things exactly as described.
- Do all your work in a public repository called `data-structures-and-algorithms`.
- Create a new branch in your repo called `array-binary-search`.
- Make a directory for this challenge, named according to your language's conventions, containing a README.md file.
- Update the "Table of Contents" - in the README at the root of the repository - with a link to this challenge's README file.
- **NOTE:** This challenge is **whiteboard only**
  - Write out code as part of your whiteboard process, but don't worry about creating external program files.
  - Your final whiteboard should look like [this example layout](../../Whiteboard_Workflow.md){:target="_blank"}.

## Feature Tasks

- Write a function called `BinarySearch` which takes in 2 parameters: a sorted array and the search key. Without utilizing any of the built-in methods available to your language, return the index of the array's element that is equal to the value of the search key, or -1 if the element is not in the array.
- **NOTE:** The search algorithm used in your function should be a binary search.
  - Check the Resources section for details

## Example

| Input | Output |
|-----|----|
| `[4, 8, 15, 16, 23, 42], 15` | `2` |
| `[-131, -82, 0, 27, 42, 68, 179], 42` | `4` |
| `[11, 22, 33, 44, 55, 66, 77], 90` | `-1` |
| `[1, 2, 3, 5, 6, 7], 4` | `-1` |

![Binary Search](https://blog.penjee.com/wp-content/uploads/2015/04/binary-and-linear-search-animations.gif)

## Resources

- [Wikipedia: Binary Search Algorithm](https://en.wikipedia.org/wiki/Binary_search_algorithm)

## Stretch Goal

What would you need to change if the array contained objects (sorted on a given property), and you were searching for certain property value? Write out the pseudocode.

## Documentation: Challenge README.md

```markdown
# Binary Search of Sorted Array
<!-- Description of the challenge -->

## Whiteboard Process
<!-- Embedded whiteboard image -->

## Approach & Efficiency
<!-- What approach did you take? Discuss Why. What is the Big O space/time for this approach? -->
```

## Submission Instructions

1. Capture an image of your completed whiteboard, matching the [example whiteboard layout](../../Whiteboard_Workflow.md){:target="_blank"}.
     1. Copy your image into your challenge directory in your repo.
     1. Give the image file the same name as the branch you are working on.
     1. Embed the image in your Challenge README file.
1. Create a pull request from your branch to the `main` branch. Use the description field to describe the work accomplished.
1. Submit your completed work:
    1. Copy the link to your open pull request and paste it into the assignment submission field.
    1. Leave a description of how long this assignment took you in the comments box.
    1. Add any additional comments to your grader about your process or any difficulties you may have had with the assignment.
1. Merge your branch into `main`, and delete your branch (don't worry, the PR link will still work).

## Rubrics

### Whiteboard

| Points  | Reasoning |
| :------------: | :----------- |
| 3       | Whiteboard exercise completed, recommended process followed, and code appears correct |
| 2       | Whiteboard exercise completed, and recommended process followed |
| 1       | Whiteboard exercise is not complete, or workflow does not follow recommended structure/syntax |
| 0       | Whiteboard exercise is significantly incomplete or not present |

### Readme

| Points  | Reasoning |
| :------------: | :----------- |
| 2       | Readme meets all requirements, and the top-level readme of repository properly links to challenge |
| 0       | Readme not present in repo, incorrectly linked, or does not meet the specified requirements listed in assignment |
