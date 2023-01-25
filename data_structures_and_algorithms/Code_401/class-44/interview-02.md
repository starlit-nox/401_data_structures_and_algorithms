# Interview 02

Find largest product possible of 3 integers from within a list.

## Specifications

- Read all of the following instructions carefully.
- Act as an interviewer, giving a candidate a code challenge.
- Score the candidate according to the [Whiteboard Rubric](https://docs.google.com/spreadsheets/d/1scthkmARfzAFZrSYAp6LA2coOaoWUWbSzMbtIU4jcHw){:target="_blank"}
- You are free to offer suggestions or guidance (and see how they respond), but don't solve the challenge for the candidate.

## Feature Tasks

- Actual code is required for a complete answer
- Avoid utilizing any of the built-in methods available in your language.
- Ask the candidate to write a function to identify the largest possible result of multiplying together some 3 numbers from an array of integers.
- A tricky edge case is related to how negative numbers are handled.
  - You don't need to mention this at the start. If the candidate asks about negative numbers, you can confirm: "It's an array of integers", so negative numbers would be a possibility.
  - Remember, if only 1 negative number is multiplied with 2 positive numbers, the resulting product will be negative. But 2 negative numbers multiplied with one positive number will result in a positive number.
- Possible approaches:
  - Sort the list, and multiple the last 3 numbers together.
    - This does not account for a list of eg, all negative numbers. But they are there at the start of the list. What should be done with them?
    - Time and space complexity of this depend on what sorting algorithm the candidate might use. Be sure the candidate can correctly select a proper sorting algorithm, and can tell you the correct complexities.
  - Traverse the list, keeping track of the 3 largest numbers identified.
    - This would be similar to an algorithm to find the max value in a list.
    - The 3 values might be held in a queue of size 3: when a new high is found, it's enqueued, and the oldest value is dequeued.
    - To account for negative numbers, the candidate would also need to accumulate the 2 lowest, negative numbers, as the array is traversed. Perhaps in a second queue?
    - Since this can be done in a single pass through the array, time complexity is O(n). It only needs to store up to 3 values in the supporting list of min / max numbers, so extra space complexity is O(1).

## Structure

Familiarize yourself with the grading rubric, so you know how to score the interview.

Look for effective problem solving, efficient use of time, and effective communication with the whiteboard space available.

Every solution might look a little different, but the candidate should be able to test their solution with different inputs to verify correctness.

Assign points for each item on the Rubric, according to how well the candidate executed on that skill.

Add up all the points at the end, and record the total at the bottom of the page.

## Example

| Input| Output |
|-----|----|
| `[18, 3, 42, 17, 9, 27]` | `20,412` |
| `[4, 0, -5, 3, -1, -6, 2]` | `120` |

## Documentation

Record detailed notes on the rubric, to share with the candidate when the interview is complete.

## Solution

<details>
  <summary>Algorithm</summary>
  Start by sorting all values from smallest to largest using the absolute value of each integer. If all values are positive, we just need to multiply the last three values together and return the value.  If there are negative numbers, we need to check how many negative numbers are present, if there are only a couple of large absolute negative values, we let them cancel each out, but if there is 1 or more than three we need to replace them the next largest values from our list of numbers.
</details>
<details>
  <summary>Pseudocode</summary>
  <pre><code>algorithm LARGEST_PRODUCT:
  declare list NUMBERS <- input list
  sort all values in NUMBERS from smallest to largest absolute values
  declare list LARGEST <- set to largest three numbers from NUMBERS
  if there are negative values in LARGEST:
    check how many negative values are present,
    if there are 2 negative values:
      return the product of all numbers in LARGEST
    else:
      replace negative values in LARGEST with next largest positive values
      return product of all values in LARGEST, now with replacements</code></pre>
</details>
<details>
  <summary>Big O</summary>
  Depending on our sort method, our time complexity is either O(n<sup>2</sup>)  or O(n log n) for time.  The other operations are only O(n) time since we just iterating through the values returned from our sort.  For space complexity, this again depends on our sorting method,  if we sort in place we may have an 0(1) constant complexity since we wouldn't need to store any extra space for our sorted values.  If we create a new list, this would increase our complexity to O(n).
</details>
