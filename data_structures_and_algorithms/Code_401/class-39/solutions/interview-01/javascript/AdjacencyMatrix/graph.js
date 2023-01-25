'use strict';

class Vertex {
  constructor(value) {
    this.value = value;
  }
}

class Edge{
  constructor(vertex) {
    this.vertex = vertex;
  }
}

function addVertex(list, vertex) {
  list.set(vertex, []);
}

function addEdge(list, startVertex, endVertex) {
  if (!list.has(startVertex) || !list.has(endVertex)) {
    throw new Error('__ERROR__ Invalid Nodes');
  }

  const adjacencies = list.get(startVertex);
  adjacencies.push(new Edge(endVertex));
}

function getVertices(list, vertex) {
  return list.get(vertex).map(edge => edge.vertex);
}

module.exports = {
  Vertex,
  Edge,
  addVertex,
  addEdge,
  getVertices
}
