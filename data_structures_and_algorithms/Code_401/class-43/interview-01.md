# Interview 01

Estimate water usage for a given sprinkler system.

## Specifications

- Read all of the following instructions carefully.
- Act as an interviewer, giving a candidate a code challenge.
- Score the candidate according to the [Whiteboard Rubric](https://docs.google.com/spreadsheets/d/1scthkmARfzAFZrSYAp6LA2coOaoWUWbSzMbtIU4jcHw){:target="_blank"}
- You are free to offer suggestions or guidance (and see how they respond), but don't solve the challenge for the candidate.

## Feature Tasks

- Actual code is required for a complete answer.
- Avoid utilizing any of the built-in methods available in your language.
- Ask the candidate to write a function to calculate the water usage for a sprinkler system schematic provided.
  - The sprinkler system is made of an inlet and a number of connected sprinkler heads that spray water.
  - Each single sprinkler head has a T connection that can be connected to 0, 1, or 2 other sprinklers.
  - There are no connected loops in the system. That is, any given sprinkler head is connected to one other sprinkler where water comes from (or the inlet), and potentially some downstream heads.
  - Each sprinkler head is configured for a certain amount of output, each potentially different, in milliliters per minute.
  - Distance between sprinkler heads is irrelevant.
  - The function should be able to start at any given sprinkler, and return the water used from that point on in the system.
- Start by directing the candidate to decide in what flexible format they want the schematic to be provided.
  - What data structure best models the described system?
    - The best representation is a binary tree, where the first sprinkler fed from the inlet is the root.
    - Each node `value` is the water output that sprinkler head is configured for.
    - Note: This is NOT a BST (so higher/lower values can be anywhere), and there is no guarantee that the tree will be balanced.
- Then the candidate should write a function that receives a binary tree, and figures out the total amount of output for the system.
  - This means summing the node values across the whole tree.
- This problem can be approached in several ways:
  - Every node needs to be visited to add them all up.
  - This means the whole tree needs to be traversed.
    - So any solution for `n` nodes should require `O(n)` time and use `O(1)` extra space.
  - The candidate may choose breath-first traversal.
    - This can take more code to implement.
  - The preferred solution is a recursive depth-first traversal.
    - At each node, return the output for the node you are on, added to the total usage for each child node.
    - The code becomes very expressive:
      - `total = value + totalUsage(leftChild) + totalUsage(rightUsage)`

## Structure

Familiarize yourself with the grading rubric, so you know how to score the interview.

Look for effective problem solving, efficient use of time, and effective communication with the whiteboard space available.

Every solution might look a little different, but the candidate should be able to test their solution with different inputs to verify correctness.

Assign points for each item on the Rubric, according to how well the candidate executed on that skill.

Add up all the points at the end, and record the total at the bottom of the page.

## Example

| Input: `(value, leftBranch, rightBranch)` | Output: total usage |
|-----|----|
| `(35, (41, (33,,), (52,,) ), (59, (30, ,), (44, ,)))` | `294` |

## Documentation

Record detailed notes on the rubric, to share with the candidate when the interview is complete.

## Solution

<details>
  <summary>Algorithm</summary>
  In order to estimate our water usage, we'll traverse a Binary Tree that represents our sprinkler system.  Each Sprinkler head is represented by a node in our tree, and that value is the amount of milliliters per minute that our sprinkler requires.  If we traverse the tree and sum all values across the sprinkler system we should have a good estimate for water usage.  Our solution used a depth first recursive traversal, in this case our function will use pre-order traversal.  And at each node, we'll add to a number that represents our sum, and continue to sum as long as there are more sprinkler heads connected to our current sprinkler node.  Return the sum when all sprinkler nodes have been summed
</details>
<details>
  <summary>Pseudocode</summary>
  <pre><code>algorithm SUM_WATER_USAGE:
  declare node SPRINKLER <- input Node
  declare number SUM <- our sum value
  if SPRINKLER node is not null:
    add the SPRINKLER value to the SUM
    return SUM_WATER_USAGE on first SPRINKLER node plus SUM_WATER_USAGE on SPRINKLER second node</code></pre>
</details>
<details>
  <summary>Big O</summary>
  This solution's complexity scales directly with the input size for both space and time: 0(n).  All node values have to be read in order to calculate the sum value, so our code will run longer the more sprinkler heads our system has.  This solution also uses recursion, which will add a frame to the call stack every time we invoke our function on a new node.  This gives our function a linear complexity for both space and time: 0(n).
</details>
