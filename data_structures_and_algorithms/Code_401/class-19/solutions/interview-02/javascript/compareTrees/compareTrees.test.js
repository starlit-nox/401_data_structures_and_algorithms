'use strict';

const compareTrees = require('./compareTrees.js');

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

describe('Compare Trees', () => {
  test('Testing similar trees with the same number of files', () => {
    const tree1 = new BinaryTree();
    tree1.root = new Node('folder');
    tree1.root.left = new Node('folder');
    tree1.root.left.left = new Node('file');
    tree1.root.left.right = new Node('folder');
    tree1.root.left.right.left = new Node('file');
    tree1.root.left.right.right = new Node('file');
    tree1.root.right = new Node('folder');
    tree1.root.right.right = new Node('folder');
    tree1.root.right.right.left = new Node('file');
    tree1.root.right.right.right = new Node('file');

    const tree2 = new BinaryTree();
    tree2.root = new Node('folder');
    tree2.root.left = new Node('folder');
    tree2.root.left.left = new Node('folder');
    tree2.root.left.left.left = new Node('file');
    tree2.root.left.left.right = new Node('file');
    tree2.root.right = new Node('folder');
    tree2.root.right.right = new Node('folder');
    tree2.root.right.right.left = new Node('file');
    tree2.root.right.right.right = new Node('folder');
    tree2.root.right.right.right.left = new Node('file');
    tree2.root.right.right.right.right = new Node('file');

    expect(compareTrees(tree1, tree2)).toEqual(true);
  });

  test('Testing similar trees with different number of files', () => {
    const tree1 = new BinaryTree();
    tree1.root = new Node('folder');
    tree1.root.left = new Node('folder');
    tree1.root.left.left = new Node('file');
    tree1.root.left.right = new Node('folder');
    tree1.root.left.right.left = new Node('file');
    tree1.root.left.right.right = new Node('file');
    tree1.root.right = new Node('folder');
    tree1.root.right.right = new Node('folder');
    tree1.root.right.right.left = new Node('file');

    const tree2 = new BinaryTree();
    tree2.root = new Node('folder');
    tree2.root.left = new Node('folder');
    tree2.root.left.left = new Node('folder');
    tree2.root.left.left.right = new Node('file');
    tree2.root.right = new Node('folder');
    tree2.root.right.left = new Node('file');
    tree2.root.right.right = new Node('folder');
    tree2.root.right.right.left = new Node('file');

    expect(compareTrees(tree1, tree2)).toEqual(false);
  });
});
