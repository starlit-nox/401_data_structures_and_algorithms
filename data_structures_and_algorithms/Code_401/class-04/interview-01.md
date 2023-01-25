# Interview 01

Given a matrix, find the sum of each row.

## Specifications

- Read all of the following instructions carefully.
- Act as an interviewer, giving a candidate a code challenge.
- Score the candidate according to the [Whiteboard Rubric](https://docs.google.com/spreadsheets/d/1scthkmARfzAFZrSYAp6LA2coOaoWUWbSzMbtIU4jcHw){:target="_blank"}.
- You are free to offer suggestions or guidance (and see how they respond), but don't solve the challenge for the candidate.

## Feature Tasks

- Ask the candidate to write a function to add up the sum of each row in a matrix of arbitrary size, and return an array with the appropriate values.
- Avoid utilizing any of the built-in methods available to your language.
- Don't let the candidate get scared by the term "matrix"... It's just an array of arrays.
- The matrix will always be full of integers.
- Negative values are possible.
- All nulls will be counted as zeros.

## Structure

Familiarize yourself with the grading rubric, so you know how to score the interview.

Look for effective problem solving, efficient use of time, and effective communication with the whiteboard space available.

Every solution might look a little different, but the candidate should be able to at least convince you that their code works to solve the problem.

Assign points for each item on the Rubric, according to how well the candidate executed on that skill.

Add up all the points at the end, and record the total at the bottom of the page.

## Example

| Input | Output |
|-----|----|
| `[ [1, 2, 3], [3, 5, 7], [1, 7, 10] ]` | `[6, 15, 18]` |
| `[ [0, 1, 5], [-4, 7, 2], [-3, 12, 11] ]` | `[6, 5, 20]` |

The candidate should draw the input and output as a square of integers.

## Documentation

Record detailed notes on the rubric, to share with the candidate when the interview is complete.

## Solution

<details>
  <summary>Algorithm</summary>
  Since we need to read every value in a given matrix, we can use a nested loop to sum all values within each "row" from the matrix.  For every "row" we receive from our input we need to track a "sum" for that specific "row". To accomplish this, we just need to read each value found within each "row" and add that value to a "sum".  The sum of each row can be appended to an array.  Each index of the array will hold the "Sum" of values found in a given row in the matrix.
</details>
<details>
  <summary>PseudoCode</summary>
  <pre><code>algorithm SUM_ROWS:
  declare input MATRIX
  declare array TOTALS <- empty Array
  for every ROW in MATRIX:
    declare number SUM
    for every VALUE in ROW:
      add VALUE to SUM
    append VALUE to TOTALS
  return TOTALS</code></pre>
</details>
<details>
  <summary>Big O</summary>
  This solution has 0(n) complexity for space and time.  The loop reads every value in the input only once, and it appends values to an iterable structure that will grow about the same rate (linear) as the input size.  The more rows in the matrix will affect the output size.  The number of values in each row won't have an effect, so the output may grow at some fraction of (n) but we will round that to (n).
</details>

