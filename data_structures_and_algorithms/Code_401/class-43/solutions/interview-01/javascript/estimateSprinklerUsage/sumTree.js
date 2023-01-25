'use strict';

function sumTree(node) {
  if (node === null) {
    return 0;
  }
  return node.value + sumTree(node.left) + sumTree(node.right);
}

module.exports = sumTree;
