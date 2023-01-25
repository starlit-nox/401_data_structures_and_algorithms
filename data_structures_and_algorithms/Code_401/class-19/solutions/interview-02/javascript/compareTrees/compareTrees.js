'use strict';

function compareTrees(dir1, dir2) {

  const countFiles = (node, sum = 0) => {
    if(!node) return 0;

    if (!node.left && !node.right) {
      return 1;
    } else {
      return countFiles(node.left, sum) + countFiles(node.right, sum);
    }
  }

  return countFiles(dir1.root) === countFiles(dir2.root);
}

module.exports = compareTrees;
