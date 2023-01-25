'use strict';

const binaryTreeSum = require('./binaryTreeSum.js');

class Node {
  constructor(value) {
    this.value = value;
    this.left = null;
    this.right = null;
  }
}

class BinaryTree {
  constructor() {
    this.root = null;
  }
}

describe('Binary Tree Sum', () => {
  test('Simple tree using a recursive solution', () => {
    const tree = new BinaryTree();
    tree.root = new Node(1);
    tree.root.left = new Node(2);
    tree.root.right = new Node(3);
    tree.root.left.right = new Node(5);

    expect(binaryTreeSum.recursive(tree.root)).toEqual(9);
  });

  test('Simple tree using an iterative solution', () => {
    const tree = new BinaryTree();
    tree.root = new Node(5);
    tree.root.left = new Node(18);
    tree.root.right = new Node(7);
    tree.root.left.right = new Node(10);

    expect(binaryTreeSum.iterative(tree.root)).toEqual(12);
  });

  test('Larger tree using a recursive solution', () => {
    const tree = new BinaryTree();
    tree.root = new Node(1);
    tree.root.left = new Node(5);
    tree.root.right = new Node(13);
    tree.root.left.right = new Node(6);
    tree.root.left.left = new Node(20);
    tree.root.right.left = new Node(31);
    tree.root.right.right = new Node(44);
    tree.root.left.left.left = new Node(9);
    tree.root.right.left.right = new Node(11);

    expect(binaryTreeSum.recursive(tree.root)).toEqual(70);
  });

  test('Larger tree using an iterative solution', () => {
    const tree = new BinaryTree();
    tree.root = new Node(3);
    tree.root.left = new Node(10);
    tree.root.right = new Node(13);
    tree.root.left.right = new Node(6);
    tree.root.left.left = new Node(20);
    tree.root.right.left = new Node(25);
    tree.root.right.right = new Node(44);
    tree.root.left.left.left = new Node(19);
    tree.root.right.left.right = new Node(22);
    tree.root.left.left.right = new Node(12);

    expect(binaryTreeSum.iterative(tree.root)).toEqual(60);
  });
});
