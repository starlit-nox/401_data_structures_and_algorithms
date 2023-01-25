# Interview 02

Given a graph, are 2 given nodes connected?

## Specifications

- Read all of the following instructions carefully.
- Act as an interviewer, giving a candidate a code challenge.
- Score the candidate according to the [Whiteboard Rubric](https://docs.google.com/spreadsheets/d/1scthkmARfzAFZrSYAp6LA2coOaoWUWbSzMbtIU4jcHw){:target="_blank"}
- You are free to offer suggestions or guidance (and see how they respond), but don't solve the challenge for the candidate.

## Feature Tasks

- The candidate should write a function that accepts as input two nodes and a graph, represented as an adjacency list.
- The format of the adjacency list can be specified by the candidate.
  - Unless otherwise specified, assume the graph is a directed graph.
- The function should traverse the graph, using any traversal method.
- The traversal should start at one node, and continue until the second node is found, or the traversal is completed.
- The return type of this method will be boolean.

The candidate should be able to traverse from Node A to determine if Node B is connected.

Input:

Two nodes:  `Node D, Node G`

Graph:

```bash
a| -> B -> C
b| -> D -> A
c| -> A -> D
d| -> B -> C -> F
e| -> F
f| -> E -> G
g| -> F
```

Output: True

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
  We need to traverse our Graph starting from one of the given input Nodes.  Create a Stack to store child Nodes, and a HashSet to store visited Nodes.  Add the starting Node to the Stack, and to the visited set of Nodes.  While the Stack is not empty, remove the top node from the Stack and set to current node.  Once removed, check if the current node is equal to the other input Node, if so return true.  If not, grab the children of the current node.  For each child node, check if it has been visited, if it has not, add it to the stack and mark as visited.  Continue until all children have been checked and true is returned.  If all nodes have been checked and our traversal is finished, return false.
</details>
<details>
  <summary>Pseudocode</summary>
  <pre><code>algorithm CONNECTED_NODES:
  declare node NODE_1 <- input node
  declare node NODE_2 <- input node
  declare graph GRAPH <- input graph
  declare stack CHILDREN <- new empty stack
  declare hashset VISITED <- new empty hashset
  add NODE_1 to CHILDREN
  add NODE_1 to VISITED
  while CHILDREN is not empty
    declare node CURRENT <- node popped from the top of CHILDREN
    check if CURRENT is equal to NODE_2:
      return true if so, else continue
    declare list NEIGHBORS <- all child nodes of CURRENT connected in GRAPH
    for every EDGE in NEIGHBORS
      check if the EDGEs node has been visited:
        if not, add EDGEs node to CHILDREN and to VISITED
  if traversal is finished, return false</code></pre>
</details>
<details>
  <summary>Big O</summary>
  Both space and time complexity for this solution will be 0(n).  At worst, our traversal may need to read all values, if our starting node is connected to all nodes stored in the graph.  In the same way, we may need to store all values in the graph, in both our stack, and our visited hashset, which would be 2(n), which we round down to (n).
</details>
