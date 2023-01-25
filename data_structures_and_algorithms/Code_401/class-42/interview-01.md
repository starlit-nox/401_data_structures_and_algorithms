# Interview 01

Reverse a string, three different ways.

## Specifications

- Read all of the following instructions carefully.
- Act as an interviewer, giving a candidate a code challenge.
- Score the candidate according to the [Whiteboard Rubric](https://docs.google.com/spreadsheets/d/1scthkmARfzAFZrSYAp6LA2coOaoWUWbSzMbtIU4jcHw){:target="_blank"}
- You are free to offer suggestions or guidance (and see how they respond), but don't solve the challenge for the candidate.

## Feature Tasks

- Actual code is required for a complete answer.
- Ask the candidate to write 3 functions, that each utilize a different algorithms for reversing a string.
- One of the 3 methods may utilize any of the built-in methods, except for `String#reverse`, available in your language. The other 2 may not.
- This problem can be approached in many ways....
  - Popular techniques involve converting the string to an array of characters, reversing the array, and then converting back to a string.
  - Encourage the candidate to try at least one recursive solution, with no loops (`for` / `while`).
    - A base case should be clearly identified.
    - The recursive call might look like concatenating the last character of the string, with `reverse` of the whole string (without the last char).
      - `rev = str[lastChar] + strWithoutLastChar`
  - Ensure the candidate evaluates Big O for every algorithm. Be extra thoughtful of what any built-in methods are doing under the hood!

## Structure

Familiarize yourself with the grading rubric, so you know how to score the interview.

Look for effective problem solving, efficient use of time, and effective communication with the whiteboard space available.

Every solution might look a little different, but the candidate should be able to test their solution with different inputs to verify correctness.

Assign points for each item on the Rubric, according to how well the candidate executed on that skill.

Add up all the points at the end, and record the total at the bottom of the page.

## Example

| Input | Output |
|-----|----|
| `"Code Fellows"` | `"swolleF edoC"` |
| `"Tacocat"` | `"tacocaT"` |
| `"A ship in port is safe, but that's not what ships are built for."` | `".rof tliub era spihs tahw ton s'taht tub ,efas si trop ni pihs A"` |

## Documentation

Record detailed notes on the rubric, to share with the candidate when the interview is complete.

## Solution

<details>
  <summary>Algorithm</summary>
  First method:  Use iteration. Declare a number starting at the length of the input string minus 1.  decrement the iterator and add the value from the input string to a new string.  Return the new string once the iterator reaches 0 and adds all values to the new string.
  Second method:  We can use recursion to perform something similar, by passing in our input string, and an index to read from the index, we can build a string by calling our recursive function on our string until the index value is less than or equal to 0.
  Third method: The last way will use iteration to add the characters of our string to another string, just in reverse order.  By looping over all the characters in the input string, we should be able concatenate to a new string at the front of the string rather than the end, giving us a new string with all characters in reverse.
</details>
<details>
  <summary>Pseudocode</summary>
  <pre><code>algorithm REVERSE_WITH_ITERATION:
  declare string STRING <- input string
  declare number I <- set to STRING length - 1
  declare string REVERSED <- new STRING with no characters
    while I is less than or equal to 0:
      add the character at STRING at I to REVERSED
      decrement I by 1;
  return REVERSED</code></pre>
  <pre></code>algorithm REVERSE_WITH_RECURSION:
  declare string STRING <- input string
  declare number I <- input number
  declare string REVERSED <- input string (start as empty)
  if I is less than or equal to 0:
    add the STRING character at index I
    return REVERSE_WITH_RECURSION passing in STRING, I minus 1, our new STRING
  else return REVERSED string</code></pre>
  <pre><code>algorithm REVERSE_ORDER:
  declare string STRING <- input string
  declare string REVERSED <- new empty string
  for every CHARACTER in STRING
    set REVERSED equal to CHARACTER concatenated with characters in REVERSED
  return REVERSED</code></pre>
</details>
<details>
  <summary>Big O</summary>
  All three of these methods have 0(n) time complexity and 0(n) time complexity.  They all need to read all characters within the input array, and they all build a completely new string using the characters from the input.
</details>
