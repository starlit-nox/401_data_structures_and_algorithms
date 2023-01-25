'use strict';

const { Vertex, addVertex, addEdge, getVertices } = require('./graph');

function listFromMatrix(vertices, matrix) {
  const adjacencyList = new Map();

  // each element in the matrix represents a node in the vertices array.
  for (let vertex of vertices) {
    addVertex(adjacencyList, vertex);
  }

  // loop through the matrix
  for (let node in matrix) {
    for (let edge in matrix[node]) {
      if (matrix[node][edge]) {
        addEdge(adjacencyList, vertices[node], vertices[edge]) // add our edge between vertices.
      }
    }
  }

  return adjacencyList;
}

const nodes = [
  new Vertex('a'),
  new Vertex('b'),
  new Vertex('c'),
  new Vertex('d'),
  new Vertex('e')
];

const matrix = [
  [false, true, false, false, true],
  [true, false, true, true, false],
  [false, true, false, true, false],
  [false, true, true, false, true],
  [true, false, false, true, false]
];

describe('testing Our adjacency Matrix', () => {

  test('a Valid list of vertices is returned', () => {

    let list = listFromMatrix(nodes, matrix);
    expect(list).toBeTruthy();

    // grab all children from nodes
    let children_of_A = getVertices(list, nodes[0]);
    let children_of_B = getVertices(list, nodes[1]);
    let children_of_C = getVertices(list, nodes[2]);
    let children_of_D = getVertices(list, nodes[3]);
    let children_of_E = getVertices(list, nodes[4]);

    // check that all expected nodes are included in children
    expect(children_of_A.includes(nodes[1])).toBeTruthy();
    expect(children_of_A.includes(nodes[4])).toBeTruthy();
    expect(children_of_B.includes(nodes[0])).toBeTruthy();
    expect(children_of_B.includes(nodes[2])).toBeTruthy();
    expect(children_of_B.includes(nodes[3])).toBeTruthy();
    expect(children_of_C.includes(nodes[1])).toBeTruthy();
    expect(children_of_C.includes(nodes[3])).toBeTruthy();
    expect(children_of_D.includes(nodes[1])).toBeTruthy();
    expect(children_of_D.includes(nodes[2])).toBeTruthy();
    expect(children_of_D.includes(nodes[4])).toBeTruthy();
    expect(children_of_E.includes(nodes[0])).toBeTruthy();
    expect(children_of_E.includes(nodes[3])).toBeTruthy();
  });

});

