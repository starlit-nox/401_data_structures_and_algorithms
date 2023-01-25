# Interview 01

Rotate a matrix.

## Specifications

- Read all of the following instructions carefully.
- Act as an interviewer, giving a candidate a code challenge.
- Score the candidate according to the [Whiteboard Rubric](https://docs.google.com/spreadsheets/d/1scthkmARfzAFZrSYAp6LA2coOaoWUWbSzMbtIU4jcHw){:target="_blank"}
- You are free to offer suggestions or guidance (and see how they respond), but don't solve the challenge for the candidate.

## Feature Tasks

- Ask the candidate to write a function to rotate a 3x3 matrix (an array of integers), by 90 degrees clockwise.
- Avoid utilizing any of the built-in methods available to your language.
- Don't let the candidate get scared by the term "matrix"... It's just an array of arrays.
  - Input matrices must be a square (2 x 2) / (3 x 3) / (4 x 4) etc...
  - Input may include the length of the matrix as well as the matrix of nested values.

## Structure

Familiarize yourself with the grading rubric, so you know how to score the interview.

Look for effective problem solving, efficient use of time, and effective communication with the whiteboard space available.

Every solution might look a little different, but the candidate should be able to at least convince you that their code works to solve the problem.

Assign points for each item on the Rubric, according to how well the candidate executed on that skill.

Add up all the points at the end, and record the total at the bottom of the page.

## Example

| Input | Output |
|-----|----|
| `[ [1, 1, 1], [2, 2, 2], [3, 3, 3] ]` | `[ [3, 2, 1], [3, 2, 1], [3, 2, 1] ]` |
| `[ [3, 2, 1], [3, 2, 1], [3, 2, 1] ]` | `[ [3, 3, 3], [2, 2, 2], [1, 1, 1] ]` |

The candidate should draw the input and output as a square of integers.

## Documentation

Record detailed notes on the rubric, to share with the candidate when the interview is complete.

## Solution

<details>
  <summary>Algorithm</summary>
  Move array indices around a 2 dimensional structure in place.  Begin by creating a nested loop to read all values in the nested arrays.  Store the current nested array value and move each of the values stored at each "row" to their appropriate position in the rotated matrix.  The first value, should be move to the top left, the second should be moved to the middle left, and top left should be moved to the bottom left.  continue to update index values so that all values on the TOP, BOTTOM, LEFT, and RIGHT all in correct index positions for a 90 degree rotation. All top rows should be moved to the left side of the matrix, all left values are moved to the bottom, and all right values are moved to the top.
</details>
<details>
  <summary>Pseudocode</summary>
  <pre><code>algorithm ROTATE_MATRIX:
  declare array MATRIX <- input array, nested array of integers
  for each index X in MATRIX:
    for each index Y in X row of the matrix:
      move a top value to right side of matrix
      move a left value to top side of matrix
      move a right value to bottom of matrix</code></pre>
</details>
<details>
  <summary>Big O</summary>
  This solution will have an 0(n) time complexity.  As we add more "rows" to our "square" matrix we will have to run more lines of code to ensure that values are places in the correct positions.  This solution also has 0(1) space complexity.  Since the matrix is moved in place, we don't create any extra space to store values giving us constant storage space used to manage values.
</details>
