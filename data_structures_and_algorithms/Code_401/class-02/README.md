# Code Challenge

Insert and shift an array in middle at index

## Specifications

- Read all of the following instructions carefully.
- Name things exactly as described.
- Do all your work in a public repository called `data-structures-and-algorithms`.
- Create a new branch in your repo called `array-insert-shift`.
- Make a directory for this challenge, named according to your language's conventions, containing a README.md file.
- Update the "Table of Contents" - in the README at the root of the repository - with a link to this challenge's README file.
- **NOTE:** This challenge is **whiteboard only**
  - Write out code as part of your whiteboard process, but don't worry about creating external program files.
  - Your final whiteboard should look like [this example layout](../../Whiteboard_Workflow.md){:target="_blank"}.

## Feature Tasks

- Write a function called `insertShiftArray` which takes in an array and a value to be added. Without utilizing any of the built-in methods available to your language, return an array with the new value added at the middle index.

## Example

| Input | Output |
|-----|----|
| `[2,4,6,-8], 5` | `[2,4,5,6,-8]` |
| `[42,8,15,23,42], 16` | `[42,8,15,16,23,42]` |

## Stretch Goal

Write a second function that removes an element from the middle index and shifts other elements in the array to fill the new gap.

## Documentation: Challenge README.md

```markdown
# Insert to Middle of an Array
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
