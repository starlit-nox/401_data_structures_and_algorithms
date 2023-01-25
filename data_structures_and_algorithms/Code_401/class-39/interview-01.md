# Interview 01

Given an adjacency matrix representation of a graph, return the adjacency list representation.

## Specifications

- Read all of the following instructions carefully.
- Act as an interviewer, giving a candidate a code challenge.
- Score the candidate according to the [Whiteboard Rubric](https://docs.google.com/spreadsheets/d/1scthkmARfzAFZrSYAp6LA2coOaoWUWbSzMbtIU4jcHw){:target="_blank"}
- You are free to offer suggestions or guidance (and see how they respond), but don't solve the challenge for the candidate.

## Feature Tasks

- Give the candidate an example of what the adjacency matrix could look like (see below for example).
- The input will be an array of nodes and a 2D array of booleans.
  - The 2D array has the same number of elements as the array of nodes, as do the sub-arrays.
  - Each index in the 2D array will therefore map to an index in the array of nodes (which can then be used as a reference for the node).
- The candidate will want to use a nested for loop to iterate through the matrix and determine from there what vertices connect to others.
- To assist in the construction of the adjacency list, each row of the matrix is going to be a separate node.
- for every 1 in that row, that is going to be a valid connection and can then be converted to the list for construction.

## Notes

- In the following example, the letters ("a" through "e") are shown here to represent the values associated each node.
- The zeroes and ones are there to visually represent the presence of a connection (edge) between the 2 nodes.
  - While they are displayed as numbers in the drawing, these are not to be used as values within your algorithm, but as booleans
  - Assume actual boolean values (true, false) in your array.

Input:

```bash

  Array 1: [ {a}, {b}, {c}, {d}, {e} ]

  Array 2:
  [
    [f, t, f, f, t],
    [t, f, t, t, f],
    [f, t, f, t, f],
    [f, t, t, f, t],
    [t, f, f, t, f]
  ]

  Visually, the matrix looks like this

    |  a  b  c  d  e
    ----------------
  a |  0  1  0  0  1
  b |  1  0  1  1  0
  c |  0  1  0  1  0
  d |  0  1  1  0  1
  e |  1  0  0  1  0

```

Output:

```bash
a| -> b -> e

b|-> a -> c -> d

c| -> b -> d

d| -> b -> c -> e

e| -> a -> d

```

## Stretch Goals

Are you able to tell which vertices have the most connections?

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
  Create a new adjacency list to store all nodes and edges created from the matrix. Iterate through our input list of vertices and add them our our adjacency list.  Once we have all vertices in our list, Iterate through the input matrix. Since it is a 2 dimensional array, our function will use a nested loop to read all the values for edges connecting each node in the matrix.  Use the outer loop to track the adjacencies for a given node, and the inner loop to read the edges from a node to another node.  If the value of the outer loop node returns true for the value in the matrix,  add that edge to the adjacency list.
</details>
<details>
  <summary>Pseudocode</summary>
  <pre><code>algorithm MATRIX_TO_LIST:
  declare array of nodes VERTICES <- input list
  declare array of edges MATRIX <- input list
  declare list of adjacencies ADJACENCIES <- empty list
  for every NODE in VERTICES:
    add NODE to ADJACENCIES
  for every EDGE in NODE within MATRIX:
    if the value stored at each EDGE for a given NODE within the MATRIX is true:
      add EDGE to NODE in ADJACENCIES
  return ADJACENCIES</code></pre>
</details>
<details>
  <summary>Big O</summary>
  This solution has a time complexity of 0(n) and a space complexity of 0(n).Even though we have a nested for loop,  the inner loop is only to allow us to read all the values present in 2d array.  At most we are running our check on a vertex present in our matrix for as many values are present in the 2d array of length n.  Since we are adding values to our adjacency list, in the worst case scenario (given a completely connected graph) we will need to create (n) space within our list.
</details>
