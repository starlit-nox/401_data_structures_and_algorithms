# Interview 02

Convert a year to Roman Numerals.

## Specifications

- Read all of the following instructions carefully.
- Act as an interviewer, giving a candidate a code challenge.
- Score the candidate according to the [Whiteboard Rubric](https://docs.google.com/spreadsheets/d/1scthkmARfzAFZrSYAp6LA2coOaoWUWbSzMbtIU4jcHw){:target="_blank"}
- You are free to offer suggestions or guidance (and see how they respond), but don't solve the challenge for the candidate.

## Feature Tasks

- Actual code is required for a complete answer.
- Avoid utilizing any of the built-in methods available in your language.
- Ask the candidate to write a function to convert an integer to it's roman numeral equivalent.
- Input will be positive integers less than 5,000.
- Help the candidate understand the definition of a roman numeral if needed.
  - You can share this [reference chart](https://www.britannica.com/topic/Roman-numeral){:target="_blank"} if needed.
- This problem can be solved using different approaches:
  - The candidate might want to build up the new string by repeatedly adding the highest possible roman strings (while reducing the target number the same value), then moving a current index to the next highest value.
    - The index might point into 2 parallel 1-dimensional arrays, carefully built to correlate the roman letters to the numeric value, from highest to lowest.
    - `dec = [ 1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1 ]`
    - `rom = [ 'M', 'CM', 'D', 'CD', 'C', 'XC', 'L', 'XL', 'X', 'IX', 'V', 'IV', 'I' ]`
    - Alternatively, the string and value equivalent might be stored in an object, a tuple, or a hash.
    - The candidate can then loop: concatenating the string, and reducing the target, while the target is more than the value of the current index.
    - If you consider n the value of the target number, this method takes O(1) time and uses O(1) extra space, since it has to loop through the possible values for any given number.

## Structure

Familiarize yourself with the grading rubric, so you know how to score the interview.

Look for effective problem solving, efficient use of time, and effective communication with the whiteboard space available.

Every solution might look a little different, but the candidate should be able to test their solution with different inputs to verify correctness.

Assign points for each item on the Rubric, according to how well the candidate executed on that skill.

Add up all the points at the end, and record the total at the bottom of the page.

## Example

| Input | Output |
|-----|----|
| `"1900"` | `"MCM"` |
| `"634"` | `"DCXXXIV"` |
| `"2020"` | `"MMXX"` |
| `"2099"` | `"MMXCIX"` |

## Documentation

Record detailed notes on the rubric, to share with the candidate when the interview is complete.

## Solution

<details>
  <summary>Algorithm</summary>
  Iterate through our integer string, and for each digit in our integer our function will convert the value to a roman numeral value.  We can create a list or map of basic roman numeral values that will quickly return a Roman numeral for a given digit.  In order to convert more complex values our method should be able to find the largest value from the map that with a positive difference to our digit integer. The remaining difference, our function can recursively find the corresponding numeral in the map and append it to the numeral string for a given digit in the input integer. Continue until all digits are read and all string values are appended to Roman numeral.
</details>
<details>
  <summary>Pseudocode</summary>
  <pre><code>algorithm INTEGER_TO_NUMERAL:
  declare number INTEGER <- input value
  declare hashmap NUMERALS <- keys are integers, values are corresponding Roman Numerals
  declare string ROMAN <- empty string to append Roman Numeral Strings
  for each DIGIT of INTEGER:
    build roman numeral VALUE from the NUMERALS map for the given DIGIT
    append VALUE to ROMAN string
  return ROMAN</code></pre>
</details>
<details>
  <summary>Big O</summary>
  This solution has a linear O(n) time complexity since the large the integer input, the more we have to run code to convert integer values into roman numeral strings. Space complexity is constant O(1), since we create a map at the beginning that does not grow with input size.
</details>
