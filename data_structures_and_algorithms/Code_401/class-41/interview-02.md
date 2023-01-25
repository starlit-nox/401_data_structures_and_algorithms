# Interview 02

Identify anagrams.

## Specifications

- Read all of the following instructions carefully.
- Act as an interviewer, giving a candidate a code challenge.
- Score the candidate according to the [Whiteboard Rubric](https://docs.google.com/spreadsheets/d/1scthkmARfzAFZrSYAp6LA2coOaoWUWbSzMbtIU4jcHw){:target="_blank"}
- You are free to offer suggestions or guidance (and see how they respond), but don't solve the challenge for the candidate.

## Feature Tasks

- Actual code is required for a complete answer.
- Ask the candidate to write a function to validate whether or not two given strings are anagrams (contain the same letters).
- Disregard spaces.
- Help the candidate understand the definition of a anagram if they are unsure of it.
  - Two strings are anagrams if one can be built from exactly the same letters as the other.
- Avoid utilizing any of the built-in methods available in your language.
- This problem can be solved using different approaches:
  - Look at each letter in the first string, and determine if it's in the second string (removing it, if found).
    - This is an `O(n^2)` brute-force solution.
  - Sort the characters in each string, and then see if they are equal.
    - Best sorts are `O(n log n)`, so this won't be better than that.
  - Use a hash to count the occurrences of each character in the first string, and ensure the second string matches.
    - This requires a single pass through both strings, so at worst is `O(n)`.

## Structure

Familiarize yourself with the grading rubric, so you know how to score the interview.

Look for effective problem solving, efficient use of time, and effective communication with the whiteboard space available.

Every solution might look a little different, but the candidate should be able to test their solution with different inputs to verify correctness.

Assign points for each item on the Rubric, according to how well the candidate executed on that skill.

Add up all the points at the end, and record the total at the bottom of the page.

## Example

| Input | Output |
|-----|----|
| `"Eleven plus two", "Twelve plus one"` | `TRUE` |
| `"Clint Eastwood", "Old West Action"` | `TRUE` |
| `"Software", "Swear often"` | `FALSE` |
| `"Astronomers", "Moon starers"` | `TRUE` |

## Documentation

Record detailed notes on the rubric, to share with the candidate when the interview is complete.

## Solution

<details>
  <summary>Algorithm</summary>
  First, check to make sure that both strings are the same length.  Also remove spaces and normalize inputs when possible.  Create a hash table / set to store all occurrences of characters found in the first string.  Iterate through the string and create a key for each character.  Iterate through the second string and check if we generated a hash for every character in the second input string.  If we find a character that isn't in our hashing structure, our function returns false.  If we make it all the way through our second string confirming every character we can return true.
</details>
<details>
  <summary>Pseudocode</summary>
  <pre><code>algorithm IS_ANAGRAM:
  declare string STRING_1 <- first input string
  declare string STRING_2 <- second input string
  declare hashset CHARS <- new hashset for storing string characters
  if STRING_1 and STRING_2 do not have the same length, return false
  for every CHARACTER in STRING_1:
    add CHARACTER to CHARS
  for every CHARACTER in STRING_2:
    check if CHARS has CHARACTER:
      if so continue
      if not return false
  return true if we finish reading characters in STRING_2</code></pre>
  </details>
<details>
  <summary>Big O</summary>
  This particular solution has a time complexity and space complexity of 0(n).  It needs to read all characters in the first string, and at worst all characters in the second string.  Since we are also storing all characters from the first string in a hashset or hashtable, our function at worst requires storage space of 0(n) as well.
</details>
