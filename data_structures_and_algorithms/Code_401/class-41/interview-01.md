# Interview 01

Design a system to track browser navigation history.

## Specifications

- Read all of the following instructions carefully.
- Act as an interviewer, giving a candidate a code challenge.
- Score the candidate according to the [Whiteboard Rubric](https://docs.google.com/spreadsheets/d/1scthkmARfzAFZrSYAp6LA2coOaoWUWbSzMbtIU4jcHw){:target="_blank"}
- You are free to offer suggestions or guidance (and see how they respond), but don't solve the challenge for the candidate.

## Feature Tasks

- Create a `Navigator` class responsible for tracking history of locations as well as allowing `back` and `forward` movement.
- `Navigator` class should have `back`, `forward` and `go` methods.
  - `back` method takes no arguments and returns the previous location or NULL if there is none.
  - `forward` method takes no arguments and returns the next location or NULL if there is none.
  - `go` method should take a string argument representing the desired location.
- The functionality should mimic a web browsers navigation history.
- This problem can be approached in several ways:
  - The Navigator class should be created with good OOP design.
  - Navigating to a new location should replace anything that was "forward" of the current point.
  - Some kind of data structure should be used for keeping track of the history.
  - Since moving forward and backwards is always linear, consider the tradeoffs of using a doubly-linked list, or 2 stacks, or an array with careful index management.
- The candidate should consider time and space.
- Each API operation should happen independent of the size of the history object: O(1).
- Since potentially every page visited could be stored, worst case is likely O(n) space.
- Some interesting edge cases may arise. Handle them as stretch goals.

## Structure

Familiarize yourself with the grading rubric, so you know how to score the interview.

Look for effective problem solving, efficient use of time, and effective communication with the whiteboard space available.

Every solution might look a little different, but the candidate should be able to test their solution with different inputs to verify correctness.

Assign points for each item on the Rubric, according to how well the candidate executed on that skill.

Add up all the points at the end, and record the total at the bottom of the page.

## Example

You are welcome to make up your own examples, or modify these as needed.

| Input | Output |
|-----|----|
| `link(1), link(2), link(3), back()` | `2` |
| `link(1), link(2), back(), link(3), back()` | `1, 1` |
| `link(1), link(2), link(3), link(4), back(), forward(), link(5), back()` | `3, 4, 4` |

## Documentation

Record detailed notes on the rubric, to share with the candidate when the interview is complete.

## Solution

<details>
  <summary>Algorithm</summary>
  Create a navigator class that implements a stack for past URL strings, a string for our current URL, and stack for URL strings that we've visited before going "back".  We'll need 3 methods:  "back", "Forward", and "go".  The "back" method should take the current URL and push it onto the other stack, and pop the last URL off of the History Stack and make that our new "Current".  The "go" method should take in a new URL and set that to "Current", and push the previous "Current" onto the "History" Stack.  Since this is perhaps that start of a new "History" we will want to clear out the stack used for going "Forwards".
</details>
<details>
  <summary>Pseudocode</summary>
  <pre><code>class NAVIGATOR:
  declare stack of strings HISTORY <- new empty stack
  declare string CURRENT <- new empty string
  declare stack FUTURE <- new empty stack
  method BACK:
    push CURRENT URL onto FUTURE stack
    remove top URL from HISTORY and set to CURRENT
  method FORWARD:
    push CURRENT URL onto HISTORY stack
    pop the last URL from FUTURE and set to CURRENT
  method GO
    declare string URL <- input string
    empty the FORWARD stack
    if CURRENT exists, push onto HISTORY
    set CURRENT to URL</code></pre>
</details>
<details>
  <summary>Big O</summary>
  Everything implemented here should be 0(1) for both space and time.  Since we are only implementing Stacks, which have an 0(1) time and space complexity for their push and pop methods,  we'll get the same time and space complexities as we add and remove urls from our two internal stacks for going forwards and backwards.
</details>
