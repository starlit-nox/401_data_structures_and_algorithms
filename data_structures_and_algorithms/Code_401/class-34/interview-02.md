# Interview 02

Determine if a string is full of unique characters.

## Specifications

- Read all of the following instructions carefully.
- Act as an interviewer, giving a candidate a code challenge.
- Score the candidate according to the [Whiteboard Rubric](https://docs.google.com/spreadsheets/d/1scthkmARfzAFZrSYAp6LA2coOaoWUWbSzMbtIU4jcHw){:target="_blank"}
- You are free to offer suggestions or guidance (and see how they respond), but don't solve it for the candidate.

## Feature Tasks

- Ask the candidate to write a function that will determine if the given string is full of unique characters.
- We can assume that spaces don't count, and the characters are not case sensitive (i.e. "A" is the same as "a").
- The most efficient solution is going to use a Hashmap. The candidate should iterate through the string.
and for each of the characters put them in the Hashset, if the value already exists, they can return false as soon as a duplicate occurs.
- We can assume they have a Hashset readily available (they do not have to implement one).
- This solution is of an O(n) time and O(n) space.

### Stretch Goal

If they solve this question too quickly, increase the difficulty by saying that the sentence is case sensitive.
(i.e. "A" and "a" are not the same. )

## Structure

Familiarize yourself with the grading rubric, so you know how to score the interview.

Look for effective problem solving, efficient use of time, and effective communication with the whiteboard space available.

Every solution might look a little different, but the candidate should be able to test their solution with different inputs to verify correctness.

Assign points for each item on the Rubric, according to how well the candidate executed on that skill.

Add up all the points at the end, and record the total at the bottom of the page.

## Example

| Input | Output |
|-----|----|
| `The quick brown fox jumps over the lazy dog` | `FALSE` |
| `I love cats` | `TRUE` |
| `Donald the duck` | `FALSE` |

## Documentation

Record detailed notes on the rubric, to share with the candidate when the interview is complete.

## Solution

<details>
  <summary>Algorithm</summary>
  Parse the input string and read each value, add each character to our Hashset as we iterate.  For each character in the string, check if Hashset includes the character.  If Hashset includes character, return false.  If Hashset does not include character, add it and continue on to next character in the input string.  If we reach the end of our input string, and find no matches in our Hashset, return true.
</details>
<details>
  <summary>Pseudocode</summary>
  <pre><code>algorithm HAS_UNIQUE_CHARACTERS
  declare string STRING <- input string
  declare Hashset UNIQUE <- new Hashset for storing unique characters
  for each CHARACTER in STRING:
    if CHARACTER is included in UNIQUE:
      return false
    else
      add CHARACTER to UNIQUE
  return true</code></pre>
</details>
<details>
  <summary>Big O</summary>
  Since we need to read all values present in the input string, this method requires a time complexity of 0(n).  And since we are storing all characters in a Hashset, at worst case we would store all characters in another structure, so our space complexity would also reach 0(n).
  
</details>
