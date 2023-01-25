# Code Challenge

Reverse an array.

## Specifications

- Read all of the following instructions carefully.
- Name things exactly as described.
- Do all your work in a public repository called `data-structures-and-algorithms`.
- Create a new branch in your repo called `array-reverse`.
- Make a directory for this challenge, named according to your language's conventions, containing a README.md file.
- Update the "Table of Contents" - in the README at the root of the repository - with a link to this challenge's README file.
- **NOTE:** This challenge is **whiteboard only**
  - Write out code as part of your whiteboard process, but don't worry about creating external program files.
  - Your final whiteboard should look like [this example layout](../../Whiteboard_Workflow.md){:target="_blank"}.

## Feature Tasks

- Write a function called `reverseArray` which takes an array as an argument. Without utilizing any of the built-in methods available to your language, return an array with elements in reversed order.

## Example

| Input | Output |
|-----|----|
| `[1, 2, 3, 4, 5, 6]` | `[6, 5, 4, 3, 2, 1]` |
| `[89, 2354, 3546, 23, 10, -923, 823, -12]` | `[-12, 823, -923, 10, 23, 3546, 2354, 89]` |
| `[2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41, 43, 47, 53, 59, 61, 67, 71, 73, 79, 83, 89, 97, 101, 103, 107, 109, 113, 127, 131, 137, 139, 149, 151, 157, 163, 167, 173, 179, 181, 191, 193, 197, 199]` | `[199, 197, 193, 191, 181, 179, 173, 167, 163, 157, 151, 149, 139, 137, 131, 127, 113, 109, 107, 103, 101, 97, 89, 83, 79, 73, 71, 67, 61, 59, 53, 47, 43, 41, 37, 31, 29, 23, 19, 17, 13, 11, 7, 5, 3, 2]` |

## Structure and Testing

Utilize the Single-responsibility principle: any methods you write should be clean, reusable, abstract component parts to the whole challenge. You will be given feedback and marked down if you attempt to define a large, complex algorithm in one function definition.

## Stretch Goal

Once you've achieved a working solution, implement the same feature with a different methodology. (Hint: what different techniques do you have when working with arrays? Recursion, loops, indexes, modifying the array input directly...)

In other words, use a different algorithm & pseudocode to solve the same problem. Then compare approaches for efficiency, readability, flexibility, etc.

## Documentation: Challenge README.md

```markdown
# Reverse an Array
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
