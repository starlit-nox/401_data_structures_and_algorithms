# Interview 02

Duck Duck Goose

People are standing in a circle playing Duck Duck Goose. Counting begins at a specified point in the circle and proceeds around the circle in a specified direction. After a specified number of people are skipped, the next person is removed. The procedure is repeated with the remaining people, starting with the next person, going in the same direction and skipping the same number of people, until only one person remains, and wins the game.

Write a function called `DuckDuckGoose()` that accepts an array of strings and an int `k`. Start at the beginning and count up to `k` and remove the person at that position. Keep counting from that index and count up to `k` over and over until only one person is left. Return a string with the name of the last person left.

```plaintext
k=3
A, B, C, D, E  // 1: A; 2: B; 3: C
A, B, D, E     // C was removed
B, D, E        // A was removed
B, D           // E was removed
D              // B was removed
               // only D is left
```

## Specifications

- Read all of the following instructions carefully.
- Act as an interviewer, giving a candidate a code challenge.
- Score the candidate according to the [Whiteboard Rubric](https://docs.google.com/spreadsheets/d/1scthkmARfzAFZrSYAp6LA2coOaoWUWbSzMbtIU4jcHw){:target="_blank"}.
- You are free to offer suggestions or guidance (and see how they respond), but don't solve the challenge for the candidate.

## Feature Tasks

- Ask the candidate to write a function to execute the game described above, using only a Queue.
- Help the candidate understand the rules of the game if they are unsure of it.
  - Feel free to share the example above to show an example.
- Avoid utilizing any of the built-in methods available in your language.
- This problem can be solved using a queue:
  - One solution is to enqueue and dequeue `k` number of times. Once k is hit, skip the enqueue process for that entry, removing it from the queue. Repeat until there is only 1 node in the queue remaining.
    - This method takes `O(n * k)` time and uses `O(n)` (linear) space during this process.

## Structure

Familiarize yourself with the grading rubric, so you know how to score the interview.

Look for effective problem solving, efficient use of time, and effective communication with the whiteboard space available.

Every solution might look a little different, but the candidate should be able to test their solution with different inputs to verify correctness.

Assign points for each item on the Rubric, according to how well the candidate executed on that skill.

Add up all the points at the end, and record the total at the bottom of the page.

## Documentation

Record detailed notes on the rubric, to share with the candidate when the interview is complete.

## Solution

<details>
  <summary>Algorithm</summary>
  Take all the strings from the given input and add them to a Queue.  Our goal is to count k number of ducks from the q, the kth value representing the Goose to be removed from the Queue.  Dequeue k number of values from the Queue and re-enqueue all the values unless the value is the kth value, this is the Goose.  Doing this until there is only one Duck left in the Queue should remove one each time we dequeue values.  When there is only one left we can return that value.
</details>
<details>
  <summary>PseudoCode</summary>
  <pre><code>algorithm DUCK_DUCK_GOOSE:
  declare array STRINGS <- input array of strings
  declare number K <- input number
  declare queue QUEUE <- new Queue
  for each string in STRINGS:
    add string to QUEUE
  while QUEUE length is greater than one:
    for K number of times:
      dequeue string from QUEUE
      if this is the kth item removed:
        don't enqueue string
      else:
        re-enqueue string
  return last remaining string value in QUEUE</code></pre>
</details>
<details>
  <summary>Big O</summary>
  This solution will take 0(n * k) time to complete since we will need to iterate through our list of strings at least n times, while we iterate we will dequeue at least k times. Space complexity will be 0(n) since we are adding all input values to a Queue.  This will create a Queue that grows to size n, even though our Queue will be only hold one value at the end of the algorithm.
</details>
