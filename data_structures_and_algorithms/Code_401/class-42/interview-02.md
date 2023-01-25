# Interview 02

Sanitize spaces in a URL.

## Specifications

- Read all of the following instructions carefully.
- Act as an interviewer, giving a candidate a code challenge.
- Score the candidate according to the [Whiteboard Rubric](https://docs.google.com/spreadsheets/d/1scthkmARfzAFZrSYAp6LA2coOaoWUWbSzMbtIU4jcHw){:target="_blank"}
- You are free to offer suggestions or guidance (and see how they respond), but don't solve the challenge for the candidate.

## Feature Tasks

- Actual code is required for a complete answer.
- Ask the candidate to write a function to sanitize a url, by encoding all spaces (an illegal character) into `%20`, the hexidecimal value for a space, in the ISO-Latin character set.
- Avoid utilizing any built-in string-replace methods available in your language.
- This problem can be solved using different approaches:
  - Whatever the candidate comes up with, have them analyze the Big O, time and space.

## Structure

Familiarize yourself with the grading rubric, so you know how to score the interview.

Look for effective problem solving, efficient use of time, and effective communication with the whiteboard space available.

Every solution might look a little different, but the candidate should be able to test their solution with different inputs to verify correctness.

Assign points for each item on the Rubric, according to how well the candidate executed on that skill.

Add up all the points at the end, and record the total at the bottom of the page.

## Example

| Input | Output |
|-----|----|
| `"http://code.org/hour of code.html"` | `"http://code.org/hour%20of%20code.html"` |

## Documentation

Record detailed notes on the rubric, to share with the candidate when the interview is complete.

## Solution

<details>
  <summary>Algorithm</summary>
  Iterate through our input string, to read every individual character within the string. We'll instantiate an empty string for our return value, and compare each character to see if it contains a space character.  If a space character is found, we'll add our replacement hexadecimal value to our return string, if not we will add the character read from the input, returning our new string once we've read all string values.
</details>
<details>
  <summary>Pseudocode</summary>
  <pre><code>algorithm SANITIZE:
  declare string STRING <- input string
  declare string SANITIZED <- new empty string
  for every CHARACTER in STRING:
    if CHARACTER is a space character
      add hexadecimal string value to SANITIZED
    else add CHARACTER to SANITIZED
  return SANITIZED value</code></pre>
</details>
<details>
  <summary>Big O</summary>
  This solution has a time complexity of 0(n) and a space complexity of 0(n).  Our code needs to check every character in the input string, so the run time has linear growth with our input size.  Same with our return value, since we are adding all characters to our sanitized string, our space complexity will also grow as our input grows.
</details>
