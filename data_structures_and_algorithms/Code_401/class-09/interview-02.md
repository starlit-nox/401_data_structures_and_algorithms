# Interview 02

Validate whether or not a Linked List is palindrome.

## Specifications

- Read all of the following instructions carefully.
- Act as an interviewer, giving a candidate a code challenge.
- Score the candidate according to the [Whiteboard Rubric](https://docs.google.com/spreadsheets/d/1scthkmARfzAFZrSYAp6LA2coOaoWUWbSzMbtIU4jcHw){:target="_blank"}.
- You are free to offer suggestions or guidance (and see how they respond), but don't solve the challenge for the candidate.

## Feature Tasks

- Ask the candidate to write a function to validate whether or not a Linked list is palindrome
- Help the candidate understand the definition of a Palindrome if he/she is unsure of it.
  - A palindrome is a word, phrase, number, or sequence of nodes which reads the same backward as forward.
- Avoid utilizing any of the built-in methods available in your language.
- This problem can be solved using different approaches:
  - Using a helper data structure (Array or Linked List) to keep track of the nodes.
    - This method takes O(n) and uses O(n) extra space.
  - Reversing the Linked List, and checking for equality of the reversed part.

## Structure

Familiarize yourself with the grading rubric, so you know how to score the interview.

Look for effective problem solving, efficient use of time, and effective communication with the whiteboard space available.

Every solution might look a little different, but the candidate should be able to test their solution with different inputs to verify correctness.

Assign points for each item on the Rubric, according to how well the candidate executed on that skill.

Add up all the points at the end, and record the total at the bottom of the page.

## Example

| Input | Output |
|-----|----|
| `head->{t}->{a}->{c}->{o}->{c}->{a}->{t}` | `TRUE` |
| `head->{m}->{o}->{o}->{m}` | `TRUE` |
| `head->{h}->{o}->{u}->{s}->{e}` | `FALSE` |

## Documentation

Record detailed notes on the rubric, to share with the candidate when the interview is complete.

## Solution

<details>
  <summary>Algorithm</summary>
  Traverse the list and read all the values from the list.  Store each value from the list in a stack.  Once all values are stored,  re-traverse the list and compare each value with values popped from the top of the stack.  If all values taken off the stack match the traversal values,  return true.  If any value doesn't match the value read from the stack, return false.
</details>
<details>
  <summary>PseudoCode</summary>
<pre><code>algorithm IS_PALINDROME:
  declare Linked List LL <- input
  declare node CURRENT <- head node of LL
  declare stack STACK <- empty Stack
  while CURRENT is not null:
    push CURRENT value onto STACK
    set CURRENT to CURRENT.next
  reset CURRENT to the head of LL
  while STACK is not empty:
    pop the top value off of STACK
    compare value with CURRENT value
      if values don't match return false
    set CURRENT to CURRENT.next
  return true</code></pre>
</details>
<details>
  <summary>Big O</summary>
  This solution has 0(n) complexity for both space and time.  Since we have to read every value in the input list and re-traverse, we are going to run our code 0(2n) times, which we round down to (n).  We also store each value in a Stack, which means the amount of space we take up is relative to the size of the input.
</details>
