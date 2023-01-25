'use strict';


function iterative(root) {
  let sum = 0;
  let queue = [];
  queue.push(root);

  while(queue.length) {
    let current = queue.shift();
    if (current.value % 2 !== 0) {
      sum += current.value;
    }
    if (current.left) queue.push(current.left);
    if (current.right) queue.push(current.right);
  }

  return sum;
}

function recursive(root) {
  if(!root) {
    return 0;
  }

  if (root.value % 2 !== 0) {
    return root.value + recursive(root.left) + recursive(root.right);
  } else {
    return 0 + recursive(root.left) + recursive(root.right);
  }
}

module.exports = {
  recursive,
  iterative
};
