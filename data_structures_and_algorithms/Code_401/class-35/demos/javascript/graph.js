'use strict';

class Vertex {
  constructor(value) {
    this.value = value;
  }
}

class Edge {
  constructor(vertex, weight) {
    this.vertex = vertex;
    // this.startNode = vertex;
    // this.endNode = vertex;
    this.weight = weight;
  }
}

class Graph {
  constructor() {
    //! Vinicio - this variable keeps track of Edges (neighbors)
    this._adjacencyList = new Map();
  }

  addVertex(vertex) {
    this._adjacencyList.set(vertex, []);
  }

  addDirectedEdge(startVertex, endVertex, weight = 0) {
    if (!this._adjacencyList.has(startVertex) || !this._adjacencyList.has(endVertex)) {
      throw new Error('__ERROR__ Invalid Nodes');
    }

    const adjacencies = this._adjacencyList.get(startVertex);
    adjacencies.push(new Edge(endVertex, weight));
  }

  getNeighbors(vertex) {
    if (!this._adjacencyList.has(vertex)) {
      throw new Error('__ERROR__ Invalid Vertex', vertex);
    }

    return [...this._adjacencyList.get(vertex)];
  }

  bfs(startNode) {

    const queue = [];
    const visitedNodes = new Set();

    queue.push(startNode);
    visitedNodes.add(startNode);

    while (queue.length) {
      let currentNode = queue.shift();
      let neighbors = this.getNeighbors(currentNode);

      for (let neighbor of neighbors) {

        const neighborNode = neighbor.vertex;

        if (!visitedNodes.has(neighborNode)) {
          visitedNodes.add(neighborNode);
          queue.push(neighborNode);
        } else {
          continue;
        }
      }
    }

    return visitedNodes;
  }

  dfs(startNode) {

    const stack = [startNode];
    const visitedNodes = new Set();

    visitedNodes.add(startNode);

    while (stack.length) {
      let current = stack.pop();
      let neighbors = this.getNeighbors(current);

      for (let edge of neighbors) {
        let neighborNode = edge.vertex;

        if (!visitedNodes.has(neighborNode)) {
          visitedNodes.add(neighborNode);
          stack.push(neighborNode);
        } else {
          continue;
        }
      }
    }

    return visitedNodes;
  }

  pathTo(startNode, goalNode) {

    const stack = [];
    const visitedNodes = new Set();
    const parentPath = new Map();

    stack.push(startNode);
    visitedNodes.add(startNode);

    while (stack.length) {

      const currentNode = stack.pop();

      console.log(currentNode, goalNode);
      if (currentNode === goalNode) {
        return parentPath;
      }

      const neighbors = this.getNeighbors(currentNode);

      for (let neighbor of neighbors) {

        const neighborNode = neighbor.vertex;

        if (visitedNodes.has(neighborNode)) {
          continue;
        } else {
          visitedNodes.add(neighborNode);
        }

        stack.push(neighborNode);

        parentPath.set(neighborNode, currentNode);

      }
    }
  }

}


const graph = new Graph();

const ten = new Vertex(10);
const two = new Vertex(2);
const six = new Vertex(6);
const seven = new Vertex(7);
const three = new Vertex(3);
const eight = new Vertex(8);

graph.addVertex(ten);
graph.addVertex(two);
graph.addVertex(six);
graph.addVertex(seven);
graph.addVertex(three);
graph.addVertex(eight);

graph.addDirectedEdge(ten, two);
graph.addDirectedEdge(ten, six);
graph.addDirectedEdge(ten, three);
// graph.addDirectedEdge(ten, seven);
graph.addDirectedEdge(two, seven);
graph.addDirectedEdge(six, seven);
graph.addDirectedEdge(six, eight);
graph.addDirectedEdge(three, eight);
graph.addDirectedEdge(eight, seven);


/**
 * Breadth First Test Case
 */
const breadthFirstExpected = new Set();
breadthFirstExpected.add(ten);
breadthFirstExpected.add(two);
breadthFirstExpected.add(six);
breadthFirstExpected.add(three);
breadthFirstExpected.add(seven);
breadthFirstExpected.add(eight);

const breadthFirstOutput = graph.bfs(ten);
testTraversal('BREADTH FIRST', breadthFirstExpected, breadthFirstOutput);


/**
 * Depth First Test Case
 */
const depthFirstExpected = new Set();
depthFirstExpected.add(ten);
depthFirstExpected.add(two);
depthFirstExpected.add(six);
depthFirstExpected.add(three);
depthFirstExpected.add(eight);
depthFirstExpected.add(seven);

const depthFirstOutput = graph.dfs(ten);
testTraversal('DEPTH FIRST', depthFirstExpected, depthFirstOutput);


/**
 * Path To Test Case
 */
const pathToExpected = new Map();
pathToExpected.set(two, ten);
pathToExpected.set(six, ten);
pathToExpected.set(three, ten);
pathToExpected.set(eight, three);
pathToExpected.set(seven, eight);

const pathToOutput = graph.pathTo(ten, seven);
testTraversal('PATH TO NODE', pathToExpected, pathToOutput);


/**
 * Traversal testing function
 * @param {String} type - type of traversal your method is performing.
 * @param {Iterable} expected - expected output from the traversal method.
 * @param {Iterable} actual - actual output from the traversal method.
 */
function testTraversal(type, expected, actual) {
  let assert = JSON.stringify([...expected]);
  let output = JSON.stringify([...actual]);
  let test = assert === output;
  console.log(`Test for ${type} traversal is: ${test ? 'Passing' : 'Failing'}`);
  console.assert(test,
    `
    Assertion: ${assert}\n
    Output: ${output}
    `
  );
}
