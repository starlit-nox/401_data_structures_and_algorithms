'use strict';

const sumTree = require('./sumTree.js');

class Node {
  constructor(value) {
    this.value = value;
    this.left = null;
    this.right = null;
  }
}

describe('Testing the tree sum function', () => {

  let root = new Node(35);
  root.left = new Node(41);
  root.right = new Node(33);
  root.left.left = new Node(52);
  root.right.left = new Node(59);
  root.right.right = new Node(30);
  root.right.right.left = new Node(44);

  test('should add up all value at tree nodes', () => {

    let sum = sumTree(root, 0);
    expect(sum).toEqual(294);
  });
})
